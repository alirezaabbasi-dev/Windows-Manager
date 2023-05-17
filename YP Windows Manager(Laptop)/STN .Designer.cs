namespace YP_Windows_Manager_Computer_
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton2
            // 
            this.radButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.radButton2.ForeColor = System.Drawing.Color.Black;
            this.radButton2.Image = global::YP_Windows_Manager_Computer_.Properties.Resources.icons8_pause_96;
            this.radButton2.Location = new System.Drawing.Point(269, 12);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(251, 101);
            this.radButton2.TabIndex = 1;
            this.radButton2.Text = "The program does not start after login";
            this.radButton2.ThemeName = "FluentDark";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.radButton1.ForeColor = System.Drawing.Color.Black;
            this.radButton1.Image = global::YP_Windows_Manager_Computer_.Properties.Resources.icons8_play_96;
            this.radButton1.Location = new System.Drawing.Point(12, 12);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(251, 101);
            this.radButton1.TabIndex = 0;
            this.radButton1.Text = "Start the program after logging in";
            this.radButton1.ThemeName = "FluentDark";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 241);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Opacity = 0.99D;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YP Windows Manager Settings";
            this.ThemeName = "Fluent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
    }
}