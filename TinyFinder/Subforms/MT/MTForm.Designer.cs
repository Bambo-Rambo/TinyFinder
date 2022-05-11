
namespace TinyFinder.Subforms.MT
{
    partial class MTForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FindButton = new System.Windows.Forms.Button();
            this.TargetDate = new System.Windows.Forms.TextBox();
            this.RTC_Label = new System.Windows.Forms.Label();
            this.SavePar_Label = new System.Windows.Forms.Label();
            this.TargetSeed_Label = new System.Windows.Forms.Label();
            this.MT_DGV = new System.Windows.Forms.DataGridView();
            this.DateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frame300Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveFrameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewSaveCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewDateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopButton = new System.Windows.Forms.Button();
            this.XY_MTButton = new System.Windows.Forms.RadioButton();
            this.ORAS_MTButton = new System.Windows.Forms.RadioButton();
            this.Frame300_Label = new System.Windows.Forms.Label();
            this.SettingsGroup = new System.Windows.Forms.GroupBox();
            this.Frame300 = new TinyFinder.HexBox();
            this.CurrentSavePar = new TinyFinder.HexBox();
            this.PreferencesGroup = new System.Windows.Forms.GroupBox();
            this.TargetTime = new System.Windows.Forms.TextBox();
            this.SpecificTime = new System.Windows.Forms.CheckBox();
            this.Target = new TinyFinder.HexBox();
            ((System.ComponentModel.ISupportInitialize)(this.MT_DGV)).BeginInit();
            this.SettingsGroup.SuspendLayout();
            this.PreferencesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FindButton.Location = new System.Drawing.Point(12, 203);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(139, 31);
            this.FindButton.TabIndex = 0;
            this.FindButton.Text = "Search";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // TargetDate
            // 
            this.TargetDate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TargetDate.Location = new System.Drawing.Point(145, 44);
            this.TargetDate.MaxLength = 10;
            this.TargetDate.Name = "TargetDate";
            this.TargetDate.Size = new System.Drawing.Size(96, 22);
            this.TargetDate.TabIndex = 1;
            this.TargetDate.Text = "2022-01-01";
            // 
            // RTC_Label
            // 
            this.RTC_Label.AutoSize = true;
            this.RTC_Label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.RTC_Label.Location = new System.Drawing.Point(22, 48);
            this.RTC_Label.Name = "RTC_Label";
            this.RTC_Label.Size = new System.Drawing.Size(84, 14);
            this.RTC_Label.TabIndex = 2;
            this.RTC_Label.Text = "Target Date";
            // 
            // SavePar_Label
            // 
            this.SavePar_Label.AutoSize = true;
            this.SavePar_Label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SavePar_Label.Location = new System.Drawing.Point(22, 148);
            this.SavePar_Label.Name = "SavePar_Label";
            this.SavePar_Label.Size = new System.Drawing.Size(105, 14);
            this.SavePar_Label.TabIndex = 3;
            this.SavePar_Label.Text = "Save Parameter";
            // 
            // TargetSeed_Label
            // 
            this.TargetSeed_Label.AutoSize = true;
            this.TargetSeed_Label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TargetSeed_Label.Location = new System.Drawing.Point(22, 143);
            this.TargetSeed_Label.Name = "TargetSeed_Label";
            this.TargetSeed_Label.Size = new System.Drawing.Size(84, 14);
            this.TargetSeed_Label.TabIndex = 9;
            this.TargetSeed_Label.Text = "Target Seed";
            // 
            // MT_DGV
            // 
            this.MT_DGV.AllowUserToAddRows = false;
            this.MT_DGV.AllowUserToDeleteRows = false;
            this.MT_DGV.AllowUserToResizeRows = false;
            this.MT_DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MT_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MT_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateCol,
            this.Frame300Col,
            this.SaveFrameCol,
            this.NewSaveCol,
            this.NewDateCol});
            this.MT_DGV.Location = new System.Drawing.Point(12, 240);
            this.MT_DGV.Name = "MT_DGV";
            this.MT_DGV.RowHeadersVisible = false;
            this.MT_DGV.Size = new System.Drawing.Size(550, 309);
            this.MT_DGV.TabIndex = 10;
            // 
            // DateCol
            // 
            this.DateCol.HeaderText = "Date";
            this.DateCol.Name = "DateCol";
            this.DateCol.ReadOnly = true;
            this.DateCol.Width = 150;
            // 
            // Frame300Col
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Frame300Col.DefaultCellStyle = dataGridViewCellStyle1;
            this.Frame300Col.HeaderText = "Frame 300 Seed";
            this.Frame300Col.Name = "Frame300Col";
            this.Frame300Col.ReadOnly = true;
            this.Frame300Col.Width = 120;
            // 
            // SaveFrameCol
            // 
            this.SaveFrameCol.HeaderText = "Save Frame";
            this.SaveFrameCol.Name = "SaveFrameCol";
            this.SaveFrameCol.ReadOnly = true;
            // 
            // NewSaveCol
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F);
            this.NewSaveCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.NewSaveCol.HeaderText = "New Save Parameter";
            this.NewSaveCol.Name = "NewSaveCol";
            this.NewSaveCol.ReadOnly = true;
            this.NewSaveCol.Width = 150;
            // 
            // NewDateCol
            // 
            this.NewDateCol.HeaderText = "New Date";
            this.NewDateCol.Name = "NewDateCol";
            this.NewDateCol.ReadOnly = true;
            this.NewDateCol.Visible = false;
            this.NewDateCol.Width = 150;
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.StopButton.Location = new System.Drawing.Point(157, 203);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(139, 31);
            this.StopButton.TabIndex = 11;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // XY_MTButton
            // 
            this.XY_MTButton.AutoSize = true;
            this.XY_MTButton.Checked = true;
            this.XY_MTButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.XY_MTButton.Location = new System.Drawing.Point(60, 45);
            this.XY_MTButton.Name = "XY_MTButton";
            this.XY_MTButton.Size = new System.Drawing.Size(39, 18);
            this.XY_MTButton.TabIndex = 12;
            this.XY_MTButton.TabStop = true;
            this.XY_MTButton.Text = "XY";
            this.XY_MTButton.UseVisualStyleBackColor = true;
            // 
            // ORAS_MTButton
            // 
            this.ORAS_MTButton.AutoSize = true;
            this.ORAS_MTButton.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ORAS_MTButton.Location = new System.Drawing.Point(135, 45);
            this.ORAS_MTButton.Name = "ORAS_MTButton";
            this.ORAS_MTButton.Size = new System.Drawing.Size(53, 18);
            this.ORAS_MTButton.TabIndex = 13;
            this.ORAS_MTButton.Text = "ORAS";
            this.ORAS_MTButton.UseVisualStyleBackColor = true;
            // 
            // Frame300_Label
            // 
            this.Frame300_Label.AutoSize = true;
            this.Frame300_Label.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Frame300_Label.Location = new System.Drawing.Point(22, 97);
            this.Frame300_Label.Name = "Frame300_Label";
            this.Frame300_Label.Size = new System.Drawing.Size(105, 14);
            this.Frame300_Label.TabIndex = 14;
            this.Frame300_Label.Text = "Frame 300 Seed";
            // 
            // SettingsGroup
            // 
            this.SettingsGroup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SettingsGroup.Controls.Add(this.ORAS_MTButton);
            this.SettingsGroup.Controls.Add(this.Frame300);
            this.SettingsGroup.Controls.Add(this.XY_MTButton);
            this.SettingsGroup.Controls.Add(this.Frame300_Label);
            this.SettingsGroup.Controls.Add(this.CurrentSavePar);
            this.SettingsGroup.Controls.Add(this.SavePar_Label);
            this.SettingsGroup.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SettingsGroup.Location = new System.Drawing.Point(302, 12);
            this.SettingsGroup.Name = "SettingsGroup";
            this.SettingsGroup.Size = new System.Drawing.Size(260, 222);
            this.SettingsGroup.TabIndex = 16;
            this.SettingsGroup.TabStop = false;
            this.SettingsGroup.Text = "Settings";
            // 
            // Frame300
            // 
            this.Frame300.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Frame300.Location = new System.Drawing.Point(135, 93);
            this.Frame300.Mask = "AAAAAAAA";
            this.Frame300.Name = "Frame300";
            this.Frame300.Size = new System.Drawing.Size(64, 22);
            this.Frame300.TabIndex = 15;
            this.Frame300.Text = "00000000";
            this.Frame300.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Frame300.Value = ((uint)(0u));
            // 
            // CurrentSavePar
            // 
            this.CurrentSavePar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CurrentSavePar.Location = new System.Drawing.Point(135, 144);
            this.CurrentSavePar.Mask = "AAAAAAAA";
            this.CurrentSavePar.Name = "CurrentSavePar";
            this.CurrentSavePar.Size = new System.Drawing.Size(64, 22);
            this.CurrentSavePar.TabIndex = 7;
            this.CurrentSavePar.Text = "00000000";
            this.CurrentSavePar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CurrentSavePar.Value = ((uint)(0u));
            // 
            // PreferencesGroup
            // 
            this.PreferencesGroup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PreferencesGroup.Controls.Add(this.TargetTime);
            this.PreferencesGroup.Controls.Add(this.SpecificTime);
            this.PreferencesGroup.Controls.Add(this.Target);
            this.PreferencesGroup.Controls.Add(this.TargetDate);
            this.PreferencesGroup.Controls.Add(this.RTC_Label);
            this.PreferencesGroup.Controls.Add(this.TargetSeed_Label);
            this.PreferencesGroup.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.PreferencesGroup.Location = new System.Drawing.Point(12, 12);
            this.PreferencesGroup.Name = "PreferencesGroup";
            this.PreferencesGroup.Size = new System.Drawing.Size(284, 185);
            this.PreferencesGroup.TabIndex = 17;
            this.PreferencesGroup.TabStop = false;
            this.PreferencesGroup.Text = "Preferences";
            // 
            // TargetTime
            // 
            this.TargetTime.Enabled = false;
            this.TargetTime.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TargetTime.Location = new System.Drawing.Point(145, 91);
            this.TargetTime.MaxLength = 9;
            this.TargetTime.Name = "TargetTime";
            this.TargetTime.Size = new System.Drawing.Size(96, 22);
            this.TargetTime.TabIndex = 11;
            this.TargetTime.Text = "00:00:00";
            // 
            // SpecificTime
            // 
            this.SpecificTime.AutoSize = true;
            this.SpecificTime.Location = new System.Drawing.Point(25, 93);
            this.SpecificTime.Name = "SpecificTime";
            this.SpecificTime.Size = new System.Drawing.Size(103, 18);
            this.SpecificTime.TabIndex = 10;
            this.SpecificTime.Text = "Target Time";
            this.SpecificTime.UseVisualStyleBackColor = true;
            this.SpecificTime.CheckedChanged += new System.EventHandler(this.SpecificTime_CheckedChanged);
            // 
            // Target
            // 
            this.Target.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Target.Location = new System.Drawing.Point(145, 140);
            this.Target.Mask = "AAAAAAAA";
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(64, 22);
            this.Target.TabIndex = 8;
            this.Target.Text = "00000000";
            this.Target.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Target.Value = ((uint)(0u));
            // 
            // MTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(574, 561);
            this.Controls.Add(this.PreferencesGroup);
            this.Controls.Add(this.SettingsGroup);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.MT_DGV);
            this.Controls.Add(this.FindButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(590, 600);
            this.MinimumSize = new System.Drawing.Size(590, 600);
            this.Name = "MTForm";
            this.Text = "MT RNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MTForm_FormClosing_1);
            this.Load += new System.EventHandler(this.MTForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MT_DGV)).EndInit();
            this.SettingsGroup.ResumeLayout(false);
            this.SettingsGroup.PerformLayout();
            this.PreferencesGroup.ResumeLayout(false);
            this.PreferencesGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox TargetDate;
        private System.Windows.Forms.Label RTC_Label;
        private System.Windows.Forms.Label SavePar_Label;
        private HexBox CurrentSavePar;
        private HexBox Target;
        private System.Windows.Forms.Label TargetSeed_Label;
        private System.Windows.Forms.DataGridView MT_DGV;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.RadioButton XY_MTButton;
        private System.Windows.Forms.RadioButton ORAS_MTButton;
        private System.Windows.Forms.Label Frame300_Label;
        private HexBox Frame300;
        private System.Windows.Forms.GroupBox SettingsGroup;
        private System.Windows.Forms.GroupBox PreferencesGroup;
        private System.Windows.Forms.TextBox TargetTime;
        private System.Windows.Forms.CheckBox SpecificTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frame300Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaveFrameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewSaveCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewDateCol;
    }
}