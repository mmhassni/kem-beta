using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.EventManager.Infrastructure.Dto
{
    internal class ManagedEventDto
    {
        public long Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime StartTime { get; set; }

        public DateTime FinishTime { get; set; }

    }
}
