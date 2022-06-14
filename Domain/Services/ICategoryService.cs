using VatanAPI.Domain.Models;
using VatanAPI.Domain.Services.Communication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VatanAPI.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
