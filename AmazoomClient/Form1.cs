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

        public class OrderInfo
        {
            public int Id
            { get; }

            public string Product
            { get; }

            public int Quantity
            { get; }

            public string Status
            { get; set; }

            public OrderInfo(int combinedId, string product, int quantity,
                string status)
            {
                this.Id = combinedId;
                this.Product = product;
                this.Quantity = quantity;
                this.Status = status;
            }
        }

        public class ProductInfo
        {
            public string Name
            { get; }

            public int Quantity
            { get; set; }

            public ProductInfo(string name, int quantity)
            {
                this.Name = name;
                this.Quantity = quantity;
            }
        }

        private SimpleTcpClient client;
        private List<ProductInfo> productList;
        private List<OrderInfo> orderList;
        int clientId;
        int orderIdCounter;
        bool productListChanged;
        bool orderListChanged;
        bool isServerConnected;

        public Form1()
        {
            InitializeComponent();

            this.productList = new List<ProductInfo>();
            this.orderList = new List<OrderInfo>();

            orderIdCounter = 0;
            productListChanged = true;
            orderListChanged = true;
        }

        private void sendMessage(string command, string sender, string receiver,
            string payload)
        {
            if (string.IsNullOrEmpty(sender))
            {
                sender = "-";
            }
            if (string.IsNullOrEmpty(receiver))
            {
                receiver = "-";
            }
            if (string.IsNullOrEmpty(payload))
            {
                payload = "-";
            }
            this.client.WriteLine(command + "/"
                + sender + "/"
                + receiver + "/"
                + payload);
        }

        private void DataReceived(object sender, SimpleTCP.Message e)
        {
            string[] message = e.MessageString.Split('/');
            if (message.Length != 4)
            {
                return;
            }
            string messageCommand = message[0];
            string messageSender = message[1];
            string messageReceiver = message[2];
            string messagePayload = message[3];

            int orderId;
            if (messageCommand == "InventoryToClient")
            {
                this.productList.Clear();
                bool productFound;
                string[] productQuantities = messagePayload.Split(',');
                // Go through each of the products sent in the payload
                for (int i = 0; i < productQuantities.Length; i++)
                {
                    string[] productQuantity = productQuantities[i].Split('*');
                    if (productQuantity.Length == 2)
                    {
                        string product = productQuantity[0];
                        int quantity = Convert.ToInt32(productQuantity[1]);

                        // Check if prouduct already exists
                        int j = 0;
                        productFound = false;
                        foreach (ProductInfo productInfo in this.productList)
                        {
                            if (productInfo.Name == product)
                            {
                                this.productList[j].Quantity = quantity;
                                productFound = true;
                            }
                            j++;
                        }

                        // Add to product list if it does not exist
                        if (!productFound)
                            this.productList.Add(new ProductInfo(
                                product, quantity));
                    }
                }
                this.productListChanged = true;
            }
            else if (messageCommand == "OrderToClient")
            {
                orderId = Convert.ToInt32(messageReceiver);

                int i = 0;
                foreach (var orderInfo in this.orderList)
                {
                    if (orderInfo.Id == orderId)
                    {
                        orderList[i].Status = messagePayload;
                        this.orderListChanged = true;
                    }
                    i++;
                }
            }
            else if (messageCommand == "ClientDeleteProduct")
            {
                string[] productQuantity = messagePayload.Split('*');
                if (productQuantity.Length == 2)
                {
                    string product = productQuantity[0];

                    //Check if product exists
                    int j = 0;
                    foreach (ProductInfo productInfo in this.productList)
                    {
                        if (productInfo.Name == product)
                        {
                            this.productList.RemoveAt(j);
                            this.productListChanged = true;
                            break;
                        }
                        j++;
                    }
                }
            }
        }

        private void buttonConnectServer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxClientID.Text) ||
                string.IsNullOrEmpty(textBoxIPAddr.Text) ||
                string.IsNullOrEmpty(textBoxPort.Text))
            {
                MessageBox.Show("Please fill in infomation!");
                return;
            }

            string serverIP;
            int serverPort;
            try
            {
                this.clientId = Convert.ToInt32(textBoxClientID.Text);
                serverIP = textBoxIPAddr.Text;
                serverPort = Convert.ToInt32(textBoxPort.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Incorrect Server Format");
                return;
            }

            try
            {
                this.client = new SimpleTcpClient().Connect(
                    serverIP, serverPort);
                this.client.Delimiter = 0x13;  // enter
                this.client.StringEncoder = Encoding.UTF8;
                this.client.DelimiterDataReceived += DataReceived;
                sendMessage("ClientStart", this.clientId.ToString(), null,
                    null);

                this.isServerConnected = true;
                buttonConnectServer.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Server cannot be connected");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.productListChanged)
            {
                dataGridViewInventory.DataSource = null;  // need this to work
                List<ProductInfo> temp = new List<ProductInfo>();
                foreach (var productInfo in this.productList)
                {
                    temp.Add(productInfo);
                }
                dataGridViewInventory.DataSource = temp;
                this.productListChanged = false;
            }
            if (this.orderListChanged)
            {
                dataGridViewOrderStatus.DataSource = null;  // need this to work
                List<OrderInfo> temp = new List<OrderInfo>();
                foreach (var orderInfo in this.orderList)
                {
                    temp.Add(orderInfo);
                }
                dataGridViewOrderStatus.DataSource = temp;
                this.orderListChanged = false;
            }
        }

        // TODO: Change to dropdown and combobox
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxProductName.Text) ||
                string.IsNullOrEmpty(textBoxQtyToOrder.Text))
            {
                MessageBox.Show("Please fill in infomation!");
                return;
            }

            string product = textBoxProductName.Text;
            int quantity;
            try
            {
                quantity = Convert.ToInt32(textBoxQtyToOrder.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Incorrect Quantity Format");
                return;
            }
            int orderId = this.clientId * 1000 + this.orderIdCounter;
            string payload = product + "*" + quantity.ToString();

            sendMessage("OrderFromClient", orderId.ToString(), null, payload);

            OrderInfo orderInfo = new OrderInfo(orderId, product, quantity, "Waiting");
            this.orderList.Add(orderInfo);

            this.orderListChanged = true;
            this.orderIdCounter++;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isServerConnected)
            {
                sendMessage("ClientStop", this.clientId.ToString(), null, null);
                this.client.Disconnect();
            }
        }
    }
}
