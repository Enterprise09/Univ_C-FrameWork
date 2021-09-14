using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_Progress
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int Num = 0;
        string OrgStr = "";

        private void btnRun_Click(object sender, EventArgs e)
        {
            this.Timer.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            OrgStr = this.lblStatus.Text;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Num++;
            if(Num > 100)
            {
                this.Timer.Enabled = false;
                return;
            }
            this.pbStaus.Value = Num;
            this.lblStatus.Text = OrgStr + " : " + Num.ToString() + "%";
        }
    }
}
