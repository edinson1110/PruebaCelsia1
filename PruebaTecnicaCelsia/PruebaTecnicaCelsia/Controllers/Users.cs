using PruebaTecnicaCelsia.Models;
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
    public class UsersController : ApiController
    {
        // GET api/values
        public Response Get(string user, string password)
        {
            
            User data = new User();
            Response res = new Response();
            Guid token = Guid.Empty;
            try
            {
                using (PruebaTecnicaEntities db = new PruebaTecnicaEntities())
                {
                    data = db.User.Where(p => p.USERNAME == user && p.PASSWORD == password).FirstOrDefault();
                    if (data.ID != null) { 
                        token = data.ID;
                    }

                    res.Result = data;
                    res.Info = token.ToString();

                    //Actualiza el token el usuario una vez generado
                }
            }
            catch (Exception e)
            {
                res.Result = data;
                res.Info = e.Message.ToString();
            }

            return res;
            
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
