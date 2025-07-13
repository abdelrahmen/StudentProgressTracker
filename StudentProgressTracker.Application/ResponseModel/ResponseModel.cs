using StudentProgressTracker.Domain.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StudentProgressTracker.Application.ResponseModel;

public class ResponseModel<T>
{
    public bool Success { get; set; }
    public string? Message { get; set; }
    public T? Data { get; set; }
    public int Status { get; set; }



    public static ResponseModel<T> SuccessResponse(T data, string? message = null, HttpStatusCode? code = HttpStatusCode.OK)
    {
        return new ResponseModel<T>
        {
            Success = true,
            Message = message,
            Data = data,
            Status = (int)code,
        };
    }

    public static ResponseModel<T> Error(object? data = null, string? message = null, HttpStatusCode status = HttpStatusCode.InternalServerError)
    {
        return new ResponseModel<T>
        {
            Success = false,
            Message = message,
            Data = default
        };
    }
}

public class PaginatedResponseModel<T> : ResponseModel<T>
{
    public int? PageNumber { get; set; }
    public int? PageSize { get; set; }
    public int? TotalRecords { get; set; }

    public new static PaginatedResponseModel<T> SuccessResponse(T data, string? message = null, int? pageNumber = null, int? pageSize = null, int? totalRecords = null)
    {
        return new PaginatedResponseModel<T>
        {
            Success = true,
            Message = message,
            Data = data,
            PageNumber = pageNumber,
            PageSize = pageSize,
            TotalRecords = totalRecords,
            Status = (int)HttpStatusCode.OK,

        };
    }

}
