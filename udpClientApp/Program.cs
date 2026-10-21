namespace udpClientApp
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();

            ClientForm clientForm = new ClientForm();
            ServerForm serverForm = new ServerForm();

            clientForm.StartPosition = FormStartPosition.Manual;
            clientForm.Location = new Point(50, 100);

            serverForm.StartPosition = FormStartPosition.Manual;
            serverForm.Location = new Point(650, 100);

            clientForm.Show();
            serverForm.Show();

            Application.Run(clientForm);
        }
    }
}