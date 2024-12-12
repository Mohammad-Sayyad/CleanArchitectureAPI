using MediatR;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveRequest.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CleanArchitecture_.NET.Application.Features.LeaveRequest.Commands.CreateLeaveRequest
{
    public class CreateLeaveRequestCommand : BaseLeaveRequest , IRequest<Unit> 
    {
        public string RequestComments { get; set; } = string.Empty;
    }
}
