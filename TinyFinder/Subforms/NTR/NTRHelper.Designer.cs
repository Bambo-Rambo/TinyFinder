
namespace TinyFinder
{
    partial class NTRHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NTRHelper));
            this.B_OneClick = new System.Windows.Forms.Button();
            this.L_NTRLog = new System.Windows.Forms.Label();
            this.B_Disconnect = new System.Windows.Forms.Button();
            this.B_Connect = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.NTR_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // B_OneClick
            // 
            this.B_OneClick.Font = new System.Drawing.Font("Consolas", 9F);
            this.B_OneClick.Location = new System.Drawing.Point(57, 135);
            this.B_OneClick.Name = "B_OneClick";
            this.B_OneClick.Size = new System.Drawing.Size(143, 25);
            this.B_OneClick.TabIndex = 120;
            this.B_OneClick.Text = "One Click";
            this.B_OneClick.UseVisualStyleBackColor = true;
            this.B_OneClick.Click += new System.EventHandler(this.B_Connect_Click);
            // 
            // L_NTRLog
            // 
            this.L_NTRLog.AutoSize = true;
            this.L_NTRLog.Font = new System.Drawing.Font("Consolas", 9F);
            this.L_NTRLog.Location = new System.Drawing.Point(80, 105);
            this.L_NTRLog.Name = "L_NTRLog";
            this.L_NTRLog.Size = new System.Drawing.Size(98, 14);
            this.L_NTRLog.TabIndex = 116;
            this.L_NTRLog.Text = "Not Connected";
            // 
            // B_Disconnect
            // 
            this.B_Disconnect.Enabled = false;
            this.B_Disconnect.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.B_Disconnect.Location = new System.Drawing.Point(137, 62);
            this.B_Disconnect.Name = "B_Disconnect";
            this.B_Disconnect.Size = new System.Drawing.Size(75, 25);
            this.B_Disconnect.TabIndex = 117;
            this.B_Disconnect.Text = "Disconnect";
            this.B_Disconnect.UseVisualStyleBackColor = true;
            this.B_Disconnect.Click += new System.EventHandler(this.B_Disconnect_Click);
            // 
            // B_Connect
            // 
            this.B_Connect.Font = new System.Drawing.Font("Consolas", 9F);
            this.B_Connect.Location = new System.Drawing.Point(47, 62);
            this.B_Connect.Name = "B_Connect";
            this.B_Connect.Size = new System.Drawing.Size(69, 25);
            this.B_Connect.TabIndex = 114;
            this.B_Connect.Text = "Connect";
            this.B_Connect.UseVisualStyleBackColor = true;
            this.B_Connect.Click += new System.EventHandler(this.B_Connect_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 9F);
            this.label18.Location = new System.Drawing.Point(67, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 14);
            this.label18.TabIndex = 113;
            this.label18.Text = "IP";
            // 
            // IP
            // 
            this.IP.Font = new System.Drawing.Font("Consolas", 9F);
            this.IP.Location = new System.Drawing.Point(89, 23);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(102, 22);
            this.IP.TabIndex = 112;
            this.IP.Text = "192.168.0.1";
            // 
            // NTR_Timer
            // 
            this.NTR_Timer.Tick += new System.EventHandler(this.NTRTick);
            // 
            // NTRHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(267, 185);
            this.Controls.Add(this.B_OneClick);
            this.Controls.Add(this.L_NTRLog);
            this.Controls.Add(this.B_Disconnect);
            this.Controls.Add(this.B_Connect);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.IP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(283, 224);
            this.MinimumSize = new System.Drawing.Size(283, 224);
            this.Name = "NTRHelper";
            this.Text = "NTRHelper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NTRHelper_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_OneClick;
        private System.Windows.Forms.Label L_NTRLog;
        private System.Windows.Forms.Button B_Disconnect;
        private System.Windows.Forms.Button B_Connect;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.Timer NTR_Timer;
    }
}