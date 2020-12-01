using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using resume.generator.Domain.Interfaces;

namespace resume.generator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TDto> : Controller
        where TDto : class
    {
        private readonly IRepository<TDto> _repository;

        public BaseController(IRepository<TDto> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> FetchAll()
        {
            var results = await _repository.FetchMany();
            return Ok(results);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> FetchOne(string id)
        {
            var result = await _repository.FetchOne(id);
            if (result == null) return NotFound(id);

            return Ok(result);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateOne([FromBody] TDto dto)
        {
            var result = await _repository.CreateOne(dto);
            return Created("", result);
        }

        [HttpPatch("{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateOne(string id, [FromBody] TDto dto)
        {
            var result = await _repository.UpdateOne(id, dto);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOne(string id)
        {
            await _repository.DeleteOne(id);
            return Ok();
        }
    }
}