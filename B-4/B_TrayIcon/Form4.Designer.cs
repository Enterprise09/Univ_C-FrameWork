
namespace B_TrayIcon
{
    partial class Form4
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnTray = new System.Windows.Forms.Button();
            this.nfiTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.폼보이기toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTray
            // 
            this.btnTray.Location = new System.Drawing.Point(0, 0);
            this.btnTray.Name = "btnTray";
            this.btnTray.Size = new System.Drawing.Size(91, 23);
            this.btnTray.TabIndex = 0;
            this.btnTray.Text = "트레이 이동";
            this.btnTray.UseVisualStyleBackColor = true;
            this.btnTray.Click += new System.EventHandler(this.btnTray_Click);
            // 
            // nfiTray
            // 
            this.nfiTray.ContextMenuStrip = this.cmsMenu;
            this.nfiTray.Text = "트레이 아이콘";
            this.nfiTray.Visible = true;
            this.nfiTray.DoubleClick += new System.EventHandler(this.nfiTray_DoubleClick);
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폼보이기toolStripMenuItem,
            this.종료toolStripMenuItem});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(183, 48);
            // 
            // 폼보이기toolStripMenuItem
            // 
            this.폼보이기toolStripMenuItem.Name = "폼보이기toolStripMenuItem";
            this.폼보이기toolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.폼보이기toolStripMenuItem.Text = "toolStripMenuItem1";
            this.폼보이기toolStripMenuItem.Click += new System.EventHandler(this.폼보이기toolStripMenuItem_Click);
            // 
            // 종료toolStripMenuItem
            // 
            this.종료toolStripMenuItem.Name = "종료toolStripMenuItem";
            this.종료toolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.종료toolStripMenuItem.Text = "toolStripMenuItem1";
            this.종료toolStripMenuItem.Click += new System.EventHandler(this.종료toolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTray);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "트레이 아이콘";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTray;
        private System.Windows.Forms.NotifyIcon nfiTray;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem 폼보이기toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료toolStripMenuItem;
    }
}

