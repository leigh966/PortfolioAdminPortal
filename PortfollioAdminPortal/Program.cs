namespace PortfollioAdminPortal
{
    internal static class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static void ReadTarget()
        {
            WebConfig.BACKEND_URL = File.ReadAllText("target_url");
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            while (true)
            {
                if(File.Exists("target_url"))
                {
                    ReadTarget();
                    try
                    { 
                        var res = client.GetAsync(WebConfig.BACKEND_URL);
                        res.Wait();
                        if(res.Result.StatusCode != System.Net.HttpStatusCode.NoContent)
                        {
                            MessageBox.Show("Target URL cannot be reached. Try again.", "BACKEND_URL unreachable", MessageBoxButtons.OK);
                            Application.Run(new ConnectForm());
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Target URL cannot be reached. Try again.", "BACKEND_URL unreachable", MessageBoxButtons.OK);
                        Application.Run(new ConnectForm());
                    }
                }
                else
                {
                    MessageBox.Show("No target URL found. Please provide one", "target_url not found", MessageBoxButtons.OK);
                    Application.Run(new ConnectForm());
                } 
            }
            

            Application.Run(new Login(client));
        }
    }
}