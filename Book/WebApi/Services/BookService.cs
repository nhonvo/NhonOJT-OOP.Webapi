using Application.Commons;
using AutoMapper;
using WebApi.DTOs.AppResult;
using WebApi.DTOs;
using WebApi.Models;
using WebApi.Services.Interface;
using System.Text.Json;

namespace WebApi.Services
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BookService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ApiResult<Pagination<Book>>> Get(int pageIndex, int pageSize)
        {
            var result = await _unitOfWork.BookRepository.ToPagination(pageIndex, pageSize);
            return new ApiSuccessResult<Pagination<Book>>(result);
        }
        public async Task<ApiResult<Book>> Get(int id)
        {
            var result = await _unitOfWork.BookRepository.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null)
                return new ApiErrorResult<Book>("Book not found");
            return new ApiSuccessResult<Book>(result);
        }
        public async Task<ApiResult<int>> Add(BookDTO request)
        {
            var book = _mapper.Map<Book>(request);
            await _unitOfWork.ExecuteTransactionAsync(async () =>
            {
                await _unitOfWork.BookRepository.AddAsync(book);
            });
            return new ApiSuccessResult<int>(book.Id);
        }
        public async Task<ApiResult<BookDTO>> Update(Book request)
        {
            var book = await _unitOfWork.BookRepository.FirstOrDefaultAsync(x => x.Id == request.Id);
            book = _mapper.Map<Book>(request);
            await _unitOfWork.ExecuteTransactionAsync(() =>
            {
                _unitOfWork.BookRepository.Update(book);
            });
            var result = _mapper.Map<BookDTO>(book);
            return new ApiSuccessResult<BookDTO>(result);
        }
        public async Task<ApiResult<int>> Delete(int id)
        {
            var book = await _unitOfWork.BookRepository.FirstOrDefaultAsync(x => x.Id == id);
            await _unitOfWork.ExecuteTransactionAsync(() =>
            {
                _unitOfWork.BookRepository.Delete(book);
            });
            return new ApiSuccessResult<int>(book.Id);
        }
        public async Task Seed()
        {
            if (!await _unitOfWork.BookRepository.AnyAsync())
            {
                string json = File.ReadAllText(@".\Json\book.json");
                List<Book> books = JsonSerializer.Deserialize<List<Book>>(json)!;
                await _unitOfWork.ExecuteTransactionAsync(() =>
                {
                    _unitOfWork.BookRepository.AddRangeAsync(books);
                });
            };
        }
    }
}