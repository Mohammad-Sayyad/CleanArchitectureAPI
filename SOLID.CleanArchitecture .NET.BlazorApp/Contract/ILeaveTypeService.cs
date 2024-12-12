using SOLID.CleanArchitecture_.NET.BlazorApp.Models.LeaveType;
using SOLID.CleanArchitecture_.NET.BlazorApp.Services.Base;

namespace SOLID.CleanArchitecture_.NET.BlazorApp.Contract
{
     public interface ILeaveTypeService
    {
        Task<List<LeaveTypeVM>> GetLeaveTypes();
        Task<LeaveTypeVM> GetLeaveTypeDetails(int id);
        Task<Response<Guid>> CreateLeaveType(LeaveTypeVM leaveType);
        Task<Response<Guid>> UpdateLeaveType(int id, LeaveTypeVM leaveType);
        Task<Response<Guid>> DeleteLeaveType(int id);
    }
}
