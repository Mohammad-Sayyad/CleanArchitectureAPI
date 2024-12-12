using AutoMapper;
using MediatR;
using Moq;
using Shouldly;
using SOLID.CleanArchitecture.Applicaiton.UnitTest.Mocks;
using SOLID.CleanArchitecture_.NET.Application.Contracts.Persistence;
using SOLID.CleanArchitecture_.NET.Application.Exceptions;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Commands.CreateLeaveAllocation;
using SOLID.CleanArchitecture_.NET.Application.MappingProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.CleanArchitecture.Applicaiton.UnitTest.Feature.LeaveAllocation.Commands
{
    public class CreateLeaveAllocationCommandHandlerTests
    {
        private readonly Mock<ILeaveAllocationRepository> _mockLeaveAllocationRepository;
        private readonly Mock<ILeaveTypeRepository> _mockLeaveTypeRepository;
        private IMapper _mapper;

        public CreateLeaveAllocationCommandHandlerTests()
        {
            _mockLeaveAllocationRepository = new Mock<ILeaveAllocationRepository>();
            _mockLeaveTypeRepository = new Mock<ILeaveTypeRepository>();

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<LeaveAllocationProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task CreateLeaveAllocation_ValidCommand_ShouldSucceed()
        {
            // Arrange
            var leaveTypeId = 1;

            var command = new CreateLeaveAllocationCommand
            {
                LeaveTypeId = leaveTypeId
            };

            _mockLeaveTypeRepository.Setup(x => x.GetByIdAsync(leaveTypeId)).ReturnsAsync(new SOLID.CleanArchitecture_.NET.Domain.LeaveType
            {
                Id = leaveTypeId,
                Name = "Annual Leave",
                DefaultDays = 10
            });

            var handler = new CreateLeaveAllocationCommandHandler(_mapper, _mockLeaveAllocationRepository.Object, _mockLeaveTypeRepository.Object);

            // Act
            var result = await handler.Handle(command, CancellationToken.None);

            // Assert
            result.ShouldBe(Unit.Value);
            _mockLeaveAllocationRepository.Verify(x => x.CreateAsync(It.IsAny<SOLID.CleanArchitecture_.NET.Domain.LeaveAllocation>()), Times.Once);
        }

        [Fact]
        public async Task CreateLeaveAllocation_InvalidCommand_ShouldThrowException()
        {
            // Arrange
            var command = new CreateLeaveAllocationCommand
            {
                LeaveTypeId = 0 // Invalid LeaveTypeId
            };

            var handler = new CreateLeaveAllocationCommandHandler(_mapper, _mockLeaveAllocationRepository.Object, _mockLeaveTypeRepository.Object);

            // Act & Assert
            await Should.ThrowAsync<BadRequestExceptions>(() => handler.Handle(command, CancellationToken.None));
            _mockLeaveAllocationRepository.Verify(x => x.CreateAsync(It.IsAny<SOLID.CleanArchitecture_.NET.Domain.LeaveAllocation>()), Times.Never);
        }
    }
}
