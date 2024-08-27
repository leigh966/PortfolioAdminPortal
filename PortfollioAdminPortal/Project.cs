using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PortfollioAdminPortal
{
    public class Project : ServerEntity, IServerEntity
    {
        public override string EndpointRoute { 
            get
            {
                return WebConfig.BACKEND_URL + "/projects/";
            } 
        }

        public Project() : base("-1")
        { }

        public Project(string id, string name, string description, string last_updated, string tagline, string? image_filename) : base(id)
        {
            this.name = name;
            this.description = description;
            this.last_updated = last_updated;
            this.tagline = tagline;
            this.image_filename = image_filename;
        }

        public override string DisplayText
        {
            get { return this.name; }
        }

        public string name { get; set; }
        public string description { get; set; }
        public string last_updated { get; set; }
        public string tagline { get; set; }
        public string? image_filename { get; set; }



    }
}
