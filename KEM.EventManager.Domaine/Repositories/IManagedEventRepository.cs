using KEM.EventManager.Domaine.Entities.Events;
using KEM.EventManager.Domaine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.EventManager.Domaine.Repositories
{
    public interface IManagedEventRepository //: IAsyncRepository<ManagedEvent>
    {
        Task<ManagedEvent> FindWithPartialName(string name);
        public Task<List<ManagedEvent>> ListAsync();
        public Task AddAsync(ManagedEvent managedEvent);
    }
}
