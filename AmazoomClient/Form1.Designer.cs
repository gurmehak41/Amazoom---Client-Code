
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
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.textBoxIPAddr = new System.Windows.Forms.TextBox();
			this.textBoxClientID = new System.Windows.Forms.TextBox();
			this.buttonConnectServer = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dataGridViewOrderStatus = new System.Windows.Forms.DataGridView();
			this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxQtyToOrder = new System.Windows.Forms.TextBox();
			this.textBoxProductName = new System.Windows.Forms.TextBox();
			this.buttonOrder = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderStatus)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(196, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(281, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Amazoom Order Form";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(424, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 25);
			this.label4.TabIndex = 6;
			this.label4.Text = "Client ID:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(424, 140);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 25);
			this.label5.TabIndex = 7;
			this.label5.Text = "IP Address:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(424, 194);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 25);
			this.label6.TabIndex = 8;
			this.label6.Text = "Port:";
			// 
			// textBoxPort
			// 
			this.textBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPort.Location = new System.Drawing.Point(535, 191);
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(100, 30);
			this.textBoxPort.TabIndex = 9;
			// 
			// textBoxIPAddr
			// 
			this.textBoxIPAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxIPAddr.Location = new System.Drawing.Point(535, 140);
			this.textBoxIPAddr.Name = "textBoxIPAddr";
			this.textBoxIPAddr.Size = new System.Drawing.Size(100, 30);
			this.textBoxIPAddr.TabIndex = 10;
			// 
			// textBoxClientID
			// 
			this.textBoxClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxClientID.Location = new System.Drawing.Point(535, 89);
			this.textBoxClientID.Name = "textBoxClientID";
			this.textBoxClientID.Size = new System.Drawing.Size(100, 30);
			this.textBoxClientID.TabIndex = 11;
			// 
			// buttonConnectServer
			// 
			this.buttonConnectServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonConnectServer.Location = new System.Drawing.Point(429, 248);
			this.buttonConnectServer.Name = "buttonConnectServer";
			this.buttonConnectServer.Size = new System.Drawing.Size(206, 37);
			this.buttonConnectServer.TabIndex = 12;
			this.buttonConnectServer.Text = "Connect To Server";
			this.buttonConnectServer.UseVisualStyleBackColor = true;
			this.buttonConnectServer.Click += new System.EventHandler(this.buttonConnectServer_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(394, 80);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(262, 219);
			this.pictureBox2.TabIndex = 15;
			this.pictureBox2.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(32, 312);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(129, 25);
			this.label8.TabIndex = 16;
			this.label8.Text = "Order Status:";
			// 
			// dataGridViewOrderStatus
			// 
			this.dataGridViewOrderStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrderStatus.Location = new System.Drawing.Point(28, 340);
			this.dataGridViewOrderStatus.Name = "dataGridViewOrderStatus";
			this.dataGridViewOrderStatus.RowHeadersWidth = 51;
			this.dataGridViewOrderStatus.RowTemplate.Height = 24;
			this.dataGridViewOrderStatus.Size = new System.Drawing.Size(661, 131);
			this.dataGridViewOrderStatus.TabIndex = 17;
			// 
			// dataGridViewInventory
			// 
			this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewInventory.Location = new System.Drawing.Point(28, 512);
			this.dataGridViewInventory.Name = "dataGridViewInventory";
			this.dataGridViewInventory.RowHeadersWidth = 51;
			this.dataGridViewInventory.RowTemplate.Height = 24;
			this.dataGridViewInventory.Size = new System.Drawing.Size(661, 151);
			this.dataGridViewInventory.TabIndex = 18;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(31, 91);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(142, 25);
			this.label9.TabIndex = 19;
			this.label9.Text = "Product Name:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(31, 137);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(133, 25);
			this.label10.TabIndex = 20;
			this.label10.Text = "Qty To Order:";
			// 
			// textBoxQtyToOrder
			// 
			this.textBoxQtyToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxQtyToOrder.Location = new System.Drawing.Point(179, 135);
			this.textBoxQtyToOrder.Name = "textBoxQtyToOrder";
			this.textBoxQtyToOrder.Size = new System.Drawing.Size(166, 30);
			this.textBoxQtyToOrder.TabIndex = 21;
			// 
			// textBoxProductName
			// 
			this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxProductName.Location = new System.Drawing.Point(179, 91);
			this.textBoxProductName.Name = "textBoxProductName";
			this.textBoxProductName.Size = new System.Drawing.Size(166, 30);
			this.textBoxProductName.TabIndex = 22;
			// 
			// buttonOrder
			// 
			this.buttonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonOrder.Location = new System.Drawing.Point(36, 249);
			this.buttonOrder.Name = "buttonOrder";
			this.buttonOrder.Size = new System.Drawing.Size(300, 36);
			this.buttonOrder.TabIndex = 23;
			this.buttonOrder.Text = "Order Product";
			this.buttonOrder.UseVisualStyleBackColor = true;
			this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(29, 78);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(321, 221);
			this.pictureBox1.TabIndex = 24;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 484);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 25);
			this.label2.TabIndex = 25;
			this.label2.Text = "Items Available:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(721, 688);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonOrder);
			this.Controls.Add(this.textBoxProductName);
			this.Controls.Add(this.textBoxQtyToOrder);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dataGridViewInventory);
			this.Controls.Add(this.dataGridViewOrderStatus);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.buttonConnectServer);
			this.Controls.Add(this.textBoxClientID);
			this.Controls.Add(this.textBoxIPAddr);
			this.Controls.Add(this.textBoxPort);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Order Form";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderStatus)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxPort;
		private System.Windows.Forms.TextBox textBoxIPAddr;
		private System.Windows.Forms.TextBox textBoxClientID;
		private System.Windows.Forms.Button buttonConnectServer;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dataGridViewOrderStatus;
		private System.Windows.Forms.DataGridView dataGridViewInventory;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxQtyToOrder;
		private System.Windows.Forms.TextBox textBoxProductName;
		private System.Windows.Forms.Button buttonOrder;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
	}
}

