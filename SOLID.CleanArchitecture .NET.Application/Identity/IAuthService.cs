using SOLID.CleanArchitecture_.NET.Application.Model.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CleanArchitecture_.NET.Application.Identity
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(AuthRequest requset);
        Task<RegisterationResponse> Register(RegistrationRequest requset);

    }
}
