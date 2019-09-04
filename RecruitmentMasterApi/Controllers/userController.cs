using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RecruitmentMasterApi.Models;

namespace RecruitmentMasterApi.Controllers
{
    public class userController : ApiController
    {
        public IEnumerable<user> GET()
        {
            using (employmentEntities entities = new employmentEntities())
            {
                return entities.users.ToList();
            }
        }

        public user GET(string Id)
        {
            using (employmentEntities entities = new employmentEntities())
            {
                return entities.users.FirstOrDefault(e => e.id == Id);
            }
        }
    }
}
