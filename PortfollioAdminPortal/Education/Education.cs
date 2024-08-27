using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PortfollioAdminPortal
{
    public class Education : ServerEntity
    {
        public string school { get; set; }
        public string course { get; set; }
        public string start_date {  get; set; }
        public string end_date { get; set; }

        public Education(string id, string school, string course, string startDate, string endDate) : base(id)
        {
            this.school = school;
            this.course = course;
            start_date = startDate;
            end_date = endDate;
        }

        public Education() : base("-1")
        {

        }

        public override string GetJson()
        {
            return "{\"school\":\"" + school + "\",\"course\":\"" + course + "\",\"start_date\":\"" + start_date + "\",\"end_date\":\"" + end_date + "\"}";
        }
        

        public override string DisplayText => school + " - " + course;

        public override string EndpointRoute => WebConfig.BACKEND_URL+"/education/";
    }
}
