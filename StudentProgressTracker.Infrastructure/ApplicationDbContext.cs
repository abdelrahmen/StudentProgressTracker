using Microsoft.EntityFrameworkCore;
using StudentProgressTracker.Domain.Entities;
using StudentProgressTracker.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<TeacherStudent> TeacherStudents { get; set; }
    public DbSet<StudentProgress> StudentProgress { get; set; }
    public DbSet<Assessment> Assessments { get; set; }
    public DbSet<ActivityLog> ActivityLogs { get; set; }
    public DbSet<AuditLog> AuditLogs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // User configurations
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.Email).IsUnique();
            entity.HasIndex(e => e.Role);
            entity.HasIndex(e => e.Grade);
            entity.HasIndex(e => e.LastActivityDate);
            entity.HasIndex(e => new { e.LastName, e.FirstName });
        });

        // Subject configurations
        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasIndex(e => e.Name).IsUnique();
        });

        // TeacherStudent configurations
        modelBuilder.Entity<TeacherStudent>(entity =>
        {
            entity.HasIndex(e => new { e.TeacherId, e.StudentId, e.SubjectId }).IsUnique();

            entity.HasOne(ts => ts.Teacher)
                .WithMany(u => u.TeacherAssignments)
                .HasForeignKey(ts => ts.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(ts => ts.Student)
                .WithMany(u => u.StudentAssignments)
                .HasForeignKey(ts => ts.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(ts => ts.Subject)
                .WithMany(s => s.TeacherStudents)
                .HasForeignKey(ts => ts.SubjectId);
        });

        // StudentProgress configurations
        modelBuilder.Entity<StudentProgress>(entity =>
        {
            entity.HasIndex(e => new { e.StudentId, e.SubjectId }).IsUnique();
            entity.HasIndex(e => e.LastActivity);
            entity.HasIndex(e => e.CompletionPercentage);

            entity.HasOne(sp => sp.Student)
                .WithMany(u => u.StudentProgress)
                .HasForeignKey(sp => sp.StudentId);

            entity.HasOne(sp => sp.Subject)
                .WithMany(s => s.StudentProgress)
                .HasForeignKey(sp => sp.SubjectId);
        });

        // Assessment configurations
        modelBuilder.Entity<Assessment>(entity =>
        {
            entity.HasIndex(e => new { e.StudentId, e.SubjectId });
            entity.HasIndex(e => e.DueDate);
            entity.HasIndex(e => e.Type);

            entity.HasOne(a => a.Student)
                .WithMany(u => u.StudentAssessments)
                .HasForeignKey(a => a.StudentId);

            entity.HasOne(a => a.Subject)
                .WithMany(s => s.Assessments)
                .HasForeignKey(a => a.SubjectId);
        });

        // ActivityLog configurations
        modelBuilder.Entity<ActivityLog>(entity =>
        {
            entity.HasIndex(e => new { e.StudentId, e.ActivityDate });
            entity.HasIndex(e => e.ActivityType);

            entity.HasOne(al => al.Student)
                .WithMany(u => u.ActivityLogs)
                .HasForeignKey(al => al.StudentId);

            entity.HasOne(al => al.Subject)
                .WithMany()
                .HasForeignKey(al => al.SubjectId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<User>().HasData(SeedData.GetUsers());
        modelBuilder.Entity<Subject>().HasData(SeedData.GetSubjects());
        modelBuilder.Entity<TeacherStudent>().HasData(SeedData.GetTeacherStudents());
        modelBuilder.Entity<StudentProgress>().HasData(SeedData.GetStudentProgresses());
        modelBuilder.Entity<Assessment>().HasData(SeedData.GetAssessments());
        modelBuilder.Entity<ActivityLog>().HasData(SeedData.GetActivityLogs());
    }

    public override int SaveChanges()
    {
        UpdateTimestamps();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        UpdateTimestamps();
        return base.SaveChangesAsync(cancellationToken);
    }

    private void UpdateTimestamps()
    {
        var entries = ChangeTracker.Entries()
            .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

        foreach (var entry in entries)
        {
            if (entry.Entity is IAuditable entity)
            {
                if (entry.State == EntityState.Added)
                    entity.CreatedAt = DateTime.UtcNow;
                entity.UpdatedAt = DateTime.UtcNow;
            }
        }
    }
}
