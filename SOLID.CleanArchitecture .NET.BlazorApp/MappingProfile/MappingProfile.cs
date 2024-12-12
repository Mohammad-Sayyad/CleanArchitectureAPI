

using AutoMapper;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Commands.CreateLeaveAllocation;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Commands.UpdateLeaveAllocation;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Queries.GetLeaveAllocation;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Queries.GetLeaveAllocationDetails;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveRequest.Commands.CreateLeaveRequest;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveRequest.Commands.UpdateLeaveRequest;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveRequest.Queries.GetLeaveRequestDetail;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveRequest.Queries.GetLeaveRequestList;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveType.Commands.CreateLeaveType;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveType.Commands.UpdateLeaveType;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveType.Queires.GetLeaveTypes;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveType.Queires.GetLeaveTypesDetails;
using SOLID.CleanArchitecture_.NET.Application.Model.Identity;
using SOLID.CleanArchitecture_.NET.BlazorApp.Models;
using SOLID.CleanArchitecture_.NET.BlazorApp.Models.LeaveRequest;
using SOLID.CleanArchitecture_.NET.BlazorApp.Models.LeaveType;

namespace SOLID.CleanArchitecture_.NET.BlazorApp.MappingProfile
{
    public class MappingProfile : Profile
    {
        public class MappingConfig : Profile
        {
            public MappingConfig()
            {
                CreateMap<LeaveTypeDto, LeaveTypeVM>().ReverseMap();
                CreateMap<LeaveTypesDetailsDto, LeaveTypeVM>().ReverseMap();
                CreateMap<CreateLeaveTypeCommand, LeaveTypeVM>().ReverseMap();
                CreateMap<UpdateLeaveTypeCommand, LeaveTypeVM>().ReverseMap();

                CreateMap<LeaveRequestListDto, LeaveRequestVM>()
                    .ForMember(q => q.DateRequested, opt => opt.MapFrom(x => x.DateRequested.Date)).ForMember(q => q.StartDate, opt => opt.MapFrom(x => x.StartDate.Date)).ForMember(q => q.EndDate, opt => opt.MapFrom(x => x.EndDate.Date))
                    .ReverseMap();
                CreateMap<LeaveRequestDetailsDto, LeaveRequestVM>()
                    .ForMember(q => q.DateRequested, opt => opt.MapFrom(x => x.DateRequested.Date)).ForMember(q => q.StartDate, opt => opt.MapFrom(x => x.StartDate.Date)).ForMember(q => q.EndDate, opt => opt.MapFrom(x => x.EndDate.Date))
                    .ReverseMap();
                CreateMap<CreateLeaveRequestCommand, LeaveRequestVM>().ReverseMap();
                CreateMap<UpdateLeaveRequestCommand, LeaveRequestVM>().ReverseMap();

                CreateMap<LeaveAllocationDto, LeaveAllocationVM>().ReverseMap();
                CreateMap<LeaveAllocationDetailsDto, LeaveAllocationVM>().ReverseMap();
                CreateMap<CreateLeaveAllocationCommand, LeaveAllocationVM>().ReverseMap();
                CreateMap<UpdateLeaveAllocationCommand, LeaveAllocationVM>().ReverseMap();

                CreateMap<EmployeeVM, Employee>().ReverseMap();

            }
        }
    }

}
