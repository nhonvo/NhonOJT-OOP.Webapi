using Application.Commons;
using WebApi.DTOs.AppResult;
using WebApi.DTOs;
using WebApi.Models;

namespace WebApi.Services.Interface
{
    public interface IBookService
    {
        Task<ApiResult<Pagination<Book>>> Get(int pageIndex, int pageSize);
        Task<ApiResult<Book>> Get(int id);
        Task<ApiResult<int>> Add(BookDTO request);
        Task<ApiResult<BookDTO>> Update(Book request);
        Task<ApiResult<int>> Delete(int id);
        Task Seed();
    }
}