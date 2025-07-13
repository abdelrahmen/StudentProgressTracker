using StudentProgressTracker.Application.DTOs.Analytics;
using StudentProgressTracker.Application.DTOs.Analytics.RequestModels;
using StudentProgressTracker.Application.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.Abstractions.Analytics;

public interface IAnalyticsService
{
    Task<ResponseModel<List<ClassSummaryDto>>> GetClassSummaryAsync();
    Task<ResponseModel<List<ProgressTrendDto>>> GetProgressTrendsAsync(ProgressTrendsRequestDto request);
}
