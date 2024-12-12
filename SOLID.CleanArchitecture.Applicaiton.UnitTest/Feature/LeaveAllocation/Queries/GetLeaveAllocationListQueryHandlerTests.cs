using AutoMapper;
using Moq;
using Shouldly;
using SOLID.CleanArchitecture.Applicaiton.UnitTest.Mocks;
using SOLID.CleanArchitecture_.NET.Application.Contracts.Persistence;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Queries;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveAllocation.Queries.GetLeaveAllocation;
using SOLID.CleanArchitecture_.NET.Application.MappingProfiles;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace SOLID.CleanArchitecture.Applicaiton.UnitTest.Feature.LeaveAllocation.Queries
{
    public class GetLeaveAllocationListQueryHandlerTests
    {
        private readonly Mock<ILeaveAllocationRepository> _mockRepo;
        private IMapper _mapper;

        public GetLeaveAllocationListQueryHandlerTests()
        {
            _mockRepo = MockLeaveAllocationRepository.GetMockLeaveAllocationRepository();

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<LeaveAllocationProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task GetLeaveAllocationListTest()
        {
            var handler = new GetLeaveAllocationListHandler(_mockRepo.Object, _mapper);

            var result = await handler.Handle(new GetLeaveAllocationListQuery(), CancellationToken.None);

            // Assert the result is of the expected type and count
            result.ShouldBeOfType<List<LeaveAllocationDto>>();
            result.Count.ShouldBe(4);
        }
    }
}