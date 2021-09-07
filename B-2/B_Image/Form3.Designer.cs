
namespace B_Image
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.picImg = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(12, 12);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(500, 300);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg.TabIndex = 0;
            this.picImg.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(225, 318);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 35);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "다음";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "anna-larin-1397444-unsplash.jpg");
            this.imgList.Images.SetKeyName(1, "beach-4016082.jpg");
            this.imgList.Images.SetKeyName(2, "chipmunk-3959206.jpg");
            this.imgList.Images.SetKeyName(3, "crystal-ball-4006971.jpg");
            this.imgList.Images.SetKeyName(4, "derelict-building-4019880.jpg");
            this.imgList.Images.SetKeyName(5, "girl-3954232.jpg");
            this.imgList.Images.SetKeyName(6, "golden-gate-bridge-731207.jpg");
            this.imgList.Images.SetKeyName(7, "hiking-4024132.jpg");
            this.imgList.Images.SetKeyName(8, "landscape-3997230.jpg");
            this.imgList.Images.SetKeyName(9, "landscape-4022426.jpg");
            this.imgList.Images.SetKeyName(10, "ocean-3605547.jpg");
            this.imgList.Images.SetKeyName(11, "praline-2966091.jpg");
            this.imgList.Images.SetKeyName(12, "rails-4018457.jpg");
            this.imgList.Images.SetKeyName(13, "sea-4007309.jpg");
            this.imgList.Images.SetKeyName(14, "sky-4011511.jpg");
            this.imgList.Images.SetKeyName(15, "thunderstorm-3625405.jpg");
            this.imgList.Images.SetKeyName(16, "travel-4011026.jpg");
            this.imgList.Images.SetKeyName(17, "water-3161063.jpg");
            this.imgList.Images.SetKeyName(18, "water-4013446.jpg");
            this.imgList.Images.SetKeyName(19, "water-surface-4020177.jpg");
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 380);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "그림보기";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ImageList imgList;
    }
}

