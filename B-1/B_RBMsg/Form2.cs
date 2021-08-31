using System;
using System.Windows.Forms;

namespace B_RBMsg
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        MessageBoxButtons mbb;
        MessageBoxIcon mbi;

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (this.rbOk.Checked == true)
                mbb = MessageBoxButtons.OK;
            else if (this.rbOkCancel.Checked == true)
                mbb = MessageBoxButtons.OKCancel;
            else if (this.rbYesNo.Checked == true)
                mbb = MessageBoxButtons.YesNo;

            if (this.rbError.Checked == true)
                mbi = MessageBoxIcon.Error;
            else if (this.rbInformation.Checked == true)
                mbi = MessageBoxIcon.Information;
            else if (this.rbQuestion.Checked == true)
                mbi = MessageBoxIcon.Question;

            MessageBox.Show("메시지 박스를 확인 하세요", "알림", mbb, mbi);
        }
    }
}
