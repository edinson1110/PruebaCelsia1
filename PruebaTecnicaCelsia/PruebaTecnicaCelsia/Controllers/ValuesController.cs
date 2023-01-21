using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PruebaTecnicaCelsia.Controllers
{
    [EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<INFO> Get(string dateIni, string dateFin)
        {

            using (PruebaTecnicaEntities db = new PruebaTecnicaEntities()) {
                INFO data = new INFO();
                DateTime dateInicio = Convert.ToDateTime(dateIni);
                DateTime dateFinal = Convert.ToDateTime(dateFin);
                return db.INFO.ToList().Where(p => DateTime.Parse(p.timestamp) >= dateInicio && DateTime.Parse(p.timestamp) <= dateFinal);
                //return db.INFO.ToList();
            }
            
        }


        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
