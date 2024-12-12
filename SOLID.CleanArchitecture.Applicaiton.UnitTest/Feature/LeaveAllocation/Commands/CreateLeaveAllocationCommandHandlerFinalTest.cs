using AutoMapper;
using Moq;
using Shouldly;
using SOLID.CleanArchitecture.Applicaiton.UnitTest.Mocks;
using SOLID.CleanArchitecture_.NET.Application.Contracts.Persistence;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Commands.CreateLeaveAllocation;
using SOLID.CleanArchitecture_.NET.Application.MappingProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CleanArchitecture.Applicaiton.UnitTest.Feature.LeaveAllocation.Commands
{
    public class CreateLeaveAllocationCommandHandlerFinalTest
    {
        private readonly Mock<ILeaveAllocationRepository> _mockLeaveAllocationRepo;
        private readonly Mock<ILeaveTypeRepository> _mockLeaveTypeRepo;
        private readonly IMapper _mapper;

        public CreateLeaveAllocationCommandHandlerFinalTest()
        {
            _mockLeaveAllocationRepo = MockLeaveAllocationCreate.GetLeaveAllocationRepo();
            _mockLeaveTypeRepo = MockLeaveTypeCreate.GetLeaveTypeRep();

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<LeaveAllocationProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task CreateLeaveAllocation_ValidCommand()
        {
            var handler = new CreateLeaveAllocationCommandHandler(_mapper, _mockLeaveAllocationRepo.Object, _mockLeaveTypeRepo.Object);
            var command = new CreateLeaveAllocationCommand { LeaveTypeId = 1 };
            await handler.Handle(command, CancellationToken.None);
            var allAllocations = await _mockLeaveAllocationRepo.Object.GetAsync();

            allAllocations.Count.ShouldBe(4);

        }
    }
}
