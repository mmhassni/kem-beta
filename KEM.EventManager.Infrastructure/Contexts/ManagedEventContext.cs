using KEM.EventManager.Domaine.Builders;
using KEM.EventManager.Domaine.Entities.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.EventManager.Infrastructure.Contexts
{
    public class ManagedEventContext
    {
        public ManagedEventContext()
        {
        }

        public static ICollection<ManagedEvent> KumojinEvents = new List<ManagedEvent>
        {
            new ManagedEventBuilder()
                .WithId(1)
                .WithName("Event Test")
                .WithDescription("Test Description")
                .WithStartTime(new DateTime())
                .WithFinishTime(new DateTime().AddDays(5))
                .Build()
        };
    }
}
