using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RecruitmentMasterApi.Models;

namespace RecruitmentMasterApi.Controllers
{
    public class employee_recruitController : ApiController
    {
        public IEnumerable<employee_recruit> GET()
        {
            using (employmentEntities entities = new employmentEntities())
            {
                return entities.employee_recruit.ToList();
            }
        }

        public employee_recruit GET(string id)
        {
            using (employmentEntities entities = new employmentEntities())
            {
                return entities.employee_recruit.FirstOrDefault(e => e.Id == id);
            }
        }
        
        public employee_recruit InsertRecruit(string id)
        {
            using (employmentEntities entities = new employmentEntities())
            {
                return entities.employee_recruit.FirstOrDefault(e => e.Id == id);
            }
        }
    }
}
