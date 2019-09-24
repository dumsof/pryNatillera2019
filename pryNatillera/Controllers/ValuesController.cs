using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NatilleraApiAplicationContract.IServices;
using NatilleraApiBusinnes.Models;

namespace pryNatillera.Controllers
{
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

        // POST api/values
        [HttpPost]
        [ProducesResponseType(typeof(Natillera), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(Natillera), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(Natillera), (int)HttpStatusCode.InternalServerError)]
        public void Post([FromBody] Natillera natillera)
        {
            this.natilleraService.GuardarNatillera(natillera);
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
