namespace YP_Windows_Manager_Computer_
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.radColorDialog1 = new Telerik.WinControls.RadColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(511, 376);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(130, 51);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "OK";
            this.radButton1.ThemeName = "Fluent";
            this.radButton1.Click += new System.EventHandler(this.RadButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(12, 376);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(130, 51);
            this.radButton2.TabIndex = 1;
            this.radButton2.Text = "My Github";
            this.radButton2.ThemeName = "Fluent";
            this.radButton2.Click += new System.EventHandler(this.RadButton2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(653, 341);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // radButton3
            // 
            this.radButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.radButton3.ForeColor = System.Drawing.Color.Black;
            this.radButton3.Location = new System.Drawing.Point(148, 376);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(85, 51);
            this.radButton3.TabIndex = 4;
            this.radButton3.Text = "Text color";
            this.radButton3.ThemeName = "Fluent";
            this.radButton3.Visible = false;
            this.radButton3.Click += new System.EventHandler(this.RadButton3_Click);
            // 
            // radColorDialog1
            // 
            this.radColorDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("radColorDialog1.Icon")));
            this.radColorDialog1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radColorDialog1.SelectedColor = System.Drawing.Color.Red;
            this.radColorDialog1.SelectedHslColor = Telerik.WinControls.HslColor.FromAhsl(0D, 1D, 1D);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 439);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Opacity = 0.98D;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ThemeName = "Fluent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.RadColorDialog radColorDialog1;
    }
}