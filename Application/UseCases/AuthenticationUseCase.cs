using Application.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases
{
    public class AuthenticationUseCase : IAuthenticationUseCase
    {
        public readonly IAuthenticationRepository _authenticationRepository;

        public AuthenticationUseCase(IAuthenticationRepository authenticationRepository)
        {
            _authenticationRepository = authenticationRepository;
        }

        public bool Authenticate(string email, string password)
        {
            return _authenticationRepository.Authenticate(email, password);
        }
    }
}
