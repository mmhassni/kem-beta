using AutoMapper;
using KEM.EventManager.Domaine.Builders;
using KEM.EventManager.Domaine.Entities.Events;
using KEM.EventManager.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.EventManager.Infrastructure.Mappage
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<ManagedEvent, ManagedEventDto>();
            CreateMap<ManagedEventDto, ManagedEvent>().ConstructUsing(dto => new ManagedEventBuilder()
                                                    .WithId(dto.Id)
                                                    .WithName(dto.Name)
                                                    .WithDescription(dto.Description)
                                                    .WithStartTime(dto.StartTime)
                                                    .WithFinishTime(dto.FinishTime)
                                                    .Build());
        }
    }
}
