using System.Text.Json;

namespace PortfollioAdminPortal
{
    public partial class Main : Form
    {
        private readonly HttpClient client;
        private string sessionId;

        public Main(string sessionId, HttpClient client)
        {
            this.sessionId = sessionId;
            this.client = client;
            InitializeComponent();
        }
        private List<Project>? projects = null;
        private async void requestProjects()
        {
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, WebConfig.BACKEND_URL + "/projects"))
            {
                requestMessage.Headers.Add("session_id", sessionId);
                var response = await client.SendAsync(requestMessage);
                string jsonText = await response.Content.ReadAsStringAsync();
                lstProj.Items.Clear();
                projects = JsonSerializer.Deserialize<List<Project>>(jsonText);
                foreach (Project p in projects)
                {
                    lstProj.Items.Add(p.name);
                }

            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            requestProjects();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form mainForm = new AlterProject(sessionId, client);
            Hide();
            mainForm.ShowDialog();
            requestProjects();
            Show();
        }

        private async void DeleteProject()
        {
            string url = WebConfig.BACKEND_URL + "/project/" + projects[lstProj.SelectedIndex].id;
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Delete, url))
            {
                requestMessage.Headers.Add("session_id", sessionId);
                var response = await client.SendAsync(requestMessage);
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != System.Net.HttpStatusCode.NoContent)
                {
                    MessageBox.Show(responseString, response.StatusCode.ToString(), MessageBoxButtons.OK);
                    return;
                }
                projects.RemoveAt(lstProj.SelectedIndex);
                lstProj.Items.RemoveAt(lstProj.SelectedIndex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstProj.SelectedIndex == -1) return;

            DeleteProject();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstProj.SelectedIndex == -1) return;

            Form mainForm = new AlterProject(sessionId, client, projects[lstProj.SelectedIndex]);
            Hide();
            mainForm.ShowDialog();
            requestProjects();
            Show();
        }
    }
}
