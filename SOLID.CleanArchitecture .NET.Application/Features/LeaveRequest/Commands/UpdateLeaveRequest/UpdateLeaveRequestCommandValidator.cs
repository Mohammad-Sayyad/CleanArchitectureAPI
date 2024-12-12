using FluentValidation;
using SOLID.CleanArchitecture_.NET.Application.Contracts.Persistence;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveRequest.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CleanArchitecture_.NET.Application.Features.LeaveRequest.Commands.UpdateLeaveRequest
{
    public class UpdateLeaveRequestCommandValidator : AbstractValidator<UpdateLeaveRequestCommand>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly ILeaveRequestRepository _leaveRequestRepository;

        public UpdateLeaveRequestCommandValidator(ILeaveTypeRepository leaveTypeRepository
            , ILeaveRequestRepository leaveRequestRepository)
        {
            this._leaveTypeRepository = leaveTypeRepository;
            this._leaveRequestRepository = leaveRequestRepository;
            Include(new BaseLeaveRequestValidator(_leaveTypeRepository));


        }
    }
}
