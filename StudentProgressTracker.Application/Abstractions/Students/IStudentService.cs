using StudentProgressTracker.Application.DTOs.Students;
using StudentProgressTracker.Application.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.Abstractions.Students;

public interface IStudentService
{
    Task<PaginatedResponseModel<List<StudentListDto>>> GetStudentsAsync(StudentFilterDto filter);
    Task<ResponseModel<StudentDetailDto>> GetStudentByIdAsync(int studentId);
    Task<ResponseModel<List<StudentSubjectProgressDto>>> GetStudentProgressMetricsAsync(int studentId);
    Task<ResponseModel<StudentSubjectProgressDto>> UpdateStudentProgressAsync(int studentId, StudentProgressUpdateDto updateDto);
}
