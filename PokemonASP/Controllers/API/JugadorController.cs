using BLASP;
using ENT;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PokemonASP.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class JugadorController : ControllerBase
    {
        // GET: api/<JugadorController>
        [HttpGet]
        public IActionResult Get()
        {
            IActionResult salida;
            List<clsJugador> listadoCompletoJugadores;

            try
            {
                listadoCompletoJugadores = clsListadosJugadorBL.ObtenerListadoJugadoresBL();

                if (listadoCompletoJugadores.Count() == 0)
                {
                    salida = NoContent(); // 204 
                }
                else
                {
                    salida = Ok(listadoCompletoJugadores); // 200
                }
            }
            catch (Exception ex)
            {
                salida = BadRequest(); // 500
            }
            return salida;
        }

        //// GET api/<JugadorController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<JugadorController>
        [HttpPost]
        public IActionResult Post([FromBody] clsJugador jugador)
        {
            IActionResult salida;
            int numFilasAfectadas = 0;

            try
            {
                numFilasAfectadas = clsManejadoraJugadorBL.CrearJugadorBL(jugador);

                if (numFilasAfectadas == 0)
                {
                    salida = NotFound();
                }
                else
                {
                    salida = Ok(jugador);
                }
            }
            catch (Exception ex)
            {
                salida = BadRequest();
            }

            return salida;
        }

        //// PUT api/<JugadorController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<JugadorController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
