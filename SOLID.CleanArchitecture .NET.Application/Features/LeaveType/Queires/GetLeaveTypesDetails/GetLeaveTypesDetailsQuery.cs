using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CleanArchitecture_.NET.Application.Features.LeaveType.Queires.GetLeaveTypesDetails
{
    public record GetLeaveTypesDetailsQuery(int Id) : IRequest<LeaveTypesDetailsDto>;
}
