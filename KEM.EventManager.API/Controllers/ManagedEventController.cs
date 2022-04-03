using AutoMapper;
using KEM.EventManager.API.Dto;
using KEM.EventManager.Application.Services;
using KEM.EventManager.Domaine.Entities.Events;
using Microsoft.AspNetCore.Mvc;

namespace KEM.EventManager.API.Controllers
{
    [ApiController]
    [Route("api/v1/Event")]
    public class ManagedEventController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly ILogger<ManagedEventController> _logger;
        private readonly IManagedEventService _managedEventService;

        public ManagedEventController(
            IMapper mapper,
            ILogger<ManagedEventController> logger,
            IManagedEventService managedEventService)
        {
            _mapper = mapper;
            _logger = logger;
            _managedEventService = managedEventService;
        }

        [HttpGet("List/All")]
        public async Task<ActionResult> ListAll()
        {
            var managedEvents = await _managedEventService.GetAllManagedEvents();
            var managedEventsReponse = _mapper.Map<List<ManagedEvent>, List<ManagedEventResponseDto>>(managedEvents);
            return Ok(managedEventsReponse);
        }


        [HttpPost("[action]")]
        public async Task<ActionResult> Schedule(ManagedEventScheduleRequestDto managedEventSchedule)
        {
            var managedEvent = _mapper.Map<ManagedEventScheduleRequestDto, ManagedEvent>(managedEventSchedule);
            await _managedEventService.AddManagedEvent(managedEvent);
            return Ok();
        }

    }
}