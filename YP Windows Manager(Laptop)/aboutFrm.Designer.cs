namespace YP_Windows_Manager_Computer_
{
    partial class aboutFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutFrm));
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.aboutTxt = new System.Windows.Forms.RichTextBox();
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
            this.radButton1.Location = new System.Drawing.Point(258, 376);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 51);
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
            // aboutTxt
            // 
            this.aboutTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.aboutTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTxt.ForeColor = System.Drawing.Color.Black;
            this.aboutTxt.Location = new System.Drawing.Point(0, 0);
            this.aboutTxt.Name = "aboutTxt";
            this.aboutTxt.ReadOnly = true;
            this.aboutTxt.Size = new System.Drawing.Size(369, 285);
            this.aboutTxt.TabIndex = 3;
            this.aboutTxt.Text = "Application Name: YP Windows Manager\n\nApplication Version: 2.1.0\n\nCompany Name: Y" +
    "P(You Pc)\n\nDeveloper: Alireza Abbasi\n\nApplication Icons: icons8";
            // 
            // radButton3
            // 
            this.radButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.radButton3.ForeColor = System.Drawing.Color.Black;
            this.radButton3.Location = new System.Drawing.Point(304, 6);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(64, 19);
            this.radButton3.TabIndex = 4;
            this.radButton3.Text = "Text color";
            this.radButton3.ThemeName = "Fluent";
            this.radButton3.Click += new System.EventHandler(this.RadButton3_Click);
            // 
            // radColorDialog1
            // 
            this.radColorDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("radColorDialog1.Icon")));
            this.radColorDialog1.OldColor = System.Drawing.Color.Transparent;
            this.radColorDialog1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radColorDialog1.SelectedColor = System.Drawing.Color.Red;
            this.radColorDialog1.SelectedHslColor = Telerik.WinControls.HslColor.FromAhsl(0D, 1D, 1D);
            // 
            // aboutFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 439);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.aboutTxt);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aboutFrm";
            this.Opacity = 0.98D;
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
        private System.Windows.Forms.RichTextBox aboutTxt;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.RadColorDialog radColorDialog1;
    }
}