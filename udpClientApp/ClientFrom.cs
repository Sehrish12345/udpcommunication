using System.Net.Sockets;
using System.Text;

namespace udpClientApp
{
    public partial class ClientForm : Form
    {
        private UdpClient? udpClient;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            udpClient = new UdpClient();
            label2.Text = "Status: Started";
            MessageBox.Show("Client started!");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (udpClient == null)
            {
                MessageBox.Show("Please click Start first!");
                return;
            }

            string message = richTextBox1.Text;

            if (string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Please enter a message first!");
                return;
            }

            byte[] data = Encoding.UTF8.GetBytes(message);

            udpClient.Send(data, data.Length, "127.0.0.1", 5000);

            richTextBox1.Clear();

            MessageBox.Show("Message sent!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox("Please Enter Correct values");

        }
    }
}
