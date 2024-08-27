using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfollioAdminPortal
{
    public abstract class ServerEntity : IServerEntity
    {
        public string id { get; set; }
        public abstract string DisplayText { get; }

        public abstract string EndpointRoute { get; }

        public abstract string GetJson();

        public ServerEntity(string id)
        {
            this.id = id;
        }

    }
}
