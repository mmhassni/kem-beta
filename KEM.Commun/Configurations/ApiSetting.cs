using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KEM.Commun.Configurations
{
    public class ApiSetting
    {
        public string Alias { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Scheme { get; set; } = string.Empty;
        public string ApiName { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
    }
}
