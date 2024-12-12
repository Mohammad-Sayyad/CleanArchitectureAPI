using SOLID.CleanArchitecture_.NET.Application.Features.LeaveType.Queires.GetLeaveTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Queries.GetLeaveAllocationDetails
{
    public class LeaveAllocationDetailsDto
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }
        public LeaveTypeDto LeaveTypeDto {get; set;}
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }

}
