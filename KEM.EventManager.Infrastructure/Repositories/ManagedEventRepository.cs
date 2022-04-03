using AutoMapper;
using KEM.EventManager.Domaine.Entities.Events;
using KEM.EventManager.Domaine.Repositories;
using KEM.EventManager.Infrastructure.Contexts;
using KEM.EventManager.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KEM.EventManager.Infrastructure.Repositories
{
    public  class ManagedEventRepository : BaseRepository, IManagedEventRepository
    {

        public ManagedEventRepository(
            IMapper mapper) : base(mapper)
        {
        }

        public Task AddAsync(ManagedEvent managedEvent)
        {
            ManagedEventContext.KumojinEvents.Add(managedEvent);
            return Task.CompletedTask;
        }

        public Task<List<ManagedEvent>> ListAsync()
        {
            Task<List<ManagedEvent>> listManagedEvent =  Task.FromResult(ManagedEventContext.KumojinEvents.ToList());
            return listManagedEvent;
        }

        public async Task<bool> DeleteAsync(ManagedEvent managedEvent)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagedEvent> FindWithPartialName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<ManagedEvent> GetAsync(long idManagedEvent)
        {
            ManagedEvent managedEvent = await Task.FromResult( ManagedEventContext.KumojinEvents.First(me => me.Id == idManagedEvent) );

            return managedEvent;
        }

        public async Task<ManagedEvent> UpdateAsync(ManagedEvent entity)
        {
            throw new NotImplementedException();
        }
    }
}
