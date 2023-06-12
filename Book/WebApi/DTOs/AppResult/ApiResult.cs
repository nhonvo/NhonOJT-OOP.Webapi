using System.Net;

namespace WebApi.DTOs.AppResult
{
    public class ApiResult<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool Succeeded { get; set; }
        public string Message { get; set; } = string.Empty;
        public T ResultObject { get; set; }

    }
}