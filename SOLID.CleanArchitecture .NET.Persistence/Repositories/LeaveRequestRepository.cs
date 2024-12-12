using Microsoft.EntityFrameworkCore;
using SOLID.CleanArchitecture_.NET.Application.Contracts.Persistence;
using SOLID.CleanArchitecture_.NET.Domain;
using SOLID.CleanArchitecture_.NET.Persistence.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CleanArchitecture_.NET.Persistence.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {

        public LeaveRequestRepository(MyDbContext context) : base(context)
        {
            
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetails()
        {
            var leaveRequests = await _context.LeaveRequests.Where(
                x => !string.IsNullOrEmpty(x.RequestingEmployeeId)).
                Include(x => x.LeaveTypeId).ToListAsync();
            return leaveRequests;
           
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetails(string userId)
        {
            var leaveRequests = await _context.LeaveRequests.Where(
                x => x.RequestingEmployeeId == userId).
                Include(x => x.LeaveType).ToListAsync();
            return leaveRequests;
        }

        public async Task<LeaveRequest> GetLeaveRequestWithDetails(int id)
        {
            var leaveRequest = await _context.LeaveRequests.Include
                (x => x.LeaveType).FirstOrDefaultAsync(
                x => x.Id == id);

            return leaveRequest;
        }
    }
}
