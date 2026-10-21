using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace udpClientApp
{
    public partial class ServerForm : Form
        
    {
        private UdpClient? udpServer;
        public ServerForm()
        {
            InitializeComponent();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            if (udpServer != null)
            {
                richTextBox1.AppendText("Server is already running." + Environment.NewLine);
                return;
            }

            try
            {
                udpServer = new UdpClient(5000);
                _ = ReceiveMessages();

                richTextBox1.AppendText(
                    "Server started. Waiting for messages..." + Environment.NewLine);
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Could not start server: " + ex.Message);

                udpServer?.Close();
                udpServer = null;
            }
        }
        private async Task ReceiveMessages()
        {
            UdpClient? server = udpServer;

            if (server == null)
            {
                return;
            }

            while (true)
            {
                UdpReceiveResult result = await server.ReceiveAsync();
                string message = Encoding.UTF8.GetString(result.Buffer);

                richTextBox1.AppendText("Client: " + message + Environment.NewLine);
            }
        }
    }
}
