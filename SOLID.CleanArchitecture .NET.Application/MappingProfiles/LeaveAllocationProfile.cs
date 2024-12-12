using AutoMapper;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Commands.CreateLeaveAllocation;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Commands.UpdateLeaveAllocation;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Queries.GetLeaveAllocation;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Queries.GetLeaveAllocationDetails;
using SOLID.CleanArchitecture_.NET.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CleanArchitecture_.NET.Application.MappingProfiles
{
    public class LeaveAllocationProfile : Profile
    {
        public LeaveAllocationProfile()
        {
            CreateMap<LeaveAllocationDto, LeaveAllocation>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDetailsDto>();
            CreateMap<CreateLeaveAllocationCommand, LeaveAllocation>();
            CreateMap<UpdateLeaveAllocationCommand, LeaveAllocation>();
        }
    }
}
