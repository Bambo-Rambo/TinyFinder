
namespace TinyFinder.Subforms.Profile_Calibration
{
    partial class Calibrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calibrator));
            this.IDCalibrate = new System.Windows.Forms.Button();
            this.NormalCalibrate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.NumericUpDown();
            this.xyRadio = new System.Windows.Forms.RadioButton();
            this.orasRadio = new System.Windows.Forms.RadioButton();
            this.game = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tiny3 = new TinyFinder.HexBox();
            this.tiny2 = new TinyFinder.HexBox();
            this.tiny0 = new TinyFinder.HexBox();
            this.tiny1 = new TinyFinder.HexBox();
            ((System.ComponentModel.ISupportInitialize)(this.year)).BeginInit();
            this.SuspendLayout();
            // 
            // IDCalibrate
            // 
            this.IDCalibrate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.IDCalibrate.Location = new System.Drawing.Point(107, 263);
            this.IDCalibrate.Name = "IDCalibrate";
            this.IDCalibrate.Size = new System.Drawing.Size(155, 35);
            this.IDCalibrate.TabIndex = 0;
            this.IDCalibrate.Text = "ID Calibration";
            this.IDCalibrate.UseVisualStyleBackColor = true;
            this.IDCalibrate.Click += new System.EventHandler(this.IDCalibrate_Click);
            // 
            // NormalCalibrate
            // 
            this.NormalCalibrate.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NormalCalibrate.Location = new System.Drawing.Point(107, 319);
            this.NormalCalibrate.Name = "NormalCalibrate";
            this.NormalCalibrate.Size = new System.Drawing.Size(155, 35);
            this.NormalCalibrate.TabIndex = 1;
            this.NormalCalibrate.Text = "Normal Calibration";
            this.NormalCalibrate.UseVisualStyleBackColor = true;
            this.NormalCalibrate.Click += new System.EventHandler(this.NormalCalibrate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label8.Location = new System.Drawing.Point(112, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tiny [0]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label7.Location = new System.Drawing.Point(112, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tiny [1]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label6.Location = new System.Drawing.Point(112, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tiny [2]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.label5.Location = new System.Drawing.Point(112, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tiny [3]";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.y.Location = new System.Drawing.Point(94, 53);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(35, 14);
            this.y.TabIndex = 28;
            this.y.Text = "Year";
            // 
            // year
            // 
            this.year.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.year.Location = new System.Drawing.Point(181, 51);
            this.year.Maximum = new decimal(new int[] {
            2080,
            0,
            0,
            0});
            this.year.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(68, 22);
            this.year.TabIndex = 29;
            this.year.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.year.ValueChanged += new System.EventHandler(this.year_ValueChanged);
            // 
            // xyRadio
            // 
            this.xyRadio.AutoSize = true;
            this.xyRadio.Checked = true;
            this.xyRadio.Location = new System.Drawing.Point(155, 20);
            this.xyRadio.Name = "xyRadio";
            this.xyRadio.Size = new System.Drawing.Size(39, 17);
            this.xyRadio.TabIndex = 30;
            this.xyRadio.TabStop = true;
            this.xyRadio.Text = "XY";
            this.xyRadio.UseVisualStyleBackColor = true;
            // 
            // orasRadio
            // 
            this.orasRadio.AutoSize = true;
            this.orasRadio.Location = new System.Drawing.Point(212, 20);
            this.orasRadio.Name = "orasRadio";
            this.orasRadio.Size = new System.Drawing.Size(55, 17);
            this.orasRadio.TabIndex = 31;
            this.orasRadio.Text = "ORAS";
            this.orasRadio.UseVisualStyleBackColor = true;
            // 
            // game
            // 
            this.game.AutoSize = true;
            this.game.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.game.Location = new System.Drawing.Point(94, 21);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(35, 14);
            this.game.TabIndex = 32;
            this.game.Text = "Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(38, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 14);
            this.label1.TabIndex = 33;
            this.label1.Text = "Set the Citra RTC to 2000-01-01T13:00:00";
            // 
            // tiny3
            // 
            this.tiny3.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.tiny3.Location = new System.Drawing.Point(181, 122);
            this.tiny3.Mask = "AAAAAAAA";
            this.tiny3.Name = "tiny3";
            this.tiny3.Size = new System.Drawing.Size(63, 23);
            this.tiny3.TabIndex = 18;
            this.tiny3.Text = "00000000";
            this.tiny3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tiny3.Value = ((uint)(0u));
            // 
            // tiny2
            // 
            this.tiny2.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.tiny2.Location = new System.Drawing.Point(181, 154);
            this.tiny2.Mask = "AAAAAAAA";
            this.tiny2.Name = "tiny2";
            this.tiny2.Size = new System.Drawing.Size(63, 23);
            this.tiny2.TabIndex = 19;
            this.tiny2.Text = "00000000";
            this.tiny2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tiny2.Value = ((uint)(0u));
            // 
            // tiny0
            // 
            this.tiny0.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.tiny0.Location = new System.Drawing.Point(181, 215);
            this.tiny0.Mask = "AAAAAAAA";
            this.tiny0.Name = "tiny0";
            this.tiny0.Size = new System.Drawing.Size(63, 23);
            this.tiny0.TabIndex = 21;
            this.tiny0.Text = "00000000";
            this.tiny0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tiny0.Value = ((uint)(0u));
            // 
            // tiny1
            // 
            this.tiny1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.tiny1.Location = new System.Drawing.Point(181, 184);
            this.tiny1.Mask = "AAAAAAAA";
            this.tiny1.Name = "tiny1";
            this.tiny1.Size = new System.Drawing.Size(63, 23);
            this.tiny1.TabIndex = 20;
            this.tiny1.Text = "00000000";
            this.tiny1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tiny1.Value = ((uint)(0u));
            // 
            // Calibrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.game);
            this.Controls.Add(this.orasRadio);
            this.Controls.Add(this.xyRadio);
            this.Controls.Add(this.year);
            this.Controls.Add(this.y);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tiny3);
            this.Controls.Add(this.tiny2);
            this.Controls.Add(this.tiny0);
            this.Controls.Add(this.tiny1);
            this.Controls.Add(this.NormalCalibrate);
            this.Controls.Add(this.IDCalibrate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(383, 437);
            this.MinimumSize = new System.Drawing.Size(383, 437);
            this.Name = "Calibrator";
            this.Text = "Profile Calibrator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calibrator_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IDCalibrate;
        private System.Windows.Forms.Button NormalCalibrate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private HexBox tiny3;
        private HexBox tiny2;
        private HexBox tiny0;
        private HexBox tiny1;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.NumericUpDown year;
        private System.Windows.Forms.RadioButton xyRadio;
        private System.Windows.Forms.RadioButton orasRadio;
        private System.Windows.Forms.Label game;
        private System.Windows.Forms.Label label1;
    }
}
