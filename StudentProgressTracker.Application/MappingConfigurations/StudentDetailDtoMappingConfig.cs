using Mapster;
using StudentProgressTracker.Application.DTOs.ActivityLogs;
using StudentProgressTracker.Application.DTOs.Assessments;
using StudentProgressTracker.Application.DTOs.Students;
using StudentProgressTracker.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.MappingConfigurations;

public class StudentDetailDtoMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        // User ➜ StudentDetailDto
        config.NewConfig<User, StudentDetailDto>()
            .Map(dest => dest.Grade, src => src.Grade.HasValue ? src.Grade.ToString() : string.Empty)
            .Map(dest => dest.OverallCompletionPercentage,
                 src => src.StudentProgress.Any() ? src.StudentProgress.Average(sp => sp.CompletionPercentage) : (decimal?)null)
            .Map(dest => dest.OverallPerformanceScore,
                 src => src.StudentProgress.Any() ? src.StudentProgress.Average(sp => sp.PerformanceScore) : (decimal?)null)
            .Map(dest => dest.SubjectProgresses, src => src.StudentProgress)
            .Map(dest => dest.Assessments, src => src.StudentAssessments)
            .Map(dest => dest.ActivityLogs, src => src.ActivityLogs);

        // StudentProgress ➜ StudentSubjectProgressDto
        config.NewConfig<StudentProgress, StudentSubjectProgressDto>()
            .Map(dest => dest.SubjectName, src => src.Subject != null ? src.Subject.Name : "N/A")
            .Map(dest => dest.ProgressStatus, src => src.ProgressStatus);

        // Assessment ➜ AssessmentDto
        config.NewConfig<Assessment, AssessmentDto>()
            .Map(dest => dest.SubjectName, src => src.Subject != null ? src.Subject.Name : "N/A")
            .Map(dest => dest.PercentageScore, src => src.PercentageScore)
            .Map(dest => dest.IsOverdue, src => src.IsOverdue);

        // ActivityLog ➜ ActivityLogDto
        config.NewConfig<ActivityLog, ActivityLogDto>()
            .Map(dest => dest.SubjectName, src => src.Subject != null ? src.Subject.Name : null);
    }
}


