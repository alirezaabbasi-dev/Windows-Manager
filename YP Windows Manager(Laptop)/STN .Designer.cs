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
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.bootStatus = new System.Windows.Forms.Label();
            this.activeBtn = new Telerik.WinControls.UI.RadRadioButton();
            this.deactiveBtn = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.activeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deactiveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // bootStatus
            // 
            this.bootStatus.AutoSize = true;
            this.bootStatus.Location = new System.Drawing.Point(9, 144);
            this.bootStatus.Name = "bootStatus";
            this.bootStatus.Size = new System.Drawing.Size(0, 17);
            this.bootStatus.TabIndex = 2;
            // 
            // activeBtn
            // 
            this.activeBtn.AutoSize = false;
            this.activeBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeBtn.Image = global::YP_Windows_Manager.Properties.Resources.icons8_play_96;
            this.activeBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.activeBtn.Location = new System.Drawing.Point(12, 12);
            this.activeBtn.Name = "activeBtn";
            this.activeBtn.Size = new System.Drawing.Size(296, 34);
            this.activeBtn.TabIndex = 3;
            this.activeBtn.TabStop = false;
            this.activeBtn.Text = "Start the program after logging in";
            this.activeBtn.ThemeName = "Fluent";
            this.activeBtn.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton1_ToggleStateChanged);
            // 
            // deactiveBtn
            // 
            this.deactiveBtn.AutoSize = false;
            this.deactiveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactiveBtn.Image = global::YP_Windows_Manager.Properties.Resources.icons8_pause_96;
            this.deactiveBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.deactiveBtn.Location = new System.Drawing.Point(12, 52);
            this.deactiveBtn.Name = "deactiveBtn";
            this.deactiveBtn.Size = new System.Drawing.Size(296, 34);
            this.deactiveBtn.TabIndex = 4;
            this.deactiveBtn.TabStop = false;
            this.deactiveBtn.Text = "The program does not start after login";
            this.deactiveBtn.ThemeName = "Fluent";
            this.deactiveBtn.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.radRadioButton2_ToggleStateChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 223);
            this.Controls.Add(this.deactiveBtn);
            this.Controls.Add(this.activeBtn);
            this.Controls.Add(this.bootStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YP Windows Manager Settings";
            this.ThemeName = "Fluent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deactiveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private System.Windows.Forms.Label bootStatus;
        private Telerik.WinControls.UI.RadRadioButton activeBtn;
        private Telerik.WinControls.UI.RadRadioButton deactiveBtn;
    }
}