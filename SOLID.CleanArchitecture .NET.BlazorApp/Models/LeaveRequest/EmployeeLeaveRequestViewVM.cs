using SOLID.CleanArchitecture_.NET.Domain;

namespace SOLID.CleanArchitecture_.NET.BlazorApp.Models.LeaveRequest
{
    public class EmployeeLeaveRequestViewVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; } = new List<LeaveAllocationVM>();
        public List<LeaveRequestVM> LeaveRequests { get; set; } = new List<LeaveRequestVM>();
    }
}
