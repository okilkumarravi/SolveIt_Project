using SolveIt.Dao;
using SolveIt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolveIt.Service
{
    public interface IAuthenticationService
    {
        bool CreateUser(CreateUser createUser);
        void LoginUser(LoginUser loginUser);
        UserModel BaseLogin(LoginUser loginUser);
    }
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthenticationDao _authenticationDao;
        public AuthenticationService(IAuthenticationDao authenticationDao)
        {
            _authenticationDao = authenticationDao;
        }

        public UserModel BaseLogin(LoginUser loginUser)
        {
            return _authenticationDao.LoginUser(loginUser);
        }

        public bool CreateUser(CreateUser createUser)
        {
            try
            {
                if (string.IsNullOrEmpty(createUser.Name)
                    || string.IsNullOrEmpty(createUser.MobileNumber)
                    || string.IsNullOrEmpty(createUser.Class))
                {
                    return false;
                }

                return _authenticationDao.CreateUser(createUser);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public void LoginUser(LoginUser loginUser)
        {
             _authenticationDao.LoginUser(loginUser);
        }
    }
}
