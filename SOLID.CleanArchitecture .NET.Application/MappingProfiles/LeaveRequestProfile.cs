using AutoMapper;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveRequest.Commands.CreateLeaveRequest;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveRequest.Commands.UpdateLeaveRequest;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveRequest.Queries.GetLeaveRequestDetail;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveRequest.Queries.GetLeaveRequestList;
using SOLID.CleanArchitecture_.NET.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CleanArchitecture_.NET.Application.MappingProfiles
{
    public class LeaveRequestProfile : Profile
    {
        public LeaveRequestProfile()
        {
            CreateMap<LeaveRequestListDto, LeaveRequest>().ReverseMap();
            CreateMap<LeaveRequestDetailsDto, LeaveRequest>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestDetailsDto>();
            CreateMap<CreateLeaveRequestCommand, LeaveRequest>();
            CreateMap<UpdateLeaveRequestCommand, LeaveRequest>();
        }
    }
}