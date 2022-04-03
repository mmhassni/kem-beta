using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Commun.Configurations
{
    internal class CorsSetting
    {
        public string AllowedOrigin { get; set; } = string.Empty;
        public string AllowHeaders { get; set; } = string.Empty;
        public string AllowMethods { get; set; } = string.Empty;
        public bool AllowCredentials { get; set; }
    }
}
