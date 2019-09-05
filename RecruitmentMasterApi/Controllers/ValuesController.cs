using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using RecruitmentMasterApi.Models;

namespace RecruitmentMasterApi.Controllers
{
    public class ValuesController : ApiController
    {
        /*// GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }*/
        /*public int del(string id, string action)
        {
            using (employmentEntities entities = new employmentEntities())
            {
                if (action == "employee")
                {
                    return entities.employee_recruit_delete(id);
                }
                else if (action == "user")
                {
                    return entities.user_delete(id);
                }
                else
                {
                    return 0;
                }
            }
        }*/
    }
}
