using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
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

        private async void requestProjects()
        {
            using (var requestMessage =
new HttpRequestMessage(HttpMethod.Get, "http://127.0.0.1:3000/projects"))
            {
                requestMessage.Headers.Add("session_id", sessionId);
                var response = await client.SendAsync(requestMessage);
                string jsonText = await response.Content.ReadAsStringAsync();

                List<Project>? projects = JsonSerializer.Deserialize<List<Project>>(jsonText);
                foreach(Project p in projects)
                {
                    lstProj.Items.Add(p.name);
                }

            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            requestProjects();

        }
    }
}
