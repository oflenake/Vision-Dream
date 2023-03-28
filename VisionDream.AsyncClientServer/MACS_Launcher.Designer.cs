namespace VisionDream.AsyncClientServer
{
    partial class FrmMACS_Launcher
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
            this.buttonMACSClient = new System.Windows.Forms.Button();
            this.buttonMACSServer = new System.Windows.Forms.Button();
            this.labelMACSApp = new System.Windows.Forms.Label();
            this.lblPoweredBy = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMACSClient
            // 
            this.buttonMACSClient.BackColor = System.Drawing.Color.Blue;
            this.buttonMACSClient.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMACSClient.ForeColor = System.Drawing.Color.Yellow;
            this.buttonMACSClient.Location = new System.Drawing.Point(400, 78);
            this.buttonMACSClient.Name = "buttonMACSClient";
            this.buttonMACSClient.Size = new System.Drawing.Size(105, 79);
            this.buttonMACSClient.TabIndex = 7;
            this.buttonMACSClient.Text = "Launch MACS Client ";
            this.buttonMACSClient.UseVisualStyleBackColor = false;
            this.buttonMACSClient.Click += new System.EventHandler(this.buttonMACSClient_Click);
            // 
            // buttonMACSServer
            // 
            this.buttonMACSServer.BackColor = System.Drawing.Color.Blue;
            this.buttonMACSServer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMACSServer.ForeColor = System.Drawing.Color.Yellow;
            this.buttonMACSServer.Location = new System.Drawing.Point(173, 78);
            this.buttonMACSServer.Name = "buttonMACSServer";
            this.buttonMACSServer.Size = new System.Drawing.Size(105, 79);
            this.buttonMACSServer.TabIndex = 6;
            this.buttonMACSServer.Text = "Launch MACS Server";
            this.buttonMACSServer.UseVisualStyleBackColor = false;
            this.buttonMACSServer.Click += new System.EventHandler(this.buttonMACSServer_Click);
            // 
            // labelMACSApp
            // 
            this.labelMACSApp.AutoSize = true;
            this.labelMACSApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMACSApp.Location = new System.Drawing.Point(139, 25);
            this.labelMACSApp.Name = "labelMACSApp";
            this.labelMACSApp.Size = new System.Drawing.Size(411, 20);
            this.labelMACSApp.TabIndex = 8;
            this.labelMACSApp.Text = "Manje Access Control Solution (MACS) App v0.1.0";
            // 
            // lblPoweredBy
            // 
            this.lblPoweredBy.AutoSize = true;
            this.lblPoweredBy.Location = new System.Drawing.Point(12, 186);
            this.lblPoweredBy.Name = "lblPoweredBy";
            this.lblPoweredBy.Size = new System.Drawing.Size(66, 13);
            this.lblPoweredBy.TabIndex = 9;
            this.lblPoweredBy.Text = "Powered by:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(559, 176);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmMACS_Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 208);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPoweredBy);
            this.Controls.Add(this.labelMACSApp);
            this.Controls.Add(this.buttonMACSClient);
            this.Controls.Add(this.buttonMACSServer);
            this.Name = "FrmMACS_Launcher";
            this.Text = "MACS Launcher";
            this.Load += new System.EventHandler(this.MACS_Launcher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMACSClient;
        private System.Windows.Forms.Button buttonMACSServer;
        private System.Windows.Forms.Label labelMACSApp;
        private System.Windows.Forms.Label lblPoweredBy;
        private System.Windows.Forms.Button btnClose;
    }
}

