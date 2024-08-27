using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace PortfollioAdminPortal
{
    public abstract partial class EntitiesMenu<T> : Form where T : IServerEntity, new()
    {
        protected readonly HttpClient client;
        protected string sessionId;

        public T SelectedRecord
        {
            get
            {
                return records[lstEntities.SelectedIndex];
            }
        }

        public EntitiesMenu(string sessionId, HttpClient client)
        {
            this.sessionId = sessionId;
            this.client = client;
            InitializeComponent();
        }
        protected List<T>? records = null;
        protected async void requestRecords()
        {
            
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, getEndpointAddress()))
            {
                requestMessage.Headers.Add("session_id", sessionId);
                var response = await client.SendAsync(requestMessage);
                string jsonText = await response.Content.ReadAsStringAsync();
                lstEntities.Items.Clear();
                records = JsonSerializer.Deserialize<List<T>>(jsonText);
                foreach (IServerEntity e in records)
                {
                    lstEntities.Items.Add(e.DisplayText);
                }

            }
        }

        protected void Main_Load(object sender, EventArgs e)
        {
            requestRecords();

        }

        protected abstract void btnAdd_Click(object sender, EventArgs e);

        protected void AddEntity(Form newForm)
        {
            Hide();
            newForm.ShowDialog();
            requestRecords();
            Show();
        }

        protected string getEndpointAddress()
        {
            IServerEntity entity = new T();
            return entity.EndpointRoute;
        }
        protected async void DeleteEntity()
        {
            IServerEntity selectedRecord = records[lstEntities.SelectedIndex];
            string url = getEndpointAddress() + selectedRecord.id;
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
                records.RemoveAt(lstEntities.SelectedIndex);
                lstEntities.Items.RemoveAt(lstEntities.SelectedIndex);
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstEntities.SelectedIndex == -1) return;

            DeleteEntity();

        }

        protected abstract void btnEdit_Click(object sender, EventArgs e);

    }
}