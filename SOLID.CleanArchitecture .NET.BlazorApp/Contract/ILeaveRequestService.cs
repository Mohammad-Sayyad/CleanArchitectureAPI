using SOLID.CleanArchitecture_.NET.BlazorApp.Models.LeaveRequest;
using SOLID.CleanArchitecture_.NET.BlazorApp.Services.Base;

namespace SOLID.CleanArchitecture_.NET.BlazorApp.Contract
{
    public interface ILeaveRequestService
    {
        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();
        Task<EmployeeLeaveRequestViewVM> GetUserLeaveRequests();
        Task<Response<Guid>> CreateLeaveRequest(LeaveRequestVM leaveRequest);
        Task<LeaveRequestVM> GetLeaveRequest(int id);
        Task DeleteLeaveRequest(int id);
        Task<Response<Guid>> ApproveLeaveRequest(int id, bool approved);
        Task<Response<Guid>> CancelLeaveRequest(int id);
    }
}
