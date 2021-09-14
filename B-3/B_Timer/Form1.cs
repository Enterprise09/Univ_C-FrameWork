using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace B_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int CountOrgNum = 0;

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(CountOrgNum < 1)
            {
                this.Timer.Enabled = false;
                this.txtNum.ReadOnly = false;
                this.txtNum.Text = "";
                this.txtCountDown.Text = "";
                MessageBox.Show("펑", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.txtCountDown.Text = Convert.ToString(CountOrgNum);
                CountOrgNum--;                
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (intCheck())
            {
                CountOrgNum = Convert.ToInt32(this.txtNum.Text);
                this.txtNum.ReadOnly = true;
                this.Timer.Enabled = true;
            }
        }

        private bool intCheck()
        {
            if (Information.IsNumeric(this.txtNum.Text))
                return true;
            else
            {
                MessageBox.Show("숫자를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
