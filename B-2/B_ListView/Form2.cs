using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_ListView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string strName, strAge, strWork;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TextCheck())
            {
                this.strName = txtName.Text;
                this.strAge = txtAge.Text;
                this.strWork = txtWork.Text;

                txtName.Text = "";
                txtAge.Text = "";
                txtWork.Text = "";
            }
            else return;
            ListViewItem lvi = new ListViewItem(new string[] { strName, strAge, strWork });
            this.lvView.Items.Add(lvi);
        }

        private void txtWork_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                e.Handled = true;
                this.btnAdd_Click(sender, e);
            }
        }

        private bool TextCheck()
        {
            if(this.txtName.Text != "" && this.txtAge.Text != "" && this.txtWork.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void lvView_Click(object sender, EventArgs e)
        {
            if (lvView.SelectedItems.Count == 0)
            {
                MessageBox.Show("아이템을 선택하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string strInfo = "이름 : " + lvView.SelectedItems[0].SubItems[0].Text +
                    "\n나이 : " + lvView.SelectedItems[0].SubItems[1].Text +
                    "\n직업 : " + lvView.SelectedItems[0].SubItems[2].Text;
                MessageBox.Show(strInfo, "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
