using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PortfollioAdminPortal
{
    public class Employment : ServerEntity
    {
        public string employer { get; set; }
        public string job_title { get; set; }
        public string start_date {  get; set; }
        public string end_date { get; set; }

        public Employment(string id, string employer, string course, string startDate, string endDate) : base(id)
        {
            this.employer = employer;
            this.job_title = course;
            start_date = startDate;
            end_date = endDate;
        }

        public Employment() : base("-1")
        {

        }

        public override string GetJson()
        {
            return "{\"employer\":\"" + employer + "\",\"job_title\":\"" + job_title + "\",\"start_date\":\"" + start_date + "\",\"end_date\":\"" + end_date + "\"}";
        }
        

        public override string DisplayText => employer + " - " + job_title;

        public override string EndpointRoute => WebConfig.BACKEND_URL+"/employment/";
    }
}
