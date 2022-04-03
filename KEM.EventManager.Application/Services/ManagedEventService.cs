using KEM.EventManager.Domaine.Entities.Events;
using KEM.EventManager.Domaine.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.EventManager.Application.Services
{
    public class ManagedEventService : IManagedEventService
    {

        private readonly IManagedEventRepository _managedEventRepository;

        public ManagedEventService(IManagedEventRepository managedEventRepository)
        {
            _managedEventRepository = managedEventRepository;
        }
        public async Task AddManagedEvent(ManagedEvent managedEvent)
        {
            await _managedEventRepository.AddAsync(managedEvent);
        }

        public Task<List<ManagedEvent>> GetAllManagedEvents()
        {
            
            return  _managedEventRepository.ListAsync();
        }

    }
}
