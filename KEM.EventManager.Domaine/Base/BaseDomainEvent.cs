﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.EventManager.Domaine.Base
{
    public abstract class BaseDomainEvent : INotification
    {
        public BaseDomainEvent()
        {
            EventId = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;
        }

        public virtual Guid EventId { get; init; }
        public virtual DateTime CreatedOn { get; init; }
    }
}
