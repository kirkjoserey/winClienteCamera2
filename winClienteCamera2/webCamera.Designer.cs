namespace winClienteCamera2
{
	partial class webCamera
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.bClose = new System.Windows.Forms.Button();
			this.bSubscribe = new System.Windows.Forms.Button();
			this.bGetMsg = new System.Windows.Forms.Button();
			this.rtResponse = new System.Windows.Forms.RichTextBox();
			this.rtGetMessages = new System.Windows.Forms.RichTextBox();
			this.lblServer = new System.Windows.Forms.Label();
			this.lblCurr = new System.Windows.Forms.Label();
			this.lblPlate = new System.Windows.Forms.Label();
			this.btShow = new System.Windows.Forms.Button();
			this.btHide = new System.Windows.Forms.Button();
			this.picPlate = new System.Windows.Forms.PictureBox();
			this.btSetClient = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picPlate)).BeginInit();
			this.SuspendLayout();
			// 
			// bClose
			// 
			this.bClose.Location = new System.Drawing.Point(672, 477);
			this.bClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bClose.Name = "bClose";
			this.bClose.Size = new System.Drawing.Size(95, 30);
			this.bClose.TabIndex = 0;
			this.bClose.Text = "Close";
			this.bClose.UseVisualStyleBackColor = true;
			this.bClose.Click += new System.EventHandler(this.bClose_Click);
			// 
			// bSubscribe
			// 
			this.bSubscribe.Location = new System.Drawing.Point(21, 49);
			this.bSubscribe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bSubscribe.Name = "bSubscribe";
			this.bSubscribe.Size = new System.Drawing.Size(154, 30);
			this.bSubscribe.TabIndex = 1;
			this.bSubscribe.Text = "Subscribe";
			this.bSubscribe.UseVisualStyleBackColor = true;
			this.bSubscribe.Click += new System.EventHandler(this.bSubscribe_Click);
			// 
			// bGetMsg
			// 
			this.bGetMsg.Location = new System.Drawing.Point(21, 83);
			this.bGetMsg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.bGetMsg.Name = "bGetMsg";
			this.bGetMsg.Size = new System.Drawing.Size(154, 30);
			this.bGetMsg.TabIndex = 2;
			this.bGetMsg.Text = "Get Messages";
			this.bGetMsg.UseVisualStyleBackColor = true;
			this.bGetMsg.Click += new System.EventHandler(this.bGetMsg_Click);
			// 
			// rtResponse
			// 
			this.rtResponse.Location = new System.Drawing.Point(203, 8);
			this.rtResponse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.rtResponse.Name = "rtResponse";
			this.rtResponse.Size = new System.Drawing.Size(566, 131);
			this.rtResponse.TabIndex = 6;
			this.rtResponse.Text = "";
			this.rtResponse.Visible = false;
			// 
			// rtGetMessages
			// 
			this.rtGetMessages.Location = new System.Drawing.Point(193, 8);
			this.rtGetMessages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.rtGetMessages.Name = "rtGetMessages";
			this.rtGetMessages.Size = new System.Drawing.Size(576, 424);
			this.rtGetMessages.TabIndex = 7;
			this.rtGetMessages.Text = "";
			this.rtGetMessages.Visible = false;
			// 
			// lblServer
			// 
			this.lblServer.AutoSize = true;
			this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblServer.Location = new System.Drawing.Point(41, 142);
			this.lblServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblServer.Name = "lblServer";
			this.lblServer.Size = new System.Drawing.Size(16, 24);
			this.lblServer.TabIndex = 8;
			this.lblServer.Text = ".";
			// 
			// lblCurr
			// 
			this.lblCurr.AutoSize = true;
			this.lblCurr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurr.Location = new System.Drawing.Point(41, 182);
			this.lblCurr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCurr.Name = "lblCurr";
			this.lblCurr.Size = new System.Drawing.Size(16, 24);
			this.lblCurr.TabIndex = 9;
			this.lblCurr.Text = ".";
			// 
			// lblPlate
			// 
			this.lblPlate.AutoSize = true;
			this.lblPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlate.Location = new System.Drawing.Point(205, 469);
			this.lblPlate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPlate.Name = "lblPlate";
			this.lblPlate.Size = new System.Drawing.Size(16, 24);
			this.lblPlate.TabIndex = 10;
			this.lblPlate.Text = ".";
			// 
			// btShow
			// 
			this.btShow.Location = new System.Drawing.Point(21, 327);
			this.btShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btShow.Name = "btShow";
			this.btShow.Size = new System.Drawing.Size(154, 30);
			this.btShow.TabIndex = 11;
			this.btShow.Text = "Show Image";
			this.btShow.UseVisualStyleBackColor = true;
			this.btShow.Visible = false;
			this.btShow.Click += new System.EventHandler(this.btShow_Click);
			// 
			// btHide
			// 
			this.btHide.Location = new System.Drawing.Point(21, 367);
			this.btHide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btHide.Name = "btHide";
			this.btHide.Size = new System.Drawing.Size(154, 30);
			this.btHide.TabIndex = 12;
			this.btHide.Text = "Hide Image";
			this.btHide.UseVisualStyleBackColor = true;
			this.btHide.Visible = false;
			this.btHide.Click += new System.EventHandler(this.btHide_Click);
			// 
			// picPlate
			// 
			this.picPlate.Location = new System.Drawing.Point(193, 8);
			this.picPlate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.picPlate.Name = "picPlate";
			this.picPlate.Size = new System.Drawing.Size(585, 424);
			this.picPlate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picPlate.TabIndex = 13;
			this.picPlate.TabStop = false;
			this.picPlate.Visible = false;
			// 
			// btSetClient
			// 
			this.btSetClient.Location = new System.Drawing.Point(21, 8);
			this.btSetClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btSetClient.Name = "btSetClient";
			this.btSetClient.Size = new System.Drawing.Size(154, 30);
			this.btSetClient.TabIndex = 14;
			this.btSetClient.Text = "Set HTTP Client";
			this.btSetClient.UseVisualStyleBackColor = true;
			this.btSetClient.Click += new System.EventHandler(this.btSetClient_Click);
			// 
			// webCamera
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 526);
			this.ControlBox = false;
			this.Controls.Add(this.btSetClient);
			this.Controls.Add(this.picPlate);
			this.Controls.Add(this.btHide);
			this.Controls.Add(this.btShow);
			this.Controls.Add(this.lblPlate);
			this.Controls.Add(this.lblCurr);
			this.Controls.Add(this.lblServer);
			this.Controls.Add(this.rtGetMessages);
			this.Controls.Add(this.rtResponse);
			this.Controls.Add(this.bGetMsg);
			this.Controls.Add(this.bSubscribe);
			this.Controls.Add(this.bClose);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "webCamera";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vehicle Plate";
			((System.ComponentModel.ISupportInitialize)(this.picPlate)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bClose;
		private System.Windows.Forms.Button bSubscribe;
		private System.Windows.Forms.Button bGetMsg;
		private System.Windows.Forms.RichTextBox rtResponse;
		private System.Windows.Forms.RichTextBox rtGetMessages;
		private System.Windows.Forms.Label lblServer;
		private System.Windows.Forms.Label lblCurr;
		private System.Windows.Forms.Label lblPlate;
		private System.Windows.Forms.Button btShow;
		private System.Windows.Forms.Button btHide;
		private System.Windows.Forms.PictureBox picPlate;
		private System.Windows.Forms.Button btSetClient;
	}
}

