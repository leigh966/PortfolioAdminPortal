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
        public string School { get; set; }
        public string Course { get; set; }
        public string StartDate {  get; set; }
        public string EndDate { get; set; }

        public Education(string id, string school, string course, string startDate, string endDate) : base(id)
        {
            School = school;
            Course = course;
            StartDate = startDate;
            EndDate = endDate;
        }

        public Education() : base("-1")
        {

        }

        public override string DisplayText => School + " - " + Course;

        public override string EndpointRoute => WebConfig.BACKEND_URL+"/education/";
    }
}
