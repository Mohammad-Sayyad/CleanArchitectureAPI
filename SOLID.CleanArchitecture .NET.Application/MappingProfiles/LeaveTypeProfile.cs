using AutoMapper;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveType.Commands.CreateLeaveType;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveType.Commands.UpdateLeaveType;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveType.Queires.GetLeaveTypes;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveType.Queires.GetLeaveTypesDetails;
using SOLID.CleanArchitecture_.NET.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CleanArchitecture_.NET.Application.MappingProfiles
{
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile()
        {
            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
            CreateMap<LeaveType, LeaveTypesDetailsDto>();
            CreateMap<CreateLeaveTypeCommand, LeaveType>();
            CreateMap<UpdateLeaveTypeCommand, LeaveType>();
        }
        
    }
}
