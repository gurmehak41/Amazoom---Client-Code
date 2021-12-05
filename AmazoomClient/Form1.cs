using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;
using System.Diagnostics;
using System.Collections.Concurrent;

namespace AmazoomClient
{
    public partial class Form1 : Form
    {
        private  SimpleTcpClient client;

        public Form1()
        {
            InitializeComponent();
        }

		public void Form1_Load(object sender, EventArgs e)
		{

        }

        private void DataReceived(object sender, SimpleTCP.Message e)
        {
            Debug.WriteLine($"Data received from server: {e.MessageString}");
        }

        private void buttonConnectServer_Click(object sender, EventArgs e)
        {
            if (buttonConnectServer.Text == "Connect To Server")
            {
                this.client = new SimpleTcpClient().Connect(textBoxIPAddr.Text, Convert.ToInt32(textBoxPort.Text));
                this.client.StringEncoder = Encoding.UTF8;
                this.client.Delimiter = 0x13;  // enter
                this.client.StringEncoder = Encoding.UTF8;
                this.client.DelimiterDataReceived += DataReceived;

                this.client.WriteLine("ClientStart/" + textBoxClientID.Text + "/-/-");

                buttonConnectServer.Text = "Disconnect";
            }
            else
            {
                this.client.WriteLine("ClientStop/" + textBoxClientID.Text + "/-/-");
                this.client.Disconnect();
                buttonConnectServer.Text = "Connect To Server";
            }

        }

		private void buttonPlaceOrder_Click(object sender, EventArgs e)
		{
            string message = "";

            //Build up message
            message = "OrderFromClient/" + textBoxClientID.Text + "/";

            if (textBoxQtyApples.Text != "")
                message += "apples" + textBoxQtyApples.Text + "/";

            if (textBoxQtyShampoo.Text != "")
                message += "shampoo" + textBoxQtyShampoo.Text + "/";

            this.client.WriteLine(message);
        }
	}
}
