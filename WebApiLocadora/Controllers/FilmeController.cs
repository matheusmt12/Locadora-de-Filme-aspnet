using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiLocadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        // GET: api/<FilmeController>
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok();
        }

        // GET api/<FilmeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FilmeController>
        [HttpPost]
        public ActionResult Post([FromBody] string value)
        {
            try
            {
                return Ok();
            }
            catch (Exception ex) { return BadRequest(); }
        }

        // PUT api/<FilmeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FilmeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
