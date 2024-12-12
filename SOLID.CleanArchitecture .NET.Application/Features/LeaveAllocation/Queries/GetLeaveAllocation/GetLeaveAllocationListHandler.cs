using AutoMapper;
using MediatR;
using SOLID.CleanArchitecture_.NET.Application.Contracts.Logging;
using SOLID.CleanArchitecture_.NET.Application.Contracts.Persistence;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Queries.GetLeaveAllocation;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveType.Queires.GetLeaveTypes;


namespace SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Queries
{
    public class GetLeaveAllocationListHandler : IRequestHandler<GetLeaveAllocationListQuery, List<LeaveAllocationDto>>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;
        //private readonly IAppLogger<GetLeaveAllocationListHandler> _logger;

        public GetLeaveAllocationListHandler(ILeaveAllocationRepository leaveAllocationRepository,
             IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
            //_logger = logger;
        }

        public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListQuery request, CancellationToken cancellationToken)
        {
            //will add employees

            var leaveAllocations = await _leaveAllocationRepository.GetLeaveAllocationsWithDetails();
            var allocations = _mapper.Map<List<LeaveAllocationDto>>(leaveAllocations);
          //  _logger.LogInformation("Leave Allocation were retrieved successfully");
            return allocations;
        }


    }
}
