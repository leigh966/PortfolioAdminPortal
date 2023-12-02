using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json.Nodes;
using System.Windows.Forms;

namespace PortfollioAdminPortal
{
    public partial class Login : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Login()
        {
            InitializeComponent();
        }

        private async void sendLoginRequest()
        {

            string json = "{\"password\":\"" + txtPass.Text + "\",\"otp\":\"" + txtVerCode.Text + "\"}";

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("http://127.0.0.1:3000/login", content);
            var responseString = await response.Content.ReadAsStringAsync();
            if (response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                MessageBox.Show(responseString, response.StatusCode.ToString(), MessageBoxButtons.OK);
                return;
            }

            Form mainForm = new Main();
            Hide();
            mainForm.ShowDialog();
            Close();
            

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            sendLoginRequest();
        }
    }
}
