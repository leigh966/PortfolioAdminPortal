using System.Text;

namespace PortfollioAdminPortal
{
    public abstract partial class AlterRecordForm<T> : Form where T : IServerEntity
    {


        protected HttpClient client;
        protected string sessionId;


        public AlterRecordForm(string sessionId, HttpClient client)
        {
            this.sessionId = sessionId;
            this.client = client;
        }

        protected string? id = null;

        protected abstract void UnpackEntity(T entity);

        public AlterRecordForm(string sessionId, HttpClient client, T entity) : this(sessionId, client)
        {
            UnpackEntity(entity);
        }

        protected abstract IServerEntity PackEntity();

        protected string GetJson()
        {
            return PackEntity().GetJson();
        }

        private async void UpdateRecord()
        {
            string json = GetJson();
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Put, new Project().EndpointRoute + id))
            {
                requestMessage.Headers.Add("session_id", sessionId);
                requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.SendAsync(requestMessage);
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(responseString, response.StatusCode.ToString(), MessageBoxButtons.OK);
                    return;
                }
            }

            Close();
        }

        private async void AddRecord()
        {

            string json = GetJson();
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, new Project().EndpointRoute))
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



        protected virtual async void HandleSubmit()
        {
            if (id != null)
            {
                UpdateRecord();
                return;
            }
            AddRecord();
        }


    }

}
