using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Queries.GetLeaveAllocation
{
    public class GetLeaveAllocationListQuery : IRequest<List<LeaveAllocationDto>>
    {

    }
}
