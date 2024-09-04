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
    public partial class EmploymentMenu : EntitiesMenu<Employment>
    {
        public EmploymentMenu(string sessionId, HttpClient client) : base(sessionId, client) { }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            AddEntity(new AlterEmployment(sessionId, client));
        }

        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            
            if (lstEntities.SelectedIndex == -1) return;
            Employment selectedRecord = records[lstEntities.SelectedIndex];
            Form mainForm = new AlterEmployment(sessionId, client, selectedRecord);
            Hide();
            mainForm.ShowDialog();
            requestRecords();
            Show();
        }
    }
}
