using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc_web_apijl.Models;

namespace mvc_web_apijl.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    public class ValuesController : Controller
    {        
        // GET api/values
        [HttpGet]        
        public List<PocPersonalData> Get()
        {
            //return new string[] { "value1", "value2" };
            //var optionsBuilder = new DbContextOptionsBuilder<mremhContext>();
            //optionsBuilder.UseNpgsql("User ID=mremh_sgpj;Password=sgpjwww;Server=10.10.8.9;Port=5432;Database=mremh;Integrated Security=true;Pooling=true;");
            
            using(var context = new mremhContext())
            {
                // Retorna toda la información de personal.
                var personal = from b in context.PocPersonalData
                            select b; 
                return personal.ToList(); 
            }                                                     
        }

        // GET api/values/5
        [HttpGet("{id}")]        
        public string Get(int id)
        {
            return "Otro valor cualquiera de Get" + id;
        }
        //Método de pruebas
        // POST api/values
        [HttpPost]
        public List<PocPersonalData> Post([FromBody]string value)
        {
            using(var context = new mremhContext())
            {
                // Retorna toda la información de personal.
                var personal = from b in context.PocPersonalData
                            select b; 
                return personal.ToList(); 
            } 
        }

        // POST api/values/5
        [HttpPost]
        public string Post(int id, [FromBody]string value)
        {
            return "Otro valor cualquiera de Post" + id; 
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
