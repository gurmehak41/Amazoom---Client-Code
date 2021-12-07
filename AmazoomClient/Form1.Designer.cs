
namespace AmazoomClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelClientID = new System.Windows.Forms.Label();
            this.labelIPAddr = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxIPAddr = new System.Windows.Forms.TextBox();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.buttonConnectServer = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelOrderStatus = new System.Windows.Forms.Label();
            this.dataGridViewOrderStatus = new System.Windows.Forms.DataGridView();
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelQtyToOrder = new System.Windows.Forms.Label();
            this.textBoxQtyToOrder = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClientID
            // 
            this.labelClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientID.Location = new System.Drawing.Point(11, 8);
            this.labelClientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(40, 26);
            this.labelClientID.TabIndex = 6;
            this.labelClientID.Text = "ID";
            this.labelClientID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIPAddr
            // 
            this.labelIPAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIPAddr.Location = new System.Drawing.Point(135, 8);
            this.labelIPAddr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIPAddr.Name = "labelIPAddr";
            this.labelIPAddr.Size = new System.Drawing.Size(40, 26);
            this.labelIPAddr.TabIndex = 7;
            this.labelIPAddr.Text = "IP";
            this.labelIPAddr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPort
            // 
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.Location = new System.Drawing.Point(259, 8);
            this.labelPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(40, 26);
            this.labelPort.TabIndex = 8;
            this.labelPort.Text = "Port";
            this.labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPort.Location = new System.Drawing.Point(303, 8);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(76, 26);
            this.textBoxPort.TabIndex = 9;
            this.textBoxPort.Text = "8911";
            // 
            // textBoxIPAddr
            // 
            this.textBoxIPAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIPAddr.Location = new System.Drawing.Point(179, 8);
            this.textBoxIPAddr.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIPAddr.Name = "textBoxIPAddr";
            this.textBoxIPAddr.Size = new System.Drawing.Size(76, 26);
            this.textBoxIPAddr.TabIndex = 10;
            this.textBoxIPAddr.Text = "127.0.0.1";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientID.Location = new System.Drawing.Point(55, 8);
            this.textBoxClientID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(76, 26);
            this.textBoxClientID.TabIndex = 11;
            this.textBoxClientID.Text = "2";
            // 
            // buttonConnectServer
            // 
            this.buttonConnectServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectServer.Location = new System.Drawing.Point(14, 38);
            this.buttonConnectServer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnectServer.Name = "buttonConnectServer";
            this.buttonConnectServer.Size = new System.Drawing.Size(365, 30);
            this.buttonConnectServer.TabIndex = 12;
            this.buttonConnectServer.Text = "Connect To Server";
            this.buttonConnectServer.UseVisualStyleBackColor = true;
            this.buttonConnectServer.Click += new System.EventHandler(this.buttonConnectServer_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelOrderStatus
            // 
            this.labelOrderStatus.AutoSize = true;
            this.labelOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderStatus.Location = new System.Drawing.Point(14, 275);
            this.labelOrderStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOrderStatus.Name = "labelOrderStatus";
            this.labelOrderStatus.Size = new System.Drawing.Size(82, 16);
            this.labelOrderStatus.TabIndex = 16;
            this.labelOrderStatus.Text = "Order Status";
            // 
            // dataGridViewOrderStatus
            // 
            this.dataGridViewOrderStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderStatus.Location = new System.Drawing.Point(11, 293);
            this.dataGridViewOrderStatus.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOrderStatus.Name = "dataGridViewOrderStatus";
            this.dataGridViewOrderStatus.ReadOnly = true;
            this.dataGridViewOrderStatus.RowHeadersVisible = false;
            this.dataGridViewOrderStatus.RowHeadersWidth = 51;
            this.dataGridViewOrderStatus.RowTemplate.Height = 24;
            this.dataGridViewOrderStatus.Size = new System.Drawing.Size(368, 100);
            this.dataGridViewOrderStatus.TabIndex = 17;
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Location = new System.Drawing.Point(14, 173);
            this.dataGridViewInventory.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.ReadOnly = true;
            this.dataGridViewInventory.RowHeadersVisible = false;
            this.dataGridViewInventory.RowHeadersWidth = 51;
            this.dataGridViewInventory.RowTemplate.Height = 24;
            this.dataGridViewInventory.Size = new System.Drawing.Size(365, 100);
            this.dataGridViewInventory.TabIndex = 18;
            // 
            // labelProductName
            // 
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(14, 96);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(60, 26);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "Product";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQtyToOrder
            // 
            this.labelQtyToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtyToOrder.Location = new System.Drawing.Point(215, 96);
            this.labelQtyToOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQtyToOrder.Name = "labelQtyToOrder";
            this.labelQtyToOrder.Size = new System.Drawing.Size(60, 26);
            this.labelQtyToOrder.TabIndex = 20;
            this.labelQtyToOrder.Text = "Qty";
            this.labelQtyToOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxQtyToOrder
            // 
            this.textBoxQtyToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQtyToOrder.Location = new System.Drawing.Point(279, 98);
            this.textBoxQtyToOrder.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxQtyToOrder.Name = "textBoxQtyToOrder";
            this.textBoxQtyToOrder.Size = new System.Drawing.Size(100, 22);
            this.textBoxQtyToOrder.TabIndex = 21;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.Location = new System.Drawing.Point(78, 98);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(100, 22);
            this.textBoxProductName.TabIndex = 22;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.Location = new System.Drawing.Point(14, 124);
            this.buttonOrder.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(365, 29);
            this.buttonOrder.TabIndex = 23;
            this.buttonOrder.Text = "Order Product";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventory.Location = new System.Drawing.Point(13, 155);
            this.labelInventory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(100, 16);
            this.labelInventory.TabIndex = 25;
            this.labelInventory.Text = "Items Available";
            // 
            // labelCustomer
            // 
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.Location = new System.Drawing.Point(14, 70);
            this.labelCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(365, 26);
            this.labelCustomer.TabIndex = 26;
            this.labelCustomer.Text = "Please place your order here";
            this.labelCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(394, 401);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxQtyToOrder);
            this.Controls.Add(this.labelQtyToOrder);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.dataGridViewInventory);
            this.Controls.Add(this.dataGridViewOrderStatus);
            this.Controls.Add(this.labelOrderStatus);
            this.Controls.Add(this.buttonConnectServer);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.textBoxIPAddr);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelIPAddr);
            this.Controls.Add(this.labelClientID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Amazoom Order Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Label labelClientID;
		private System.Windows.Forms.Label labelIPAddr;
		private System.Windows.Forms.Label labelPort;
		private System.Windows.Forms.TextBox textBoxPort;
		private System.Windows.Forms.TextBox textBoxIPAddr;
		private System.Windows.Forms.TextBox textBoxClientID;
		private System.Windows.Forms.Button buttonConnectServer;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label labelOrderStatus;
		private System.Windows.Forms.DataGridView dataGridViewOrderStatus;
		private System.Windows.Forms.DataGridView dataGridViewInventory;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Label labelQtyToOrder;
		private System.Windows.Forms.TextBox textBoxQtyToOrder;
		private System.Windows.Forms.TextBox textBoxProductName;
		private System.Windows.Forms.Button buttonOrder;
		private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelCustomer;
    }
}

