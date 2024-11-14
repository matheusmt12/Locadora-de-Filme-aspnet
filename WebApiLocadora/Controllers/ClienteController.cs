using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApiLocadora.DTO;
using WebApiLocadora.Models;
using WebApiLocadora.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiLocadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly ClienteService _clienteService;
        private readonly IMapper _mapeer;

        public ClienteController(ClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapeer = mapper;
        }

        // GET: api/<ClienteController>
        [HttpGet("ativo/{active}")]
        public ActionResult<ClienteDTO> Get(bool active = true)
        {
            return Ok(_clienteService.GetAll(active));
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                return Ok(_clienteService.Get(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<ClienteController>
        [HttpPost]
        public ActionResult Post([FromBody] ClienteDTO cliente)
        {
            try
            {

                Cliente c = _mapeer.Map<Cliente>(cliente);
                _clienteService.Create(c);
                return Ok(c);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                return Ok(_clienteService.Delete(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
