using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfollioAdminPortal
{
    public partial class AlterProject : Form
    {
        HttpClient client;
        string sessionId;
        string? imagePath = null, aws_filename = null;
        public AlterProject(string sessionId, HttpClient client)
        {
            this.sessionId = sessionId;
            this.client = client;
            InitializeComponent();
        }

        string? id = null;
        public AlterProject(string sessionId, HttpClient client, Project project) : this(sessionId, client)
        {
            txtName.Text = project.name;
            txtTagline.Text = project.tagline;
            txtDescription.Text = project.description;
            id = project.id;
            if(project.image_filename != null)
            {
                pbBanner.ImageLocation = WebConfig.BACKEND_URL + "/image/"+ project.image_filename;
            }
            aws_filename = project.image_filename;
        }

        public string GetJson()
        {
            
            return $"{{\"name\":\"{txtName.Text}\",\"description\":\"{txtDescription.Text}\",\"tagline\":\"{txtTagline.Text}\",\"image_filename\":\"{aws_filename}\"}}";
        }

        private async void UpdateProject()
        {
            string json = GetJson();
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Put, WebConfig.BACKEND_URL + "/project/" + id))
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

            string json = GetJson();
                using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, WebConfig.BACKEND_URL + "/project"))
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

        

        private async void HandleSubmit()
        {
            if (imagePath != null)
            {
                aws_filename = await UploadImage();
            }
            if (id != null)
            {
                UpdateProject();
                return;
            }
            AddProject();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            HandleSubmit();
        }

        private async Task<string> UploadImage()
        {
            var fileBytes = File.ReadAllBytes(imagePath);
            MultipartFormDataContent form = new MultipartFormDataContent
            {
                { new ByteArrayContent(fileBytes, 0, fileBytes.Length), "image", Path.GetFileName(imagePath)}
            };
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, WebConfig.BACKEND_URL + "/image"))
            {
                requestMessage.Headers.Add("session_id", sessionId);
                requestMessage.Content = form;
                HttpResponseMessage response = await client.SendAsync(requestMessage);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }

        }

        private void btnBanner_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image|*.png;*.gif;*.svg;*.jpg;*.jpeg;*.jfif;*.pjpeg;*.pjp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    imagePath = openFileDialog.FileName;
                    pbBanner.ImageLocation = imagePath;
                }
            }
        }
    }
}
