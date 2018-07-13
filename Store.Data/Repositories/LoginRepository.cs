using Store.Data.Infrastructure;
using Store.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Store.Data.Repositories.LoginRepository;

namespace Store.Data.Repositories
{
    public class LoginRepository : RepositoryBase<Login>, ILoginRepository
    {
        public LoginRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public bool Check(string User,string Password)
        {
            var check = this.DbContext.Login.Where(c => c.Username == User && c.Password == Password).FirstOrDefault();
            if (check != null)
                return true;
            else
                return false;
        }


        public interface ILoginRepository : IRepository<Login>
        {
             bool Check(string User, string Password);
        }
    }
}
