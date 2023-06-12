using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTOs;
using WebApi.Models;
using WebApi.Services.Interface;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet("seed")]
        public async Task<IActionResult> Seed()
        {
            await _bookService.Seed();
            return Ok("Seed data successfully");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) => Ok(await _bookService.Get(id));
        [HttpGet]
        public async Task<IActionResult> Get(int pageIndex = 0, int pageSize = 10)
            => Ok(await _bookService.Get(pageIndex, pageSize));
        [HttpPost]
        public async Task<IActionResult> Add(BookDTO request) => Ok(await _bookService.Add(request));
        [HttpPut]
        public async Task<IActionResult> Update(Book request) => Ok(await _bookService.Update(request));
        [HttpDelete]
        public async Task<IActionResult> Delete(int id) => Ok(await _bookService.Delete(id));
    }
}