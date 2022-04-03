using KEM.EventManager.Domaine.Base;
using KEM.EventManager.Domaine.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.EventManager.Domaine.Entities.Events
{
    public partial class ManagedEvent : BaseEntity<long>
    {
        internal ManagedEvent(ManagedEventBuilder builder)
        {
            Id = builder.Id;
            Name = builder.Name;
            Description = builder.Description;
            StartTime = builder.StartTime;
            FinishTime = builder.FinishTime;
        }

        public long Id { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime StartTime { get; }
        public DateTime FinishTime { get; }
    }
}
