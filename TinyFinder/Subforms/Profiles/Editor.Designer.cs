
namespace TinyFinder.Subforms.Profiles
{
    partial class Editor
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
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.XY_Button = new System.Windows.Forms.RadioButton();
            this.ORAS_Button = new System.Windows.Forms.RadioButton();
            this.YearEditor = new System.Windows.Forms.NumericUpDown();
            this.SeedEditor = new TinyFinder.HexBox();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YearEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(120, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(32, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(32, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Seed";
            // 
            // XY_Button
            // 
            this.XY_Button.AutoSize = true;
            this.XY_Button.Location = new System.Drawing.Point(120, 80);
            this.XY_Button.Name = "XY_Button";
            this.XY_Button.Size = new System.Drawing.Size(39, 17);
            this.XY_Button.TabIndex = 5;
            this.XY_Button.TabStop = true;
            this.XY_Button.Text = "XY";
            this.XY_Button.UseVisualStyleBackColor = true;
            // 
            // ORAS_Button
            // 
            this.ORAS_Button.AutoSize = true;
            this.ORAS_Button.Location = new System.Drawing.Point(165, 80);
            this.ORAS_Button.Name = "ORAS_Button";
            this.ORAS_Button.Size = new System.Drawing.Size(55, 17);
            this.ORAS_Button.TabIndex = 6;
            this.ORAS_Button.TabStop = true;
            this.ORAS_Button.Text = "ORAS";
            this.ORAS_Button.UseVisualStyleBackColor = true;
            // 
            // YearEditor
            // 
            this.YearEditor.Location = new System.Drawing.Point(120, 124);
            this.YearEditor.Maximum = new decimal(new int[] {
            2080,
            0,
            0,
            0});
            this.YearEditor.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.YearEditor.Name = "YearEditor";
            this.YearEditor.Size = new System.Drawing.Size(65, 20);
            this.YearEditor.TabIndex = 7;
            this.YearEditor.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // SeedEditor
            // 
            this.SeedEditor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SeedEditor.Location = new System.Drawing.Point(120, 169);
            this.SeedEditor.Mask = "AAAAAAAA";
            this.SeedEditor.Name = "SeedEditor";
            this.SeedEditor.Size = new System.Drawing.Size(63, 22);
            this.SeedEditor.TabIndex = 8;
            this.SeedEditor.Text = "00000000";
            this.SeedEditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SeedEditor.Value = ((uint)(0u));
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.save.Location = new System.Drawing.Point(74, 214);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(123, 37);
            this.save.TabIndex = 9;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 273);
            this.Controls.Add(this.save);
            this.Controls.Add(this.SeedEditor);
            this.Controls.Add(this.YearEditor);
            this.Controls.Add(this.ORAS_Button);
            this.Controls.Add(this.XY_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Name = "Editor";
            this.Text = "Profile Editor";
            ((System.ComponentModel.ISupportInitialize)(this.YearEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton XY_Button;
        private System.Windows.Forms.RadioButton ORAS_Button;
        private System.Windows.Forms.NumericUpDown YearEditor;
        private HexBox SeedEditor;
        private System.Windows.Forms.Button save;
    }
}