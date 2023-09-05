using CoastalVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace CoastalVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}
