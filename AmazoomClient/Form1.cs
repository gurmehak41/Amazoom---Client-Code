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
        private List<orderInfo> orderList = new List<orderInfo>();
        private Dictionary<int, orderInfo> orderDict = new Dictionary<int, orderInfo>();
        private List<productInfo> productList = new List<productInfo>();
        int orderCounter = 0;
        bool orderListChanged = true;
        bool inventoryChanged = true;

        public Form1()
        {
            InitializeComponent();
        }

		public void Form1_Load(object sender, EventArgs e)
		{

        }

        private void DataReceived(object sender, SimpleTCP.Message e)
        {
            string message = e.MessageString;
            string[] splitMessage;
            int identifier;

            splitMessage = message.Split('/');

            if (splitMessage[0] == "OrderToClient")
            {
                identifier = Convert.ToInt32(splitMessage[2]);

                if (orderDict.ContainsKey(identifier))
                {
                    orderInfo order = orderDict[identifier];

                    //Check if order already exists
                    int i = 0;
                    foreach (orderInfo item in orderList)
                    {
                        if (identifier == item.OrderId)
                        {
                            orderList[i].Status = splitMessage[3];
                            return;
                        }
                        i++;
                    }
                    orderList.Add(new orderInfo(identifier,order.ProductName,order.QtyOrdered,order.Status));
                }
                orderListChanged = true;
            }

            if (splitMessage[0] == "InventoryToClient")
            {
                int i = 0;
                string[] productMessageString = splitMessage[3].Split(',');
                bool productFound = false;

                //Go through each of the products sent in the message
                for (i = 0; i < productMessageString.Length; i++)
                {
                    string[] tempProduct = productMessageString[i].Split('*');
                    if (tempProduct.Length == 2)
                    {
                        string productName = tempProduct[0];
                        int qtyAvailable = Convert.ToInt32(tempProduct[1]);

                        //Check if prouduct already exists in product list
                        int j = 0;
                        productFound = false;
                        foreach (productInfo product in productList)
                        {
                            if (productName == product.Name)
                            {
                                productList[j].Quantity = qtyAvailable;
                                productFound = true;
                            }
                            j++;
                        }

                        //Add to product list if it doesn't currently exist there already
                        if (!productFound)
                            productList.Add(new productInfo(productName, qtyAvailable));
                    }
                }
                inventoryChanged = true;
            }

            if (splitMessage[0] == "ClientDeleteProduct")
            {
                string[] tempProduct = splitMessage[3].Split('*');
                if (tempProduct.Length == 2)
                {
                    string productName = tempProduct[0];
                    int qtyAvailable = Convert.ToInt32(tempProduct[1]);

                    //Check if prouduct exists in product list
                    int j = 0;
                    bool productFound = false;
                    foreach (productInfo product in productList)
                    {
                        if (productName == product.Name)
                        {
                            qtyAvailable = productList[j].Quantity;
                            productFound = true;

                            //productList.Remove(new productInfo(productName, qtyAvailable));
                            productList.RemoveAt(j);
                            inventoryChanged = true;
                            break;
                        }
                        j++;
                    }

                    //Remove from product list if it currently exist
                    /*
                    if (productFound)
                    {
                        productList.Remove(new productInfo(productName, qtyAvailable));
                        inventoryChanged = true;
                    }
                    */
                }
        }
        }

        private void buttonConnectServer_Click(object sender, EventArgs e)
        {
            if (buttonConnectServer.Text == "Connect To Server")
            {
                this.client = new SimpleTcpClient().Connect(textBoxIPAddr.Text, Convert.ToInt32(textBoxPort.Text));
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


		private void timer1_Tick(object sender, EventArgs e)
		{
            if (orderListChanged)
            {
                dataGridViewOrderStatus.DataSource = null;  // need this to work
                dataGridViewOrderStatus.DataSource = this.orderList;

                orderListChanged = false;
            }

            if (inventoryChanged)
            {
                dataGridViewInventory.DataSource = null;  // need this to work
                dataGridViewInventory.DataSource = this.productList;

                inventoryChanged = false;
            }

            
        }

		private void buttonOrder_Click(object sender, EventArgs e)
		{
            string message = "";
            int identifier = Convert.ToInt32(textBoxClientID.Text) * 1000 + orderCounter;

            orderCounter++;

            //Build up message
            message = "OrderFromClient/" + Convert.ToString(identifier) + "/-/";

            if (textBoxProductName.Text != "")
                message += textBoxProductName.Text + "*" + textBoxQtyToOrder.Text + ",";

            this.client.WriteLine(message);

            //Populate OrderDict 
            orderDict.Add(identifier, new orderInfo(identifier, textBoxProductName.Text, Convert.ToInt32(textBoxQtyToOrder.Text), "Ordered"));
            orderList.Add(new orderInfo(identifier, textBoxProductName.Text, Convert.ToInt32(textBoxQtyToOrder.Text), "Ordered"));

            orderListChanged = true;
        }

	}

	public class orderInfo
    {
        public int OrderId
        { get; }

        public string ProductName
        { get; }

        public int QtyOrdered
        { get; }

        public string Status
        { get; set; }

        public orderInfo(int combinedId, string productName, int qty, string status)
        {
            this.OrderId = combinedId;
            this.ProductName = productName;
            this.QtyOrdered = qty;
            this.Status = status;
        }
    }

    public class productInfo
    {

        public string Name
        { get; }

        public int Quantity
        { get; set; }

        public productInfo(string name, int qty)
        {
            this.Name = name;
            this.Quantity = qty;
        }
    }
}
