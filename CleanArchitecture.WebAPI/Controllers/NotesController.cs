using CleanArchitecture.Application.CQRS.Commands;
using CleanArchitecture.Application.CQRS.Queries;
using CleanArchitecture.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NotesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<NotesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NotesResult>>> GetNotes()
        {
            var query = new NotesRequest();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        // GET api/<NotesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<NotesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateNoteRequest request)
        {
            await _mediator.Send(request);
            return Ok("esto es un post");
        }

        // PUT api/<NotesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NotesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
