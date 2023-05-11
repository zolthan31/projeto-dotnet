using AutoMapper;
using MultiMarcas.ProductAPI.Data.ValueObjects;
using MultiMarcas.ProductAPI.Model;

namespace MultiMarcas.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });
            return mappingConfig;

        }
    }
}
