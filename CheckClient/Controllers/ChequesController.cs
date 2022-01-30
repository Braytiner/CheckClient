using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheckClient.Controllers
{
    [Route("api/cheques")]
    [ApiController]
    public class ChequesController : ControllerBase
    {
        // GET: api/<ChequesController>
        [HttpGet(Name = "ListarTodosCheques")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("{cpf}", Name = "ListarPorCliente")]
        public IEnumerable<string> Get(string cpf)
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ChequesController>/5
        [HttpGet("{id}", Name = "ListarChequePorId")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ChequesController>
        [HttpPost(Name = "AdicionarCheque")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ChequesController>/5
        [HttpPut("{id}", Name = "AlterarCheque")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ChequesController>/5
        [HttpDelete("{id}", Name = "ApagarCheque")]
        public void Delete(int id)
        {
        }
    }
}
