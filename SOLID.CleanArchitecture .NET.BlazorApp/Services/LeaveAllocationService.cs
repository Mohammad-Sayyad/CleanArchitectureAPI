using Blazored.LocalStorage;
using SOLID.CleanArchitecture_.NET.BlazorApp.Contract;
using SOLID.CleanArchitecture_.NET.BlazorApp.Models.LeaveType;
using SOLID.CleanArchitecture_.NET.BlazorApp.Services.Base;

namespace SOLID.CleanArchitecture_.NET.BlazorApp.Services
{
    public class LeaveAllocationService : BaseHttpService, ILeaveAllocationService
    {
        public LeaveAllocationService(IClient client , ILocalStorageService localStorageService) : base(client , localStorageService)
        {
            
        }

        

        public async Task<Response<Guid>> CreateLeaveAllocations(int leaveTypeId)
        {
            try
            {
                var response = new Response<Guid>();
                CreateLeaveAllocationCommand createLeaveAllocationCommand = new()
                {
                    LeaveTypeId = leaveTypeId
                };

                await _client.LeaveAllocationsPOSTAsync(createLeaveAllocationCommand);

                return response;

            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<Guid>(ex);
            }
        }
    }
}
