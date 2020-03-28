using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Demo5.JsonAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET: api/Values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Values/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Values
        [HttpPost]
        public void Post([FromBody] JObject value)
        {
            dynamic customer = value;

            string first = customer.firstName;
            string second = customer.secondName;
        }

    }
}


/* comentar
 * 
 * Aca lo que podemos ver es que tenemos un metodo de una api que recibe un objeto d
 * desde el body que es del tipo JObject, este es de la libreria de newtonsoft
 * Al declararlo de esta forma podemos usar dinamic que quie en tiempo de ejecución tranforme directamente
 * el objeto que pueda ser usado desde el lado de c#
 * una vez que lo haga podemos accederlo por el nombre de sus propiedades sin problema
 */