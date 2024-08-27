using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfollioAdminPortal
{
    public interface IServerEntity
    {
        string DisplayText { get; }
        public string EndpointRoute { get; }
        public string id { get; set; }

        public string GetJson();
    }
}
