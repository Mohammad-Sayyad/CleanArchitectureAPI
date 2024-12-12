using Moq;
using SOLID.CleanArchitecture_.NET.Application.Contracts.Persistence;
using SOLID.CleanArchitecture_.NET.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SOLID.CleanArchitecture.Applicaiton.UnitTest.Mocks
{
    public static class MockLeaveAllocationRepository
    {
        public static Mock<ILeaveAllocationRepository> GetMockLeaveAllocationRepository()
        {
            var leaveAllocations = new List<LeaveAllocation>
            {
                new LeaveAllocation
                {
                    Id = 1,
                    NumberOfDays = 10,
                    EmployeeId = "Employee1",
                    LeaveTypeId = 1,
                    Period = 2024
                },
                new LeaveAllocation
                {
                    Id = 2,
                    NumberOfDays = 12,
                    EmployeeId = "Employee2",
                    LeaveTypeId = 2,
                    Period = 2024
                },
                new LeaveAllocation
                {
                    Id = 3,
                    NumberOfDays = 15,
                    EmployeeId = "Employee3",
                    LeaveTypeId = 1,
                    Period = 2024
                },
                new LeaveAllocation
                {
                    Id = 4,
                    NumberOfDays = 5,
                    EmployeeId = "Employee4",
                    
                    LeaveTypeId = 3,
                    Period = 2025
                }
            };

            var mockRepo = new Mock<ILeaveAllocationRepository>();

            // Mock the method to return a list of LeaveAllocations
            mockRepo.Setup(x => x.GetLeaveAllocationsWithDetails()).ReturnsAsync(leaveAllocations);

            // Mock method to add new leave allocations
            mockRepo.Setup(x => x.AddAllocations(It.IsAny<List<LeaveAllocation>>()))
                .Returns(Task.CompletedTask);

            return mockRepo;
        }
    }
}

