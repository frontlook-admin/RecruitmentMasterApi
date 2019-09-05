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
        public IEnumerable<user> GetUsers()
        {
            using (employmentEntities entities = new employmentEntities())
            {
                return entities.users.ToList();
            }
        }

        public user GetUser(string _Id)
        {
            using (employmentEntities entities = new employmentEntities())
            {
                return entities.users.FirstOrDefault(e => e.id == _Id);
            }
        }

        public int PostUser(user_manager _u)
        {
            return new executor().PostUser(_u);
        }

        public int PutUser(user_manager _u, string _id)
        {
            /*using (employmentEntities entities = new employmentEntities())
            {
                return entities.PutUser
                (
                    usr
                );
            }*/
            return new executor().PutUser(_u,_id);
        }

        public int DeleteUser(string _id)
        {
           return new executor().DeleteUser(_id);
        }

        public int DeleteAllUser()
        {
            int v = GetUsers().Count();
            int x = 0;
            foreach (var _u in GetUsers())
            {
                new executor().DeleteUser(_u.id);
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
