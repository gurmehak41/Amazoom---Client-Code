
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxQtyApples = new System.Windows.Forms.TextBox();
			this.textBoxQtyOrange = new System.Windows.Forms.TextBox();
			this.buttonPlaceOrder = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.textBoxIPAddr = new System.Windows.Forms.TextBox();
			this.textBoxClientID = new System.Windows.Forms.TextBox();
			this.buttonConnectServer = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(173, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(281, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "Amazoom Order Form";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(46, 134);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Apple";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(46, 180);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Orange";
			// 
			// textBoxQtyApples
			// 
			this.textBoxQtyApples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxQtyApples.Location = new System.Drawing.Point(149, 129);
			this.textBoxQtyApples.Name = "textBoxQtyApples";
			this.textBoxQtyApples.Size = new System.Drawing.Size(100, 30);
			this.textBoxQtyApples.TabIndex = 3;
			// 
			// textBoxQtyOrange
			// 
			this.textBoxQtyOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxQtyOrange.Location = new System.Drawing.Point(149, 175);
			this.textBoxQtyOrange.Name = "textBoxQtyOrange";
			this.textBoxQtyOrange.Size = new System.Drawing.Size(100, 30);
			this.textBoxQtyOrange.TabIndex = 4;
			// 
			// buttonPlaceOrder
			// 
			this.buttonPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPlaceOrder.Location = new System.Drawing.Point(51, 238);
			this.buttonPlaceOrder.Name = "buttonPlaceOrder";
			this.buttonPlaceOrder.Size = new System.Drawing.Size(198, 36);
			this.buttonPlaceOrder.TabIndex = 5;
			this.buttonPlaceOrder.Text = "Place Order";
			this.buttonPlaceOrder.UseVisualStyleBackColor = true;
			this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(340, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 25);
			this.label4.TabIndex = 6;
			this.label4.Text = "Client ID:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(340, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(114, 25);
			this.label5.TabIndex = 7;
			this.label5.Text = "IP Address:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(340, 183);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 25);
			this.label6.TabIndex = 8;
			this.label6.Text = "Port:";
			// 
			// textBoxPort
			// 
			this.textBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPort.Location = new System.Drawing.Point(451, 180);
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(100, 30);
			this.textBoxPort.TabIndex = 9;
			// 
			// textBoxIPAddr
			// 
			this.textBoxIPAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxIPAddr.Location = new System.Drawing.Point(451, 129);
			this.textBoxIPAddr.Name = "textBoxIPAddr";
			this.textBoxIPAddr.Size = new System.Drawing.Size(100, 30);
			this.textBoxIPAddr.TabIndex = 10;
			// 
			// textBoxClientID
			// 
			this.textBoxClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxClientID.Location = new System.Drawing.Point(451, 78);
			this.textBoxClientID.Name = "textBoxClientID";
			this.textBoxClientID.Size = new System.Drawing.Size(100, 30);
			this.textBoxClientID.TabIndex = 11;
			// 
			// buttonConnectServer
			// 
			this.buttonConnectServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonConnectServer.Location = new System.Drawing.Point(345, 237);
			this.buttonConnectServer.Name = "buttonConnectServer";
			this.buttonConnectServer.Size = new System.Drawing.Size(206, 37);
			this.buttonConnectServer.TabIndex = 12;
			this.buttonConnectServer.Text = "Connect To Server";
			this.buttonConnectServer.UseVisualStyleBackColor = true;
			this.buttonConnectServer.Click += new System.EventHandler(this.buttonConnectServer_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(46, 78);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(142, 25);
			this.label7.TabIndex = 13;
			this.label7.Text = "Enter Quantity:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(28, 69);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(241, 219);
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(310, 69);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(262, 219);
			this.pictureBox2.TabIndex = 15;
			this.pictureBox2.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 539);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.buttonConnectServer);
			this.Controls.Add(this.textBoxClientID);
			this.Controls.Add(this.textBoxIPAddr);
			this.Controls.Add(this.textBoxPort);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonPlaceOrder);
			this.Controls.Add(this.textBoxQtyOrange);
			this.Controls.Add(this.textBoxQtyApples);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Name = "Form1";
			this.Text = "Order Form";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxQtyApples;
		private System.Windows.Forms.TextBox textBoxQtyOrange;
		private System.Windows.Forms.Button buttonPlaceOrder;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxPort;
		private System.Windows.Forms.TextBox textBoxIPAddr;
		private System.Windows.Forms.TextBox textBoxClientID;
		private System.Windows.Forms.Button buttonConnectServer;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}

