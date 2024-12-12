using Microsoft.EntityFrameworkCore;
using Shouldly;
using SOLID.CleanArchitecture_.NET.Domain;
using SOLID.CleanArchitecture_.NET.Persistence.DBContext;

namespace SOLID.CleanArchitecture.Persistence.IntegrationTests
{
    public class MyDbContextTests
    {
        private MyDbContext _myDbContext;

        public MyDbContextTests()
        {
            var dbOptions = new DbContextOptionsBuilder<MyDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            _myDbContext = new MyDbContext(dbOptions);
        }
        [Fact]
        public async void Save_SetDateCreatedValue()
        {
            // Arrange
            var leaveType = new LeaveType
            {
                Id = 1,
                DefaultDays = 10,
                Name = "Test Vacation"
            };

            // Act
            await _myDbContext.LeaveTypes.AddAsync(leaveType);
            await _myDbContext.SaveChangesAsync();

            // Assert
            leaveType.DateCreated.ShouldNotBe(default(DateTime)); // Check that DateCreated is set
        }
        [Fact]
        public async void Save_SetDateModifiedValue()
        {
            // Arrange
            var leaveType = new LeaveType
            {
                Id = 1,
                DefaultDays = 10,
                Name = "Test Vacation"
            };

            // Act
            await _myDbContext.LeaveTypes.AddAsync(leaveType);
            await _myDbContext.SaveChangesAsync();

            // Assert
            leaveType.DateModified.ShouldNotBe(default(DateTime)); // Check that DateCreated is set
        }

    }
}