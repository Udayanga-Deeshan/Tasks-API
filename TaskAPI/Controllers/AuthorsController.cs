﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services.Authors;
using TaskAPI.Services.Models;

namespace TaskAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _service;
        public AuthorsController(IAuthorRepository service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<ICollection<AuthorDto>> GetAuthors() {
            var authors = _service.GetAllAuthors();

            var authorsDto = new List<AuthorDto>();
            foreach (var author in authors) {
                authorsDto.Add(new AuthorDto
                { 
                    Id = author.Id,
                    FullName = author.FullName,
                    Address = $"{ author.AddressNo},{author.Street},{author.City}"
                }
                    );
             }
            return Ok(authorsDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id) {
            var author = _service.GetAuthor(id);

            if (author is null) {
                return NotFound();
            }
                return Ok(author);
        }

    }
}
