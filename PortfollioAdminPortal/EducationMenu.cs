using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfollioAdminPortal
{
    public partial class EducationMenu : EntitiesMenu<Education>
    {
        public EducationMenu(string sessionId, HttpClient client) : base(sessionId, client) { }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
