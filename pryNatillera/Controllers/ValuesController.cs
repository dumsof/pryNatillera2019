namespace pryNatillera.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using NatilleraApiAplicationContract.IServices;
    using NatilleraApiAplicationContract.Models;
    using NatilleraApiBusinnes.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly INatilleraServices natilleraService;
        public ValuesController(INatilleraServices natilleraService)
        {
            this.natilleraService = natilleraService;
        }
        /// <summary>
        /// Obtener todos los valores.
        /// </summary>
        /// <returns>The <see cref="IEnumerable{Pais}"/></returns>
        /// <response code="200">Operación realizada con éxito.</response>
        /// <response code="404">No existen datos para la consulta realizada.</response>
        /// <response code="500">Error inesperado.</response>
        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        // [ProducesResponseType(typeof(RespuestaPais), (int)HttpStatusCode.InternalServerError)]
        public ActionResult<IEnumerable<string>> Get()
        {
            throw new Exception("Exception while fetching all the students from the storage.");
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Guardar los datos de una natillera.
        /// </summary>
        /// <param name="natillera"></param>
        /// <response code="200">Operación realizada con éxito.</response>
        /// <response code="404">No existen datos para la consulta realizada.</response>
        /// <response code="500">Error inesperado.</response>
        [HttpPost]
        [ProducesResponseType(typeof(Respuesta), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(Natillera), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(Natillera), (int)HttpStatusCode.InternalServerError)]
        public void GuardarNatillera([FromBody] Natillera natillera)
        {
            Respuesta respuesta = this.natilleraService.GuardarNatillera(natillera);
            Ok(respuesta);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
