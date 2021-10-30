
namespace TinyFinder.Subforms.Profile_Manager
{
    partial class Manager
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
            this.ProfileList = new System.Windows.Forms.DataGridView();
            this.Name_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seed_Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileList)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfileList
            // 
            this.ProfileList.AllowUserToAddRows = false;
            this.ProfileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_Col,
            this.Ver_Col,
            this.Year_Col,
            this.Seed_Col});
            this.ProfileList.Location = new System.Drawing.Point(12, 12);
            this.ProfileList.Name = "ProfileList";
            this.ProfileList.RowHeadersVisible = false;
            this.ProfileList.Size = new System.Drawing.Size(466, 393);
            this.ProfileList.TabIndex = 0;
            // 
            // Name_Col
            // 
            this.Name_Col.HeaderText = "Name";
            this.Name_Col.Name = "Name_Col";
            this.Name_Col.ReadOnly = true;
            // 
            // Ver_Col
            // 
            this.Ver_Col.HeaderText = "Version";
            this.Ver_Col.Name = "Ver_Col";
            this.Ver_Col.ReadOnly = true;
            // 
            // Year_Col
            // 
            this.Year_Col.HeaderText = "Year";
            this.Year_Col.Name = "Year_Col";
            this.Year_Col.ReadOnly = true;
            // 
            // Seed_Col
            // 
            this.Seed_Col.HeaderText = "TinyMT Seed";
            this.Seed_Col.Name = "Seed_Col";
            this.Seed_Col.ReadOnly = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 417);
            this.Controls.Add(this.ProfileList);
            this.Name = "Manager";
            this.Text = "Profile Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Manager_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProfileList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ver_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year_Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seed_Col;
    }
}
