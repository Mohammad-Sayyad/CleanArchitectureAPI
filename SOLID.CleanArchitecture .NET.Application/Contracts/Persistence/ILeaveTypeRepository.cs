using SOLID.CleanArchitecture_.NET.Domain;

namespace SOLID.CleanArchitecture_.NET.Application.Contracts.Persistence
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
        Task<bool> IsLeaveTypeUnique(string name);
    }
}
