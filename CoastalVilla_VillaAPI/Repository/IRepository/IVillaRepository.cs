using CoastalVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace CoastalVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
