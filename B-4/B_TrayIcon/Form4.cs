using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_TrayIcon
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void VisibleChange(bool FormVisible, bool TrayIconVisible)
        {
            this.Visible = FormVisible;
            this.nfiTray.Visible = TrayIconVisible;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VisibleChange(false, true);
        }

        private void btnTray_Click(object sender, EventArgs e)
        {
            VisibleChange(false, true);
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            VisibleChange(false, true);
        }

        private void nfiTray_DoubleClick(object sender, EventArgs e)
        {
            VisibleChange(true, false);
        }

        private void 폼보이기toolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(true, false);
        }

        private void 종료toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.nfiTray.Visible = false;
            Application.ExitThread();
        }
    }
}
