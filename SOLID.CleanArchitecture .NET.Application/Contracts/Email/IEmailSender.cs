using SOLID.CleanArchitecture_.NET.Application.Model.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CleanArchitecture_.NET.Application.Contracts.Email
{
    
    public interface IEmailSender
    {
        Task<bool> SendEmail(EmailMessage email);
    }
}
