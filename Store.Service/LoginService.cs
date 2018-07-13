using Store.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Store.Data.Repositories.LoginRepository;

namespace Store.Service
{
    public interface ILoginService
    {

        bool Check(string User, string Password);
    }


    public class LoginService : ILoginService
    {
        private readonly ILoginRepository loginRepository;
        private readonly IUnitOfWork unitOfWork;

        public LoginService(ILoginRepository loginRepository, IUnitOfWork unitOfWork)
        {
            this.loginRepository = loginRepository;
            this.unitOfWork = unitOfWork;
        }
        public bool Check(string User, string Password)
        {
            return loginRepository.Check(User, Password);
        }
    }
}
