using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_Image
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int imgCount = 0;

        private void Form3_Load(object sender, EventArgs e)
        {
            this.picImg.Image = (Image)this.imgList.Images[0];
            imgCount = this.imgList.Images.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            imgCount--;
            if(imgCount < 0)
            {
                imgCount = this.imgList.Images.Count - 1;
            }
            this.picImg.Image = (Image)imgList.Images[imgCount];
        }
    }
}
