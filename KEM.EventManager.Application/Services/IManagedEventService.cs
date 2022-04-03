using KEM.EventManager.Domaine.Entities.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.EventManager.Application.Services
{
    public interface IManagedEventService
    {
        Task<List<ManagedEvent>> GetAllManagedEvents();
        Task AddManagedEvent(ManagedEvent managedEvent);

    }
}
