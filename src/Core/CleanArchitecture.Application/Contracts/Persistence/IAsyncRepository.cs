using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T: BaseDomainModel
    {
         
    }
}