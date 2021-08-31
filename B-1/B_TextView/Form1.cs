using System;
using System.Windows.Forms;

namespace B_TextView
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

        private bool TextCheck()
        {
            if (this.txtEdit.Text != "") return true;
            else
            {
                MessageBox.Show("텍스트를 입력하세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEdit.Focus();
                return false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(TextCheck() == true)
            {
                this.lblResult.Text = OrgStr + this.txtEdit.Text;
            }
        }
    }
}
