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

            var response = await client.PostAsync(WebConfig.BACKEND_URL + "/login", content);
            var responseString = await response.Content.ReadAsStringAsync();
            if (response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                MessageBox.Show(responseString, response.StatusCode.ToString(), MessageBoxButtons.OK);
                return;
            }

            Form mainForm = new MainMenu(responseString, client);
            Hide();
            mainForm.ShowDialog();
            Close();


        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            sendLoginRequest();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void onKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendLoginRequest();
            }
        }
    }
}
