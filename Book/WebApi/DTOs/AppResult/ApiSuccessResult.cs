﻿using System.Net;

namespace WebApi.DTOs.AppResult
{
    public class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(T resultObject)
        {
            StatusCode = HttpStatusCode.OK;
            Succeeded = true;
            Message = "Success";
            ResultObject = resultObject;
        }
        public ApiSuccessResult()
        {
            Message = "Success";
            StatusCode = HttpStatusCode.OK;
            Succeeded = true;
        }
    }
}