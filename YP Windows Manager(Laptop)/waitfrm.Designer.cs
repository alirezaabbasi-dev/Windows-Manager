namespace YP_Windows_Manager_Computer_
{
    partial class waitfrm
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.fadingRingWaitingBarIndicatorElement1 = new Telerik.WinControls.UI.FadingRingWaitingBarIndicatorElement();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yp01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.radLabel1.Location = new System.Drawing.Point(119, 99);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(280, 41);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "YP Windows Manager";
            this.radLabel1.ThemeName = "FluentDark";
            this.radLabel1.Visible = false;
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.Location = new System.Drawing.Point(12, 146);
            this.radWaitingBar1.Name = "radWaitingBar1";
            this.radWaitingBar1.Size = new System.Drawing.Size(488, 60);
            this.radWaitingBar1.TabIndex = 1;
            this.radWaitingBar1.Text = "radWaitingBar1";
            this.radWaitingBar1.ThemeName = "FluentDark";
            this.radWaitingBar1.WaitingDirection = Telerik.WinControls.ProgressOrientation.Left;
            this.radWaitingBar1.WaitingIndicators.Add(this.fadingRingWaitingBarIndicatorElement1);
            this.radWaitingBar1.WaitingIndicatorSize = new System.Drawing.Size(100, 14);
            this.radWaitingBar1.WaitingSpeed = 100;
            this.radWaitingBar1.WaitingStep = 2;
            this.radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.FadingRing;
            ((Telerik.WinControls.UI.RadWaitingBarElement)(this.radWaitingBar1.GetChildAt(0))).WaitingIndicatorSize = new System.Drawing.Size(100, 14);
            ((Telerik.WinControls.UI.RadWaitingBarElement)(this.radWaitingBar1.GetChildAt(0))).WaitingDirection = Telerik.WinControls.ProgressOrientation.Left;
            ((Telerik.WinControls.UI.RadWaitingBarElement)(this.radWaitingBar1.GetChildAt(0))).WaitingSpeed = 100;
            ((Telerik.WinControls.UI.RadWaitingBarElement)(this.radWaitingBar1.GetChildAt(0))).WaitingStep = 2;
            ((Telerik.WinControls.UI.WaitingBarContentElement)(this.radWaitingBar1.GetChildAt(0).GetChildAt(0))).WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.FadingRing;
            ((Telerik.WinControls.UI.WaitingBarSeparatorElement)(this.radWaitingBar1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).ProgressOrientation = Telerik.WinControls.ProgressOrientation.Right;
            ((Telerik.WinControls.UI.WaitingBarSeparatorElement)(this.radWaitingBar1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Dash = false;
            // 
            // fadingRingWaitingBarIndicatorElement1
            // 
            this.fadingRingWaitingBarIndicatorElement1.Name = "fadingRingWaitingBarIndicatorElement1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radLabel2
            // 
            this.radLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.radLabel2.Location = new System.Drawing.Point(12, 255);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(344, 77);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "This program makes your computer speed gets.\r\n\r\nThis can check your computer heal" +
    "th program does.\r\n\r\nYou can to know the latest news to https://t.me/ypappchannel" +
    " see.\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::YP_Windows_Manager_Computer_.Properties.Resources.icons8_system_task_961;
            this.pictureBox1.Location = new System.Drawing.Point(12, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yp01ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(512, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // yp01ToolStripMenuItem
            // 
            this.yp01ToolStripMenuItem.Name = "yp01ToolStripMenuItem";
            this.yp01ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.yp01ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.yp01ToolStripMenuItem.Text = "yp01";
            // 
            // waitfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 477);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radWaitingBar1);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "waitfrm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "waitfrm";
            this.ThemeName = "Fluent";
            this.Load += new System.EventHandler(this.waitfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yp01ToolStripMenuItem;
        private Telerik.WinControls.UI.FadingRingWaitingBarIndicatorElement fadingRingWaitingBarIndicatorElement1;
    }
}