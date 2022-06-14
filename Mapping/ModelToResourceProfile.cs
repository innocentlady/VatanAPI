using AutoMapper;
using VatanAPI.Domain.Models;
using VatanAPI.Resources;

namespace VatanAPI.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>();
        }
    }
}
