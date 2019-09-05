using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RecruitmentMasterApi.Models;

namespace RecruitmentMasterApi.Controllers
{
    public class employeeController : ApiController
    {
        public IEnumerable<employee_recruit> GetEmployees()
        {
            using (employmentEntities entities = new employmentEntities())
            {
                return entities.employee_recruit.ToList();
            }
        }

        public employee_recruit GetEmployee(string id)
        {
            using (employmentEntities entities = new employmentEntities())
            {
                return entities.employee_recruit.FirstOrDefault(e => e.Id == id);
            }
        }

        public int PostEmployee(employee_manager emp)
        {
            return new executor().PostEmployee(emp);
        }

        public int PutEmployee(employee_manager emp, string _id)
        {
            return new executor().PutEmployee(emp,_id);
        }

        public int DeleteEmployee(string _id)
        {
            return new executor().DeleteEmployee(_id);
        }

        public int DeleteAllEmployee()
        {
            int v = GetEmployees().Count();
            int x = 0;
            foreach (var _e in GetEmployees())
            {
                new executor().DeleteUser(_e.Id);
                x = x + 1;
            }
            if (x != v)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
