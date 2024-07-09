using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfollioAdminPortal
{
    public partial class AlterProject : Form
    {
        bool valuesProvided;
        HttpClient client;
        string sessionId;
        Project? project = null;

        public AlterProject(string sessionId, HttpClient client)
        {
            this.sessionId = sessionId;
            this.client = client;
            InitializeComponent();
        }

        public AlterProject(string sessionId, HttpClient client, Project thisProject) 
        {
            project = thisProject;
            this.sessionId = sessionId;
            this.client = client;
            InitializeComponent();
            txtName.Text = project.name;
            txtDescription.Text = project.description;
        }

        string? id = null;
        public AlterProject(string sessionId, HttpClient client, Project project) : this(sessionId, client)
        {
            txtName.Text = project.name;
            txtTagline.Text = project.tagline;
            txtDescription.Text = project.description;
            id = project.id;
        }

        private async void UpdateProject()
        {
            string json = $"{{\"name\":\"{txtName.Text}\",\"description\":\"{txtDescription.Text}\",\"tagline\":\"{txtTagline.Text}\"}}";
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Put, WebConfig.BACKEND_URL + "/project/"+id))
            {
                requestMessage.Headers.Add("session_id", sessionId);
                requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.SendAsync(requestMessage);
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != System.Net.HttpStatusCode.Created)
                {
                    MessageBox.Show(responseString, response.StatusCode.ToString(), MessageBoxButtons.OK);
                    return;
                }
            }

            Close();
        }

        private async void AddProject()
        {
            string json = $"{{\"name\":\"{txtName.Text}\",\"description\":\"{txtDescription.Text}\",\"tagline\":\"{txtTagline.Text}\"}}";
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, WebConfig.BACKEND_URL+"/project"))
            {
                requestMessage.Headers.Add("session_id", sessionId);
                requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.SendAsync(requestMessage);
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != System.Net.HttpStatusCode.Created)
                {
                    MessageBox.Show(responseString, response.StatusCode.ToString(), MessageBoxButtons.OK);
                    return;
                }
            }

            Close();
        }

        private async void UpdateProject()
        {
            string json = "{\"name\":\"" + txtName.Text + "\",\"description\":\"" + txtDescription.Text + "\"}";
            using (var requestMessage =
new HttpRequestMessage(HttpMethod.Put, "http://127.0.0.1:3000/project/"+project.id))
            {
                requestMessage.Headers.Add("session_id", sessionId);
                requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.SendAsync(requestMessage);
                //var response = await client.PostAsync("http://127.0.0.1:3000/project", content);
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(responseString, response.StatusCode.ToString(), MessageBoxButtons.OK);
                    return;
                }
            }

            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(project != null)
            {
                return;
            }
            if(id != null)
            {
                UpdateProject();
                return;
            }
            AddProject();
        }
    }
}
