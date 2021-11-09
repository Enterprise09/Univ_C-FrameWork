
namespace B_Notepad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기NtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장StoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장AtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기XtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.찾기FtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.잘라내기TStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자동줄바꿈WtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴FtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.fdText = new System.Windows.Forms.FontDialog();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.붙여넣기PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다음찾기NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.모두선택AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시간날짜DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.서식OToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(800, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기NtoolStripMenuItem,
            this.열기OtoolStripMenuItem,
            this.저장StoolStripMenuItem,
            this.다른이름으로저장AtoolStripMenuItem,
            this.toolStripSeparator1,
            this.끝내기XtoolStripMenuItem});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(F)";
            // 
            // 새로만들기NtoolStripMenuItem
            // 
            this.새로만들기NtoolStripMenuItem.Name = "새로만들기NtoolStripMenuItem";
            this.새로만들기NtoolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.새로만들기NtoolStripMenuItem.Text = "새로 만들기(N)";
            this.새로만들기NtoolStripMenuItem.Click += new System.EventHandler(this.새로만들기NtoolStripMenuItem_Click);
            // 
            // 열기OtoolStripMenuItem
            // 
            this.열기OtoolStripMenuItem.Name = "열기OtoolStripMenuItem";
            this.열기OtoolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.열기OtoolStripMenuItem.Text = "열기(O)...";
            this.열기OtoolStripMenuItem.Click += new System.EventHandler(this.열기OtoolStripMenuItem_Click);
            // 
            // 저장StoolStripMenuItem
            // 
            this.저장StoolStripMenuItem.Name = "저장StoolStripMenuItem";
            this.저장StoolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.저장StoolStripMenuItem.Text = "저장(S)";
            this.저장StoolStripMenuItem.Click += new System.EventHandler(this.저장StoolStripMenuItem_Click);
            // 
            // 다른이름으로저장AtoolStripMenuItem
            // 
            this.다른이름으로저장AtoolStripMenuItem.Name = "다른이름으로저장AtoolStripMenuItem";
            this.다른이름으로저장AtoolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.다른이름으로저장AtoolStripMenuItem.Text = "다른 이름으로 저장(A)...";
            this.다른이름으로저장AtoolStripMenuItem.Click += new System.EventHandler(this.다른이름으로저장AtoolStripMenuItem_Click);
            // 
            // 끝내기XtoolStripMenuItem
            // 
            this.끝내기XtoolStripMenuItem.Name = "끝내기XtoolStripMenuItem";
            this.끝내기XtoolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.끝내기XtoolStripMenuItem.Text = "끝내기(X)";
            this.끝내기XtoolStripMenuItem.Click += new System.EventHandler(this.끝내기XtoolStripMenuItem_Click);
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소UToolStripMenuItem,
            this.toolStripSeparator2,
            this.잘라내기TStripMenuItem,
            this.복사ToolStripMenuItem,
            this.붙여넣기PToolStripMenuItem,
            this.삭제LToolStripMenuItem,
            this.toolStripSeparator3,
            this.찾기FtoolStripMenuItem,
            this.다음찾기NToolStripMenuItem,
            this.toolStripSeparator4,
            this.모두선택AToolStripMenuItem,
            this.시간날짜DToolStripMenuItem});
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.편집EToolStripMenuItem.Text = "편집(E)";
            // 
            // 찾기FtoolStripMenuItem
            // 
            this.찾기FtoolStripMenuItem.Name = "찾기FtoolStripMenuItem";
            this.찾기FtoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.찾기FtoolStripMenuItem.Text = "찾기(F)...";
            this.찾기FtoolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.찾기FtoolStripMenuItem.Click += new System.EventHandler(this.찾기FtoolStripMenuItem_Click);
            // 
            // 실행취소UToolStripMenuItem
            // 
            this.실행취소UToolStripMenuItem.Name = "실행취소UToolStripMenuItem";
            this.실행취소UToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.실행취소UToolStripMenuItem.Text = "실행 취소(U)";
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.복사ToolStripMenuItem.Text = "복사";
            // 
            // 잘라내기TStripMenuItem
            // 
            this.잘라내기TStripMenuItem.Name = "잘라내기TStripMenuItem";
            this.잘라내기TStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.잘라내기TStripMenuItem.Text = "잘라내기(T)";
            // 
            // 서식OToolStripMenuItem
            // 
            this.서식OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자동줄바꿈WtoolStripMenuItem,
            this.글꼴FtoolStripMenuItem});
            this.서식OToolStripMenuItem.Name = "서식OToolStripMenuItem";
            this.서식OToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.서식OToolStripMenuItem.Text = "서식(O)";
            // 
            // 자동줄바꿈WtoolStripMenuItem
            // 
            this.자동줄바꿈WtoolStripMenuItem.Checked = true;
            this.자동줄바꿈WtoolStripMenuItem.CheckOnClick = true;
            this.자동줄바꿈WtoolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.자동줄바꿈WtoolStripMenuItem.Name = "자동줄바꿈WtoolStripMenuItem";
            this.자동줄바꿈WtoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.자동줄바꿈WtoolStripMenuItem.Text = "자동 줄 바꿈(M)";
            // 
            // 글꼴FtoolStripMenuItem
            // 
            this.글꼴FtoolStripMenuItem.Name = "글꼴FtoolStripMenuItem";
            this.글꼴FtoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.글꼴FtoolStripMenuItem.Text = "글꼴(F)";
            this.글꼴FtoolStripMenuItem.Click += new System.EventHandler(this.글꼴FtoolStripMenuItem_Click);
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Location = new System.Drawing.Point(0, 24);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNote.Size = new System.Drawing.Size(800, 426);
            this.txtNote.TabIndex = 1;
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            // 
            // sfdFile
            // 
            this.sfdFile.FileName = "텍스트";
            this.sfdFile.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // 붙여넣기PToolStripMenuItem
            // 
            this.붙여넣기PToolStripMenuItem.Name = "붙여넣기PToolStripMenuItem";
            this.붙여넣기PToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.붙여넣기PToolStripMenuItem.Text = "붙여넣기(P)";
            // 
            // 삭제LToolStripMenuItem
            // 
            this.삭제LToolStripMenuItem.Name = "삭제LToolStripMenuItem";
            this.삭제LToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.삭제LToolStripMenuItem.Text = "삭제(L)";
            // 
            // 다음찾기NToolStripMenuItem
            // 
            this.다음찾기NToolStripMenuItem.Name = "다음찾기NToolStripMenuItem";
            this.다음찾기NToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.다음찾기NToolStripMenuItem.Text = "다음 찾기(N)";
            // 
            // 모두선택AToolStripMenuItem
            // 
            this.모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem";
            this.모두선택AToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.모두선택AToolStripMenuItem.Text = "모두선택(A)";
            // 
            // 시간날짜DToolStripMenuItem
            // 
            this.시간날짜DToolStripMenuItem.Name = "시간날짜DToolStripMenuItem";
            this.시간날짜DToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.시간날짜DToolStripMenuItem.Text = "시간/날짜(D)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.Text = "메모장";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기NtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장StoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장AtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기XtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자동줄바꿈WtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴FtoolStripMenuItem;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.FontDialog fdText;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.ToolStripMenuItem 찾기FtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실행취소UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기TStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다음찾기NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 모두선택AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시간날짜DToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

