using AutoMapper;
using Moq;
using Shouldly;
using SOLID.CleanArchitecture.Applicaiton.UnitTest.Mocks;
using SOLID.CleanArchitecture_.NET.Application.Contracts.Logging;
using SOLID.CleanArchitecture_.NET.Application.Contracts.Persistence;
using SOLID.CleanArchitecture_.NET.Application.Features.LeaveType.Queires.GetLeaveTypes;
using SOLID.CleanArchitecture_.NET.Application.MappingProfiles;

namespace SOLID.CleanArchitecture.Applicaiton.UnitTest.Feature.LeaveType.Quries
{
    public class GetLeaveTypeListQueryHandlerTests
    {
        private readonly Mock<ILeaveTypeRepository> _mockRepo;
        private IMapper _mapper;
        private Mock<IAppLogger<GetLeaveTypesQueryHandler>> _mockAppLogger;

        public GetLeaveTypeListQueryHandlerTests()
        {
            _mockRepo = MockLeaveTypeRepository.GetMockLeaveTypeRepository();

            var mapperConfig = new MapperConfiguration(c =>
            {
                c.AddProfile<LeaveTypeProfile>();
            });

            _mapper = mapperConfig.CreateMapper();
            _mockAppLogger = new Mock<IAppLogger<GetLeaveTypesQueryHandler>>();
        }
        [Fact]
        public async Task GetLeaveTypeListTest()
        {
            var handler = new GetLeaveTypesQueryHandler(_mapper, _mockRepo.Object, _mockAppLogger.Object);

            var result = await handler.Handle(new GetLeaveTypesQuery(),
                CancellationToken.None);

            //Assert

            result.ShouldBeOfType<List<LeaveTypeDto>>();
            result.Count.ShouldBe(4);
        }
    }
}
