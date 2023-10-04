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
            this.okBtn = new Telerik.WinControls.UI.RadButton();
            this.github__Btn = new Telerik.WinControls.UI.RadButton();
            this.aboutTxt = new System.Windows.Forms.RichTextBox();
            this.txtColor__Btn = new Telerik.WinControls.UI.RadButton();
            this.radColorDialog1 = new Telerik.WinControls.RadColorDialog();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.okBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.github__Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor__Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(258, 376);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(110, 51);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.ThemeName = "Fluent";
            this.okBtn.Click += new System.EventHandler(this.RadButton1_Click);
            // 
            // github__Btn
            // 
            this.github__Btn.Location = new System.Drawing.Point(12, 376);
            this.github__Btn.Name = "github__Btn";
            this.github__Btn.Size = new System.Drawing.Size(130, 51);
            this.github__Btn.TabIndex = 1;
            this.github__Btn.Text = "My Github";
            this.github__Btn.ThemeName = "Fluent";
            this.github__Btn.Click += new System.EventHandler(this.RadButton2_Click);
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
            this.aboutTxt.Text = "Application Name: YP Windows Manager\n\nApplication Version: 3.0.0 (Beta)\n\nCompany " +
    "Name: YP(You Pc)\n\nDeveloper: Alireza Abbasi\n\nApplication Icons: icons8";
            // 
            // txtColor__Btn
            // 
            this.txtColor__Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtColor__Btn.ForeColor = System.Drawing.Color.Black;
            this.txtColor__Btn.Location = new System.Drawing.Point(304, 6);
            this.txtColor__Btn.Name = "txtColor__Btn";
            this.txtColor__Btn.Size = new System.Drawing.Size(64, 19);
            this.txtColor__Btn.TabIndex = 4;
            this.txtColor__Btn.Text = "Text color";
            this.txtColor__Btn.ThemeName = "Fluent";
            this.txtColor__Btn.Click += new System.EventHandler(this.RadButton3_Click);
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
            this.Controls.Add(this.txtColor__Btn);
            this.Controls.Add(this.aboutTxt);
            this.Controls.Add(this.github__Btn);
            this.Controls.Add(this.okBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "aboutFrm";
            this.Opacity = 0.98D;
            this.Text = "About";
            this.ThemeName = "Fluent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.okBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.github__Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor__Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton okBtn;
        private Telerik.WinControls.UI.RadButton github__Btn;
        private System.Windows.Forms.RichTextBox aboutTxt;
        private Telerik.WinControls.UI.RadButton txtColor__Btn;
        private Telerik.WinControls.RadColorDialog radColorDialog1;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
    }
}