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
    public partial class MainMenu : Form
    {
        string sessionId;
        HttpClient client;
        public MainMenu(string sessionId, HttpClient client)
        {
            InitializeComponent();
            this.sessionId = sessionId;
            this.client = client;
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            Form newForm = new ProjectsMenu(sessionId, client);
            newForm.ShowDialog();
        }

        private void btnEducation_Click(object sender, EventArgs e)
        {
            Form newForm = new EducationMenu(sessionId, client);
            newForm.ShowDialog();
        }
    }
}
