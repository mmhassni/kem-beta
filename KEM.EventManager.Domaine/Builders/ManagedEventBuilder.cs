using KEM.EventManager.Domaine.Entities.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.EventManager.Domaine.Builders
{
    public class ManagedEventBuilder
    {
        public long Id { get; private set; }
        public DateTime StartTime { get; private set; }
        public DateTime FinishTime { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;

        public ManagedEvent Build() => new ManagedEvent(this);

        public ManagedEventBuilder WithId(long id)
        {
            Id = id;
            return this;
        }

        public ManagedEventBuilder WithName(string name)
        {
            Name = name;
            return this;
        }

        public ManagedEventBuilder WithDescription(string description)
        {
            Description = description;
            return this;
        }

        public ManagedEventBuilder WithStartTime(DateTime startTime)
        {
            StartTime = startTime;
            return this;
        }

        public ManagedEventBuilder WithFinishTime(DateTime finishTime)
        {
            FinishTime = finishTime;
            return this;
        }

    }
}
