using VatanAPI.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VatanAPI.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
