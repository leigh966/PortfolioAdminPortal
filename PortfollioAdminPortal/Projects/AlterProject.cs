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
using System.Xml.Linq;

namespace PortfollioAdminPortal
{
    public partial class AlterProject : AlterRecordForm<Project>
    {
        string? imagePath = null, aws_filename = null;

        public AlterProject(string sessionId, HttpClient client) : base(sessionId, client)
        {
            if (txtName is null) InitializeComponent();
        }

        public AlterProject(string sessionId, HttpClient client, Project project) : base(sessionId, client, project)
        {
            if (txtName is null) InitializeComponent();
        }

        protected override void UnpackEntity(Project entity)
        {
            if(txtName is null) InitializeComponent();
            txtName.Text = entity.name;
            txtTagline.Text = entity.tagline;
            txtDescription.Text = entity.description;
            id = entity.id;
            if (entity.image_filename != null)
            {
                pbBanner.ImageLocation = WebConfig.BACKEND_URL + "/" + entity.image_filename;
            }
            aws_filename = entity.image_filename;
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

        protected override async void HandleSubmit()
        {
            if (imagePath != null)
            {
                aws_filename = await UploadImage();
            }
            base.HandleSubmit();
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

        protected override Project PackEntity()
        {
            return new Project(txtName.Text, txtDescription.Text, DateTime.Now.ToString(),txtTagline.Text, aws_filename);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            HandleSubmit();
        }
    }
}
