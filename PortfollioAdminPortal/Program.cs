namespace PortfollioAdminPortal
{
    internal static class Program
    {
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
            while (!File.Exists("target_url"))
            {
                MessageBox.Show("No target URL found. Please provide one", "target_url not found", MessageBoxButtons.OK);
                Application.Run(new ConnectForm());
            }
            ReadTarget();

            Application.Run(new Login());
        }
    }
}