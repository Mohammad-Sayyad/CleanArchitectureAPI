using SOLID.CleanArchitecture_.NET.BlazorApp.Models.LeaveType;
using SOLID.CleanArchitecture_.NET.BlazorApp.Services.Base;

namespace SOLID.CleanArchitecture_.NET.BlazorApp.Contract
{
    public interface ILeaveAllocationService
    {
        Task<Response<Guid>> CreateLeaveAllocations(int leaveTypeId);
    }
}
