using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_FontControl
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tsBtnFont_Click(object sender, EventArgs e)
        {
            if(this.fontDlg.ShowDialog() == DialogResult.OK)
            {
                this.rtbText.SelectionFont = this.fontDlg.Font;
            }
        }

        private void tsBtnColor_Click(object sender, EventArgs e)
        {
            if(this.colorDlg.ShowDialog() == DialogResult.OK)
            {
                this.rtbText.SelectionColor = this.colorDlg.Color;
            }
        }
    }
}
