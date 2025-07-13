using StudentProgressTracker.Domain.Constants;
using StudentProgressTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Infrastructure;

public static class SeedData
{
    private const string PasswordHashFor1234 = "AQAAAAIAAYagAAAAEOb7wmyh/dP4G9igDpJzDsbcRrVTv7U6kJyUfS1DATRmi2VvSJIAY9+ntRx2yVe1aQ==";

    public static List<User> GetUsers()
    {
        var users = new List<User>
        {
            // Teachers
            new User
            {
                Id = 1,
                Email = "teacher1@example.com",
                FirstName = "Ali",
                LastName = "Hassan",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Teacher,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 2,
                Email = "teacher2@example.com",
                FirstName = "Sara",
                LastName = "Ibrahim",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Teacher,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },

            // Students
            new User
            {
                Id = 3,
                Email = "student1@example.com",
                FirstName = "Omar",
                LastName = "Nabil",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade3,
                EnrollmentDate = new DateTime(2023, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 4,
                Email = "student2@example.com",
                FirstName = "Laila",
                LastName = "Adel",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade4,
                EnrollmentDate = new DateTime(2022, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 5,
                Email = "student3@example.com",
                FirstName = "Youssef",
                LastName = "Khaled",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade5,
                EnrollmentDate = new DateTime(2021, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 6,
                Email = "student4@example.com",
                FirstName = "Fatima",
                LastName = "Gamal",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade3,
                EnrollmentDate = new DateTime(2023, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 7,
                Email = "student5@example.com",
                FirstName = "Karim",
                LastName = "Samir",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade4,
                EnrollmentDate = new DateTime(2022, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 8,
                Email = "student6@example.com",
                FirstName = "Hania",
                LastName = "Tarek",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade5,
                EnrollmentDate = new DateTime(2021, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 9,
                Email = "student7@example.com",
                FirstName = "Ziad",
                LastName = "Ashraf",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade6,
                EnrollmentDate = new DateTime(2020, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 10,
                Email = "student8@example.com",
                FirstName = "Salma",
                LastName = "Ehab",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade2,
                EnrollmentDate = new DateTime(2024, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 11,
                Email = "student9@example.com",
                FirstName = "Ahmed",
                LastName = "Said",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade1,
                EnrollmentDate = new DateTime(2025, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 12,
                Email = "student10@example.com",
                FirstName = "Nour",
                LastName = "Walid",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade4,
                EnrollmentDate = new DateTime(2022, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 13,
                Email = "student11@example.com",
                FirstName = "Mohamed",
                LastName = "Sherif",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade5,
                EnrollmentDate = new DateTime(2021, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 14,
                Email = "student12@example.com",
                FirstName = "Jana",
                LastName = "Hesham",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade3,
                EnrollmentDate = new DateTime(2023, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 15,
                Email = "student13@example.com",
                FirstName = "Adam",
                LastName = "Medhat",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade2,
                EnrollmentDate = new DateTime(2024, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 16,
                Email = "student14@example.com",
                FirstName = "Mariam",
                LastName = "Fares",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade6,
                EnrollmentDate = new DateTime(2020, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 17,
                Email = "student15@example.com",
                FirstName = "Ibrahim",
                LastName = "Amr",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade1,
                EnrollmentDate = new DateTime(2025, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 18,
                Email = "student16@example.com",
                FirstName = "Farida",
                LastName = "Hossam",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade5,
                EnrollmentDate = new DateTime(2021, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 19,
                Email = "student17@example.com",
                FirstName = "Mostafa",
                LastName = "Maher",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade4,
                EnrollmentDate = new DateTime(2022, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 20,
                Email = "student18@example.com",
                FirstName = "Hana",
                LastName = "Ismail",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade2,
                EnrollmentDate = new DateTime(2024, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 21,
                Email = "student19@example.com",
                FirstName = "Yassin",
                LastName = "Tamer",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade3,
                EnrollmentDate = new DateTime(2023, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new User
            {
                Id = 22,
                Email = "student20@example.com",
                FirstName = "Malak",
                LastName = "Wael",
                PasswordHash = PasswordHashFor1234,
                Role = Roles.Student,
                Grade = Grade.Grade1,
                EnrollmentDate = new DateTime(2025, 9, 1),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            }
        };
        return users;
    }

    public static List<Subject> GetSubjects()
    {
        return new List<Subject>
        {
            new Subject
            {
                Id = 1,
                Name = "Mathematics",
                Description = "Covers fundamental concepts of algebra, geometry, and arithmetic.",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new Subject
            {
                Id = 2,
                Name = "Science",
                Description = "An introduction to biology, chemistry, and physics.",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new Subject
            {
                Id = 3,
                Name = "Arabic Language",
                Description = "Focuses on Arabic grammar, literature, and composition.",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new Subject
            {
                Id = 4,
                Name = "English Language",
                Description = "Develops skills in reading, writing, and speaking English.",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new Subject
            {
                Id = 5,
                Name = "History",
                Description = "A study of major world events and civilizations.",
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            },
            new Subject
            {
                Id = 6,
                Name = "Computer Science",
                Description = "Learning the basics of programming and computational thinking.",
                IsActive = false,
                CreatedAt = DateTime.UtcNow
            }
        };
    }

    public static List<TeacherStudent> GetTeacherStudents()
    {
        return new List<TeacherStudent>
        {
            // Teacher 1 (Ali Hassan, ID=1) teaching Math (SubjectId=1)
            new TeacherStudent { Id = 1, TeacherId = 1, StudentId = 3, SubjectId = 1, AssignedDate = new DateTime(2023, 9, 5) },
            new TeacherStudent { Id = 2, TeacherId = 1, StudentId = 6, SubjectId = 1, AssignedDate = new DateTime(2023, 9, 5) },
            new TeacherStudent { Id = 3, TeacherId = 1, StudentId = 9, SubjectId = 1, AssignedDate = new DateTime(2023, 9, 5) },

            // Teacher 1 (Ali Hassan, ID=1) teaching Science (SubjectId=2)
            new TeacherStudent { Id = 4, TeacherId = 1, StudentId = 4, SubjectId = 2, AssignedDate = new DateTime(2022, 9, 6) },
            new TeacherStudent { Id = 5, TeacherId = 1, StudentId = 7, SubjectId = 2, AssignedDate = new DateTime(2022, 9, 6) },
            new TeacherStudent { Id = 6, TeacherId = 1, StudentId = 10, SubjectId = 2, AssignedDate = new DateTime(2022, 9, 6) },
        
            // Teacher 2 (Sara Ibrahim, ID=2) teaching Arabic Language (SubjectId=3)
            new TeacherStudent { Id = 7, TeacherId = 2, StudentId = 3, SubjectId = 3, AssignedDate = new DateTime(2023, 9, 5) },
            new TeacherStudent { Id = 8, TeacherId = 2, StudentId = 6, SubjectId = 3, AssignedDate = new DateTime(2023, 9, 5) },
            new TeacherStudent { Id = 9, TeacherId = 2, StudentId = 9, SubjectId = 3, AssignedDate = new DateTime(2023, 9, 5) },

            // Teacher 2 (Sara Ibrahim, ID=2) teaching English Language (SubjectId=4)
            new TeacherStudent { Id = 10, TeacherId = 2, StudentId = 5, SubjectId = 4, AssignedDate = new DateTime(2021, 9, 7) },
            new TeacherStudent { Id = 11, TeacherId = 2, StudentId = 8, SubjectId = 4, AssignedDate = new DateTime(2021, 9, 7) },
            new TeacherStudent { Id = 12, TeacherId = 2, StudentId = 11, SubjectId = 4, AssignedDate = new DateTime(2021, 9, 7) },
        
            // Example of an inactive assignment to the inactive Computer Science course (SubjectId=6)
            new TeacherStudent { Id = 13, TeacherId = 2, StudentId = 13, SubjectId = 6, IsActive = false, AssignedDate = new DateTime(2024, 2, 1) }
        };
    }

    public static List<StudentProgress> GetStudentProgresses()
    {
        return new List<StudentProgress>
        {
            // Student 3 (Omar Nabil) - Mathematics (SubjectId=1)
            new StudentProgress
            {
                Id = 1,
                StudentId = 3,
                SubjectId = 1,
                CompletionPercentage = 75.50m,
                PerformanceScore = 82.00m,
                TimeSpent = TimeSpan.FromHours(45),
                CompletedAssignments = 15,
                TotalAssignments = 20,
                LastActivity = DateTime.UtcNow.AddDays(-5),
                CreatedAt = DateTime.UtcNow.AddMonths(-3),
                UpdatedAt = DateTime.UtcNow.AddDays(-1)
            },
            // Student 3 (Omar Nabil) - Arabic Language (SubjectId=3)
            new StudentProgress
            {
                Id = 2,
                StudentId = 3,
                SubjectId = 3,
                CompletionPercentage = 90.00m,
                PerformanceScore = 95.00m,
                TimeSpent = TimeSpan.FromHours(60),
                CompletedAssignments = 18,
                TotalAssignments = 18,
                LastActivity = DateTime.UtcNow.AddDays(-2),
                CreatedAt = DateTime.UtcNow.AddMonths(-3),
                UpdatedAt = DateTime.UtcNow
            },

            // Student 4 (Laila Adel) - Science (SubjectId=2)
            new StudentProgress
            {
                Id = 3,
                StudentId = 4,
                SubjectId = 2,
                CompletionPercentage = 60.25m,
                PerformanceScore = 70.50m,
                TimeSpent = TimeSpan.FromHours(30),
                CompletedAssignments = 10,
                TotalAssignments = 20,
                LastActivity = DateTime.UtcNow.AddDays(-10),
                CreatedAt = DateTime.UtcNow.AddMonths(-6),
                UpdatedAt = DateTime.UtcNow.AddDays(-3)
            },

            // Student 5 (Youssef Khaled) - English Language (SubjectId=4)
            new StudentProgress
            {
                Id = 4,
                StudentId = 5,
                SubjectId = 4,
                CompletionPercentage = 85.00m,
                PerformanceScore = 88.00m,
                TimeSpent = TimeSpan.FromHours(50),
                CompletedAssignments = 12,
                TotalAssignments = 15,
                LastActivity = DateTime.UtcNow.AddDays(-1),
                CreatedAt = DateTime.UtcNow.AddMonths(-4),
                UpdatedAt = DateTime.UtcNow
            },

            // Student 6 (Fatima Gamal) - Mathematics (SubjectId=1)
            new StudentProgress
            {
                Id = 5,
                StudentId = 6,
                SubjectId = 1,
                CompletionPercentage = 50.00m,
                PerformanceScore = 65.00m,
                TimeSpent = TimeSpan.FromHours(25),
                CompletedAssignments = 8,
                TotalAssignments = 16,
                LastActivity = DateTime.UtcNow.AddDays(-7),
                CreatedAt = DateTime.UtcNow.AddMonths(-2),
                UpdatedAt = DateTime.UtcNow.AddDays(-2)
            },
            // Student 6 (Fatima Gamal) - Arabic Language (SubjectId=3)
            new StudentProgress
            {
                Id = 6,
                StudentId = 6,
                SubjectId = 3,
                CompletionPercentage = 70.00m,
                PerformanceScore = 75.00m,
                TimeSpent = TimeSpan.FromHours(40),
                CompletedAssignments = 14,
                TotalAssignments = 20,
                LastActivity = DateTime.UtcNow.AddDays(-3),
                CreatedAt = DateTime.UtcNow.AddMonths(-2),
                UpdatedAt = DateTime.UtcNow.AddDays(-1)
            },

            // Student 7 (Karim Samir) - Science (SubjectId=2)
            new StudentProgress
            {
                Id = 7,
                StudentId = 7,
                SubjectId = 2,
                CompletionPercentage = 95.00m,
                PerformanceScore = 92.00m,
                TimeSpent = TimeSpan.FromHours(70),
                CompletedAssignments = 19,
                TotalAssignments = 20,
                LastActivity = DateTime.UtcNow.AddHours(-12),
                CreatedAt = DateTime.UtcNow.AddMonths(-5),
                UpdatedAt = DateTime.UtcNow
            },

            // Student 8 (Hania Tarek) - English Language (SubjectId=4)
            new StudentProgress
            {
                Id = 8,
                StudentId = 8,
                SubjectId = 4,
                CompletionPercentage = 40.00m,
                PerformanceScore = 55.00m,
                TimeSpent = TimeSpan.FromHours(20),
                CompletedAssignments = 6,
                TotalAssignments = 15,
                LastActivity = DateTime.UtcNow.AddDays(-15),
                CreatedAt = DateTime.UtcNow.AddMonths(-7),
                UpdatedAt = DateTime.UtcNow.AddDays(-5)
            },

            // Student 9 (Ziad Ashraf) - Mathematics (SubjectId=1)
            new StudentProgress
            {
                Id = 9,
                StudentId = 9,
                SubjectId = 1,
                CompletionPercentage = 80.00m,
                PerformanceScore = 88.00m,
                TimeSpent = TimeSpan.FromHours(55),
                CompletedAssignments = 17,
                TotalAssignments = 20,
                LastActivity = DateTime.UtcNow.AddDays(-4),
                CreatedAt = DateTime.UtcNow.AddMonths(-4),
                UpdatedAt = DateTime.UtcNow.AddDays(-1)
            },
            // Student 9 (Ziad Ashraf) - Arabic Language (SubjectId=3)
            new StudentProgress
            {
                Id = 10,
                StudentId = 9,
                SubjectId = 3,
                CompletionPercentage = 65.00m,
                PerformanceScore = 72.00m,
                TimeSpent = TimeSpan.FromHours(35),
                CompletedAssignments = 13,
                TotalAssignments = 20,
                LastActivity = DateTime.UtcNow.AddDays(-6),
                CreatedAt = DateTime.UtcNow.AddMonths(-4),
                UpdatedAt = DateTime.UtcNow.AddDays(-2)
            },

            // Student 10 (Salma Ehab) - Science (SubjectId=2)
            new StudentProgress
            {
                Id = 11,
                StudentId = 10,
                SubjectId = 2,
                CompletionPercentage = 78.00m,
                PerformanceScore = 85.00m,
                TimeSpent = TimeSpan.FromHours(48),
                CompletedAssignments = 16,
                TotalAssignments = 20,
                LastActivity = DateTime.UtcNow.AddDays(-2),
                CreatedAt = DateTime.UtcNow.AddMonths(-3),
                UpdatedAt = DateTime.UtcNow
            },
            // Student 10 (Salma Ehab) - History (SubjectId=5)
            new StudentProgress
            {
                Id = 12,
                StudentId = 10,
                SubjectId = 5,
                CompletionPercentage = 92.00m,
                PerformanceScore = 90.00m,
                TimeSpent = TimeSpan.FromHours(55),
                CompletedAssignments = 10,
                TotalAssignments = 10,
                LastActivity = DateTime.UtcNow.AddDays(-1),
                CreatedAt = DateTime.UtcNow.AddMonths(-3),
                UpdatedAt = DateTime.UtcNow
            },

            // Student 11 (Ahmed Said) - English Language (SubjectId=4)
            new StudentProgress
            {
                Id = 13,
                StudentId = 11,
                SubjectId = 4,
                CompletionPercentage = 20.00m,
                PerformanceScore = 40.00m,
                TimeSpent = TimeSpan.FromHours(10),
                CompletedAssignments = 3,
                TotalAssignments = 15,
                LastActivity = DateTime.UtcNow.AddDays(-20),
                CreatedAt = DateTime.UtcNow.AddMonths(-1),
                UpdatedAt = DateTime.UtcNow.AddDays(-10)
            },

            // Student 12 (Nour Walid) - Mathematics (SubjectId=1)
            new StudentProgress
            {
                Id = 14,
                StudentId = 12,
                SubjectId = 1,
                CompletionPercentage = 88.00m,
                PerformanceScore = 91.00m,
                TimeSpent = TimeSpan.FromHours(60),
                CompletedAssignments = 18,
                TotalAssignments = 20,
                LastActivity = DateTime.UtcNow.AddDays(-1),
                CreatedAt = DateTime.UtcNow.AddMonths(-5),
                UpdatedAt = DateTime.UtcNow
            },

            // Student 13 (Mohamed Sherif) - Computer Science (SubjectId=6) - Inactive subject, but progress exists
            new StudentProgress
            {
                Id = 15,
                StudentId = 13,
                SubjectId = 6,
                CompletionPercentage = 10.00m,
                PerformanceScore = 30.00m,
                TimeSpent = TimeSpan.FromHours(5),
                CompletedAssignments = 1,
                TotalAssignments = 10,
                LastActivity = DateTime.UtcNow.AddMonths(-1),
                CreatedAt = DateTime.UtcNow.AddMonths(-2),
                UpdatedAt = DateTime.UtcNow.AddMonths(-1)
            },

            // Student 14 (Jana Hesham) - Arabic Language (SubjectId=3)
            new StudentProgress
            {
                Id = 16,
                StudentId = 14,
                SubjectId = 3,
                CompletionPercentage = 70.00m,
                PerformanceScore = 78.00m,
                TimeSpent = TimeSpan.FromHours(42),
                CompletedAssignments = 14,
                TotalAssignments = 20,
                LastActivity = DateTime.UtcNow.AddDays(-3),
                CreatedAt = DateTime.UtcNow.AddMonths(-3),
                UpdatedAt = DateTime.UtcNow.AddDays(-1)
            },

            // Student 15 (Adam Medhat) - Science (SubjectId=2)
            new StudentProgress
            {
                Id = 17,
                StudentId = 15,
                SubjectId = 2,
                CompletionPercentage = 55.00m,
                PerformanceScore = 62.00m,
                TimeSpent = TimeSpan.FromHours(28),
                CompletedAssignments = 9,
                TotalAssignments = 20,
                LastActivity = DateTime.UtcNow.AddDays(-8),
                CreatedAt = DateTime.UtcNow.AddMonths(-1),
                UpdatedAt = DateTime.UtcNow.AddDays(-4)
            },

            // Student 16 (Mariam Fares) - History (SubjectId=5)
            new StudentProgress
            {
                Id = 18,
                StudentId = 16,
                SubjectId = 5,
                CompletionPercentage = 98.00m,
                PerformanceScore = 99.00m,
                TimeSpent = TimeSpan.FromHours(75),
                CompletedAssignments = 19,
                TotalAssignments = 19,
                LastActivity = DateTime.UtcNow.AddDays(-1),
                CreatedAt = DateTime.UtcNow.AddMonths(-6),
                UpdatedAt = DateTime.UtcNow
            },

            // Student 17 (Ibrahim Amr) - English Language (SubjectId=4)
            new StudentProgress
            {
                Id = 19,
                StudentId = 17,
                SubjectId = 4,
                CompletionPercentage = 35.00m,
                PerformanceScore = 48.00m,
                TimeSpent = TimeSpan.FromHours(18),
                CompletedAssignments = 5,
                TotalAssignments = 15,
                LastActivity = DateTime.UtcNow.AddDays(-12),
                CreatedAt = DateTime.UtcNow.AddMonths(-1),
                UpdatedAt = DateTime.UtcNow.AddDays(-5)
            },

            // Student 18 (Farida Hossam) - Mathematics (SubjectId=1)
            new StudentProgress
            {
                Id = 20,
                StudentId = 18,
                SubjectId = 1,
                CompletionPercentage = 72.00m,
                PerformanceScore = 79.00m,
                TimeSpent = TimeSpan.FromHours(40),
                CompletedAssignments = 14,
                TotalAssignments = 20,
                LastActivity = DateTime.UtcNow.AddDays(-6),
                CreatedAt = DateTime.UtcNow.AddMonths(-4),
                UpdatedAt = DateTime.UtcNow.AddDays(-2)
            }
        };


    }

    public static List<Assessment> GetAssessments()
    {
        return new List<Assessment>
        {
            // Student 3 (Omar Nabil) - Mathematics (SubjectId=1)
            new Assessment
            {
                Id = 1,
                StudentId = 3,
                SubjectId = 1,
                Title = "Algebra Midterm Exam",
                Type = "Test",
                Score = 85.00m,
                MaxScore = 100.00m,
                CompletedAt = new DateTime(2025, 6, 15, 10, 0, 0),
                DueDate = new DateTime(2025, 6, 15, 17, 0, 0),
                IsCompleted = true,
                CreatedAt = new DateTime(2025, 5, 1, 9, 0, 0),
                UpdatedAt = new DateTime(2025, 6, 15, 10, 0, 0)
            },
            new Assessment
            {
                Id = 2,
                StudentId = 3,
                SubjectId = 1,
                Title = "Geometry Homework 5",
                Type = "Assignment",
                Score = 28.00m,
                MaxScore = 30.00m,
                CompletedAt = new DateTime(2025, 7, 10, 14, 30, 0),
                DueDate = new DateTime(2025, 7, 10, 23, 59, 59),
                IsCompleted = true,
                CreatedAt = new DateTime(2025, 7, 1, 8, 0, 0),
                UpdatedAt = new DateTime(2025, 7, 10, 14, 30, 0)
            },
            new Assessment
            {
                Id = 3,
                StudentId = 3,
                SubjectId = 1,
                Title = "Fractions Quiz",
                Type = "Quiz",
                Score = null,
                MaxScore = 20.00m,
                CompletedAt = null,
                DueDate = new DateTime(2025, 7, 20, 10, 0, 0),
                IsCompleted = false,
                CreatedAt = new DateTime(2025, 7, 11, 11, 0, 0),
                UpdatedAt = new DateTime(2025, 7, 11, 11, 0, 0)
            },

            // Student 4 (Laila Adel) - Science (SubjectId=2)
            new Assessment
            {
                Id = 4,
                StudentId = 4,
                SubjectId = 2,
                Title = "Photosynthesis Lab Report",
                Type = "Project",
                Score = 92.50m,
                MaxScore = 100.00m,
                CompletedAt = new DateTime(2025, 5, 25, 16, 0, 0),
                DueDate = new DateTime(2025, 5, 26, 23, 59, 59),
                IsCompleted = true,
                CreatedAt = new DateTime(2025, 5, 10, 10, 0, 0),
                UpdatedAt = new DateTime(2025, 5, 25, 16, 0, 0)
            },
            new Assessment
            {
                Id = 5,
                StudentId = 4,
                SubjectId = 2,
                Title = "Chemical Reactions Quiz",
                Type = "Quiz",
                Score = 15.00m,
                MaxScore = 20.00m,
                CompletedAt = new DateTime(2025, 6, 30, 9, 0, 0),
                DueDate = new DateTime(2025, 6, 30, 12, 0, 0),
                IsCompleted = true,
                CreatedAt = new DateTime(2025, 6, 25, 14, 0, 0),
                UpdatedAt = new DateTime(2025, 6, 30, 9, 0, 0)
            },
            new Assessment
            {
                Id = 6,
                StudentId = 4,
                SubjectId = 2,
                Title = "Physics Principles Test",
                Type = "Test",
                Score = null,
                MaxScore = 100.00m,
                CompletedAt = null,
                DueDate = new DateTime(2025, 7, 10, 17, 0, 0), // Overdue
                IsCompleted = false,
                CreatedAt = new DateTime(2025, 6, 20, 9, 0, 0),
                UpdatedAt = new DateTime(2025, 6, 20, 9, 0, 0)
            },

            // Student 5 (Youssef Khaled) - English Language (SubjectId=4)
            new Assessment
            {
                Id = 7,
                StudentId = 5,
                SubjectId = 4,
                Title = "Essay: My Favorite Book",
                Type = "Assignment",
                Score = 45.00m,
                MaxScore = 50.00m,
                CompletedAt = new DateTime(2025, 7, 5, 20, 0, 0),
                DueDate = new DateTime(2025, 7, 5, 23, 59, 59),
                IsCompleted = true,
                CreatedAt = new DateTime(2025, 6, 20, 10, 0, 0),
                UpdatedAt = new DateTime(2025, 7, 5, 20, 0, 0)
            },
            new Assessment
            {
                Id = 8,
                StudentId = 5,
                SubjectId = 4,
                Title = "Grammar Quiz 2",
                Type = "Quiz",
                Score = 18.00m,
                MaxScore = 20.00m,
                CompletedAt = new DateTime(2025, 6, 1, 11, 0, 0),
                DueDate = new DateTime(2025, 6, 1, 12, 0, 0),
                IsCompleted = true,
                CreatedAt = new DateTime(2025, 5, 28, 13, 0, 0),
                UpdatedAt = new DateTime(2025, 6, 1, 11, 0, 0)
            },

            // Student 6 (Fatima Gamal) - Mathematics (SubjectId=1)
            new Assessment
            {
                Id = 9,
                StudentId = 6,
                SubjectId = 1,
                Title = "Basic Arithmetic Test",
                Type = "Test",
                Score = 70.00m,
                MaxScore = 100.00m,
                CompletedAt = new DateTime(2025, 6, 1, 15, 0, 0),
                DueDate = new DateTime(2025, 6, 1, 17, 0, 0),
                IsCompleted = true,
                CreatedAt = new DateTime(2025, 5, 15, 9, 0, 0),
                UpdatedAt = new DateTime(2025, 6, 1, 15, 0, 0)
            },

            // Student 7 (Karim Samir) - Science (SubjectId=2)
            new Assessment
            {
                Id = 10,
                StudentId = 7,
                SubjectId = 2,
                Title = "Ecosystems Project",
                Type = "Project",
                Score = 95.00m,
                MaxScore = 100.00m,
                CompletedAt = new DateTime(2025, 7, 8, 18, 0, 0),
                DueDate = new DateTime(2025, 7, 9, 23, 59, 59),
                IsCompleted = true,
                CreatedAt = new DateTime(2025, 6, 25, 11, 0, 0),
                UpdatedAt = new DateTime(2025, 7, 8, 18, 0, 0)
            },

            // Student 8 (Hania Tarek) - English Language (SubjectId=4)
            new Assessment
            {
                Id = 11,
                StudentId = 8,
                SubjectId = 4,
                Title = "Reading Comprehension Quiz",
                Type = "Quiz",
                Score = 10.00m,
                MaxScore = 20.00m,
                CompletedAt = new DateTime(2025, 7, 1, 10, 0, 0),
                DueDate = new DateTime(2025, 7, 1, 12, 0, 0),
                IsCompleted = true,
                CreatedAt = new DateTime(2025, 6, 28, 14, 0, 0),
                UpdatedAt = new DateTime(2025, 7, 1, 10, 0, 0)
            },

            // Student 9 (Ziad Ashraf) - Arabic Language (SubjectId=3)
            new Assessment
            {
                Id = 12,
                StudentId = 9,
                SubjectId = 3,
                Title = "Arabic Grammar Midterm",
                Type = "Test",
                Score = 75.00m,
                MaxScore = 100.00m,
                CompletedAt = new DateTime(2025, 6, 10, 13, 0, 0),
                DueDate = new DateTime(2025, 6, 10, 15, 0, 0),
                IsCompleted = true,
                CreatedAt = new DateTime(2025, 5, 20, 9, 0, 0),
                UpdatedAt = new DateTime(2025, 6, 10, 13, 0, 0)
            },

            // Student 10 (Salma Ehab) - History (SubjectId=5)
            new Assessment
            {
                Id = 13,
                StudentId = 10,
                SubjectId = 5,
                Title = "World War II Presentation",
                Type = "Project",
                Score = null,
                MaxScore = 100.00m,
                CompletedAt = null,
                DueDate = new DateTime(2025, 7, 25, 23, 59, 59),
                IsCompleted = false,
                CreatedAt = new DateTime(2025, 7, 5, 10, 0, 0),
                UpdatedAt = new DateTime(2025, 7, 5, 10, 0, 0)
            },

            // Student 12 (Nour Walid) - Mathematics (SubjectId=1)
            new Assessment
            {
                Id = 14,
                StudentId = 12,
                SubjectId = 1,
                Title = "Calculus Practice Set",
                Type = "Assignment",
                Score = 98.00m,
                MaxScore = 100.00m,
                CompletedAt = new DateTime(2025, 7, 11, 16, 0, 0),
                DueDate = new DateTime(2025, 7, 11, 23, 59, 59),
                IsCompleted = true,
                CreatedAt = new DateTime(2025, 7, 8, 9, 0, 0),
                UpdatedAt = new DateTime(2025, 7, 11, 16, 0, 0)
            },

            // Student 14 (Jana Hesham) - Arabic Language (SubjectId=3)
            new Assessment
            {
                Id = 15,
                StudentId = 14,
                SubjectId = 3,
                Title = "Poetry Analysis",
                Type = "Assignment",
                Score = 70.00m,
                MaxScore = 80.00m,
                CompletedAt = new DateTime(2025, 6, 28, 19, 0, 0),
                DueDate = new DateTime(2025, 6, 28, 23, 59, 59),
                IsCompleted = true,
                CreatedAt = new DateTime(2025, 6, 20, 10, 0, 0),
                UpdatedAt = new DateTime(2025, 6, 28, 19, 0, 0)
            },

            // Student 15 (Adam Medhat) - Science (SubjectId=2)
            new Assessment
            {
                Id = 16,
                StudentId = 15,
                SubjectId = 2,
                Title = "Biology Chapter Quiz",
                Type = "Quiz",
                Score = null,
                MaxScore = 25.00m,
                CompletedAt = null,
                DueDate = new DateTime(2025, 7, 12, 17, 0, 0),
                IsCompleted = false,
                CreatedAt = new DateTime(2025, 7, 9, 11, 0, 0),
                UpdatedAt = new DateTime(2025, 7, 9, 11, 0, 0)
            },

            // Student 16 (Mariam Fares) - History (SubjectId=5)
            new Assessment
            {
                Id = 17,
                StudentId = 16,
                SubjectId = 5,
                Title = "Ancient Civilizations Test",
                Type = "Test",
                Score = 95.00m,
                MaxScore = 100.00m,
                CompletedAt = new DateTime(2025, 5, 10, 14, 0, 0),
                DueDate = new DateTime(2025, 5, 10, 16, 0, 0),
                IsCompleted = true,
                CreatedAt = new DateTime(2025, 4, 25, 9, 0, 0),
                UpdatedAt = new DateTime(2025, 5, 10, 14, 0, 0)
            },

            // Student 19 (Mostafa Maher) - English Language (SubjectId=4)
            new Assessment
            {
                Id = 18,
                StudentId = 19,
                SubjectId = 4,
                Title = "Short Story Creative Writing",
                Type = "Project",
                Score = null,
                MaxScore = 75.00m,
                CompletedAt = null,
                DueDate = new DateTime(2025, 7, 5, 23, 59, 59), // Overdue
                IsCompleted = false,
                CreatedAt = new DateTime(2025, 6, 15, 10, 0, 0),
                UpdatedAt = new DateTime(2025, 6, 15, 10, 0, 0)
            }
        };
    }

    public static List<ActivityLog> GetActivityLogs()
    {
        return new List<ActivityLog>
        {
            // Student 3 (Omar Nabil) - Mathematics (SubjectId=1)
            new ActivityLog
            {
                Id = 1,
                StudentId = 3,
                SubjectId = 1,
                ActivityType = "Video Lecture",
                Description = "Watched 'Introduction to Algebra' video.",
                Duration = TimeSpan.FromMinutes(30),
                ActivityDate = new DateTime(2025, 7, 10, 9, 0, 0),
                CreatedAt = new DateTime(2025, 7, 10, 9, 0, 0)
            },
            new ActivityLog
            {
                Id = 2,
                StudentId = 3,
                SubjectId = 1,
                ActivityType = "Practice Problems",
                Description = "Completed practice set 1 for equations.",
                Duration = TimeSpan.FromHours(1),
                ActivityDate = new DateTime(2025, 7, 10, 10, 0, 0),
                CreatedAt = new DateTime(2025, 7, 10, 10, 0, 0)
            },
            new ActivityLog
            {
                Id = 3,
                StudentId = 3,
                SubjectId = 3, // Arabic Language
                ActivityType = "Reading",
                Description = "Read Chapter 3 of Arabic grammar textbook.",
                Duration = TimeSpan.FromMinutes(45),
                ActivityDate = new DateTime(2025, 7, 11, 11, 0, 0),
                CreatedAt = new DateTime(2025, 7, 11, 11, 0, 0)
            },

            // Student 4 (Laila Adel) - Science (SubjectId=2)
            new ActivityLog
            {
                Id = 4,
                StudentId = 4,
                SubjectId = 2,
                ActivityType = "Online Quiz",
                Description = "Attempted photosynthesis quiz.",
                Duration = TimeSpan.FromMinutes(20),
                ActivityDate = new DateTime(2025, 7, 9, 14, 0, 0),
                CreatedAt = new DateTime(2025, 7, 9, 14, 0, 0)
            },
            new ActivityLog
            {
                Id = 5,
                StudentId = 4,
                SubjectId = 2,
                ActivityType = "Virtual Lab",
                Description = "Simulated chemical reaction experiment.",
                Duration = TimeSpan.FromHours(1),
                ActivityDate = new DateTime(2025, 7, 11, 10, 0, 0),
                CreatedAt = new DateTime(2025, 7, 11, 10, 0, 0)
            },

            // Student 5 (Youssef Khaled) - English Language (SubjectId=4)
            new ActivityLog
            {
                Id = 6,
                StudentId = 5,
                SubjectId = 4,
                ActivityType = "Essay Writing",
                Description = "Drafted introductory paragraph for literature essay.",
                Duration = TimeSpan.FromHours(1).Add(TimeSpan.FromMinutes(15)),
                ActivityDate = new DateTime(2025, 7, 12, 13, 0, 0),
                CreatedAt = new DateTime(2025, 7, 12, 13, 0, 0)
            },
            new ActivityLog
            {
                Id = 7,
                StudentId = 5,
                SubjectId = 4,
                ActivityType = "Grammar Practice",
                Description = "Completed exercises on verb tenses.",
                Duration = TimeSpan.FromMinutes(30),
                ActivityDate = new DateTime(2025, 7, 11, 16, 0, 0),
                CreatedAt = new DateTime(2025, 7, 11, 16, 0, 0)
            },

            // Student 6 (Fatima Gamal) - Mathematics (SubjectId=1)
            new ActivityLog
            {
                Id = 8,
                StudentId = 6,
                SubjectId = 1,
                ActivityType = "Review Session",
                Description = "Attended online math review session.",
                Duration = TimeSpan.FromHours(1).Add(TimeSpan.FromMinutes(30)),
                ActivityDate = new DateTime(2025, 7, 10, 15, 0, 0),
                CreatedAt = new DateTime(2025, 7, 10, 15, 0, 0)
            },

            // Student 7 (Karim Samir) - Science (SubjectId=2)
            new ActivityLog
            {
                Id = 9,
                StudentId = 7,
                SubjectId = 2,
                ActivityType = "Research",
                Description = "Researched climate change impacts for project.",
                Duration = TimeSpan.FromHours(2),
                ActivityDate = new DateTime(2025, 7, 12, 10, 0, 0),
                CreatedAt = new DateTime(2025, 7, 12, 10, 0, 0)
            },

            // Student 9 (Ziad Ashraf) - Arabic Language (SubjectId=3)
            new ActivityLog
            {
                Id = 10,
                StudentId = 9,
                SubjectId = 3,
                ActivityType = "Vocabulary Practice",
                Description = "Learned new Arabic vocabulary words using flashcards.",
                Duration = TimeSpan.FromMinutes(25),
                ActivityDate = new DateTime(2025, 7, 11, 14, 0, 0),
                CreatedAt = new DateTime(2025, 7, 11, 14, 0, 0)
            },

            // Student 10 (Salma Ehab) - History (SubjectId=5)
            new ActivityLog
            {
                Id = 11,
                StudentId = 10,
                SubjectId = 5,
                ActivityType = "Documentary Watching",
                Description = "Watched documentary on ancient Egypt.",
                Duration = TimeSpan.FromHours(1).Add(TimeSpan.FromMinutes(45)),
                ActivityDate = new DateTime(2025, 7, 10, 18, 0, 0),
                CreatedAt = new DateTime(2025, 7, 10, 18, 0, 0)
            },
            new ActivityLog
            {
                Id = 12,
                StudentId = 10,
                SubjectId = 5,
                ActivityType = "Note Taking",
                Description = "Reviewed history notes from last week's lecture.",
                Duration = TimeSpan.FromMinutes(40),
                ActivityDate = new DateTime(2025, 7, 12, 9, 0, 0),
                CreatedAt = new DateTime(2025, 7, 12, 9, 0, 0)
            },

            // Student 12 (Nour Walid) - Mathematics (SubjectId=1)
            new ActivityLog
            {
                Id = 13,
                StudentId = 12,
                SubjectId = 1,
                ActivityType = "Problem Solving",
                Description = "Worked on advanced calculus problems.",
                Duration = TimeSpan.FromHours(1).Add(TimeSpan.FromMinutes(30)),
                ActivityDate = new DateTime(2025, 7, 12, 11, 0, 0),
                CreatedAt = new DateTime(2025, 7, 12, 11, 0, 0)
            },

            // Student 13 (Mohamed Sherif) - General Study (no specific subject)
            new ActivityLog
            {
                Id = 14,
                StudentId = 13,
                SubjectId = null, // No specific subject
                ActivityType = "Study Break",
                Description = "Took a short break from studying.",
                Duration = TimeSpan.FromMinutes(15),
                ActivityDate = new DateTime(2025, 7, 11, 17, 0, 0),
                CreatedAt = new DateTime(2025, 7, 11, 17, 0, 0)
            },

            // Student 14 (Jana Hesham) - Arabic Language (SubjectId=3)
            new ActivityLog
            {
                Id = 15,
                StudentId = 14,
                SubjectId = 3,
                ActivityType = "Creative Writing",
                Description = "Wrote a short story in Arabic.",
                Duration = TimeSpan.FromHours(1),
                ActivityDate = new DateTime(2025, 7, 12, 14, 0, 0),
                CreatedAt = new DateTime(2025, 7, 12, 14, 0, 0)
            },

            // Student 16 (Mariam Fares) - History (SubjectId=5)
            new ActivityLog
            {
                Id = 16,
                StudentId = 16,
                SubjectId = 5,
                ActivityType = "Reading",
                Description = "Read textbook on the Roman Empire.",
                Duration = TimeSpan.FromHours(1).Add(TimeSpan.FromMinutes(10)),
                ActivityDate = new DateTime(2025, 7, 11, 10, 0, 0),
                CreatedAt = new DateTime(2025, 7, 11, 10, 0, 0)
            }
        };
    }
}