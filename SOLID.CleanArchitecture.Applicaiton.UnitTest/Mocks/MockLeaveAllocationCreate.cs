using Moq;
using SOLID.CleanArchitecture_.NET.Application.Contracts.Persistence;
using SOLID.CleanArchitecture_.NET.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CleanArchitecture.Applicaiton.UnitTest.Mocks
{
    public class MockLeaveAllocationCreate
    {
        public static Mock<ILeaveAllocationRepository> GetLeaveAllocationRepo()
        {
            var leaveAllocations = new List<LeaveAllocation>
            {
                new LeaveAllocation {Id = 1 , LeaveTypeId = 1},
                new LeaveAllocation {Id = 2 , LeaveTypeId = 2},
                new LeaveAllocation {Id = 3 , LeaveTypeId = 3}
            };

            var mockRepo = new Mock<ILeaveAllocationRepository>();

            mockRepo.Setup(x => x.GetAsync()).ReturnsAsync(leaveAllocations);


            mockRepo.Setup(x => x.CreateAsync(It.IsAny<LeaveAllocation>()))
                .Returns((LeaveAllocation leaveAllocation) =>
                {
                    leaveAllocations.Add(leaveAllocation);
                    return Task.CompletedTask;
                });

            return mockRepo;
        }
    }

    public class MockLeaveTypeCreate
    {
        public static Mock<ILeaveTypeRepository> GetLeaveTypeRep()
        {
            var leaveTypes = new List<LeaveType>
            {
                new LeaveType {Id = 1 , Name = "Sick"},
                new LeaveType {Id = 2 , Name = "Vaction"}
            };

            var mockRepo = new Mock<ILeaveTypeRepository>();

            mockRepo.Setup(x => x.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync((int id) => {

                    return leaveTypes.Find(x => x.Id == id);

                });

            return mockRepo;
        }
    }
}
