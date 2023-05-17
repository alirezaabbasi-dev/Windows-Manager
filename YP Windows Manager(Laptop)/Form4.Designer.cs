namespace YP_Windows_Manager_Computer_
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.radProgressBar1.Location = new System.Drawing.Point(12, 12);
            this.radProgressBar1.Name = "radProgressBar1";
            // 
            // 
            // 
            this.radProgressBar1.RootElement.AccessibleDescription = "Checking... .";
            this.radProgressBar1.RootElement.AccessibleName = "Checking... .";
            this.radProgressBar1.Size = new System.Drawing.Size(515, 51);
            this.radProgressBar1.TabIndex = 0;
            this.radProgressBar1.ThemeName = "Fluent";
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.radButton1.ForeColor = System.Drawing.Color.Black;
            this.radButton1.Location = new System.Drawing.Point(194, 80);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(153, 56);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Check";
            this.radButton1.ThemeName = "FluentDark";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // ugToolStripMenuItem
            // 
            this.ugToolStripMenuItem.Name = "ugToolStripMenuItem";
            this.ugToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ugToolStripMenuItem.Size = new System.Drawing.Size(33, 20);
            this.ugToolStripMenuItem.Text = "ug";
            this.ugToolStripMenuItem.Visible = false;
            this.ugToolStripMenuItem.Click += new System.EventHandler(this.ugToolStripMenuItem_Click);
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Enabled = true;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 202);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.radProgressBar1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Opacity = 0.95D;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Health Checker";
            this.ThemeName = "Fluent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ugToolStripMenuItem;
        private System.Windows.Forms.Timer timer5;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private System.Windows.Forms.Timer timer6;
    }
}