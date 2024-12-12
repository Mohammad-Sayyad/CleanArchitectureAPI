using Microsoft.AspNetCore.Components;
using SOLID.CleanArchitecture_.NET.BlazorApp.Contract;
using SOLID.CleanArchitecture_.NET.BlazorApp.Models.LeaveRequest;
using SOLID.CleanArchitecture_.NET.BlazorApp.Models.LeaveType;

namespace SOLID.CleanArchitecture_.NET.BlazorApp.Pages.LeaveRequest
{
    public partial class Create
    {
        [Inject] ILeaveTypeService leaveTypeService { get; set; }
        [Inject] ILeaveRequestService leaveRequestService { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }
        LeaveRequestVM LeaveRequest { get; set; } = new LeaveRequestVM();
        List<LeaveTypeVM> leaveTypeVMs { get; set; } = new List<LeaveTypeVM>();

        protected override async Task OnInitializedAsync()
        {
            leaveTypeVMs = await leaveTypeService.GetLeaveTypes();
        }

        private async Task HandleValidSubmit()
        {
            // Perform form submission here
            await leaveRequestService.CreateLeaveRequest(LeaveRequest);
            NavigationManager.NavigateTo("/leaverequests/");
        }
    }
}