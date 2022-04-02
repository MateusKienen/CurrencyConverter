using AutoMapper;

namespace CurrencyConverter.Logic.Mappers
{
    public class CurrencyTypeMapper : Profile
    {
        public CurrencyTypeMapper()
        {
            this.CreateMap<Data.Models.CurrencyType, Logic.Models.CurrencyType>()
                .ForMember(c => c.Name, c => c.MapFrom(c => c.Name))
                .ForMember(c => c.Acronym, c => c.MapFrom(c => c.Acronym));
        }
    }
}
