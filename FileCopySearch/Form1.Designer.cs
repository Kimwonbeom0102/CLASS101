namespace FileCopySearch
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_SourcePath = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_SearchPath = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_DestPath = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_Serach = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_ExcuteResult = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SourcePath
            // 
            this.btn_SourcePath.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_SourcePath.Location = new System.Drawing.Point(3, 0);
            this.btn_SourcePath.Name = "btn_SourcePath";
            this.btn_SourcePath.Size = new System.Drawing.Size(400, 35);
            this.btn_SourcePath.TabIndex = 0;
            this.btn_SourcePath.Text = "검색";
            this.btn_SourcePath.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(399, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(411, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "복사";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(169, 178);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(475, 112);
            this.listBox1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(164, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 34);
            this.panel3.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_SearchPath);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Location = new System.Drawing.Point(5, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 30);
            this.panel6.TabIndex = 4;
            // 
            // lbl_SearchPath
            // 
            this.lbl_SearchPath.AutoSize = true;
            this.lbl_SearchPath.Font = new System.Drawing.Font("굴림", 12F);
            this.lbl_SearchPath.Location = new System.Drawing.Point(146, 6);
            this.lbl_SearchPath.Name = "lbl_SearchPath";
            this.lbl_SearchPath.Size = new System.Drawing.Size(113, 16);
            this.lbl_SearchPath.TabIndex = 8;
            this.lbl_SearchPath.Text = "검색 경로 입력";
            this.lbl_SearchPath.Click += new System.EventHandler(this.lbl_SearchPath_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Search);
            this.panel1.Location = new System.Drawing.Point(400, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 30);
            this.panel1.TabIndex = 5;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Font = new System.Drawing.Font("굴림", 12F);
            this.lbl_Search.Location = new System.Drawing.Point(146, 6);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(113, 16);
            this.lbl_Search.TabIndex = 9;
            this.lbl_Search.Text = "원본 경로 입력";
            this.lbl_Search.Click += new System.EventHandler(this.lbl_Search_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_DestPath);
            this.panel2.Location = new System.Drawing.Point(400, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 31);
            this.panel2.TabIndex = 6;
            // 
            // lbl_DestPath
            // 
            this.lbl_DestPath.AutoSize = true;
            this.lbl_DestPath.Font = new System.Drawing.Font("굴림", 12F);
            this.lbl_DestPath.Location = new System.Drawing.Point(146, 5);
            this.lbl_DestPath.Name = "lbl_DestPath";
            this.lbl_DestPath.Size = new System.Drawing.Size(113, 16);
            this.lbl_DestPath.TabIndex = 11;
            this.lbl_DestPath.Text = "대상 경로 입력";
            this.lbl_DestPath.Click += new System.EventHandler(this.lbl_DestPath_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(168, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(474, 36);
            this.panel5.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(200, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "검색 결과";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F);
            this.label5.Location = new System.Drawing.Point(201, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "실행 결과";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(169, 296);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(474, 40);
            this.panel7.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(164, 75);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(474, 34);
            this.panel8.TabIndex = 7;
            // 
            // btn_Copy
            // 
            this.btn_Copy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Copy.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Copy.Location = new System.Drawing.Point(0, 427);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(810, 23);
            this.btn_Copy.TabIndex = 10;
            this.btn_Copy.Text = "복사";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btn_Serach
            // 
            this.btn_Serach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Serach.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Serach.Location = new System.Drawing.Point(0, 404);
            this.btn_Serach.Name = "btn_Serach";
            this.btn_Serach.Size = new System.Drawing.Size(810, 23);
            this.btn_Serach.TabIndex = 11;
            this.btn_Serach.Text = "검색";
            this.btn_Serach.UseVisualStyleBackColor = true;
            this.btn_Serach.Click += new System.EventHandler(this.btn_Serach_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(170, 374);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(472, 1);
            this.panel4.TabIndex = 12;
            // 
            // lbl_ExcuteResult
            // 
            this.lbl_ExcuteResult.AutoSize = true;
            this.lbl_ExcuteResult.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_ExcuteResult.Location = new System.Drawing.Point(298, 355);
            this.lbl_ExcuteResult.Name = "lbl_ExcuteResult";
            this.lbl_ExcuteResult.Size = new System.Drawing.Size(0, 16);
            this.lbl_ExcuteResult.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.lbl_ExcuteResult);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_Serach);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_SourcePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SourcePath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_SearchPath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Label lbl_DestPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Serach;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_ExcuteResult;
    }
}

