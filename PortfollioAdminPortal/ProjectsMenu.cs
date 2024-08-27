using System.Diagnostics.Eventing.Reader;
using System.Text.Json;

namespace PortfollioAdminPortal
{
    public partial class ProjectsMenu : EntitiesMenu<Project>
    {
       public ProjectsMenu(string sessionId, HttpClient client): base(sessionId, client) { }

        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            
                if (lstEntities.SelectedIndex == -1) return;
                Project selectedRecord = records[lstEntities.SelectedIndex];
                Form mainForm = new AlterProject(sessionId, client, selectedRecord);
                Hide();
                mainForm.ShowDialog();
                requestRecords();
                Show();
            
        }
    }
}
