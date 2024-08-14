using Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class AuthenticationRepository : IAuthenticationRepository
    {
        bool IAuthenticationRepository.Authenticate(string email, string password) => true;
    }
}
