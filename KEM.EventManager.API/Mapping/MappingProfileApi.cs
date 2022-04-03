using AutoMapper;
using KEM.EventManager.API.Dto;
using KEM.EventManager.Domaine.Entities.Events;
using System.Diagnostics.CodeAnalysis;

namespace KEM.EventManager.API.Mapping
{

    [ExcludeFromCodeCoverage]
    public class MappingProfileApi : Profile
    {
        public MappingProfileApi()
        {
            CreateMap<ManagedEvent, ManagedEventResponseDto>();
        }
    }
    
}
