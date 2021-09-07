using System;
using System.Windows.Forms;

namespace B_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string OrgStr = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = this.lblResult.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this.txtList.Text != "")
            {
                lbView.Items.Add(this.txtList.Text);
                this.txtList.Text = "";
            }
            else
            {
                MessageBox.Show("아이템을 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtList.Focus();
            }
        }

        private void lbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResult.Text = OrgStr + this.lbView.SelectedItem.ToString();
        }

        private void txtList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)   
            {
                e.Handled = true;
                this.btnAdd_Click(sender, e);
            }
        }
    }
}
