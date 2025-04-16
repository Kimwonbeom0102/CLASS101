namespace MetroUIManager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mtTimer = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mlTheme = new MetroFramework.Controls.MetroLabel();
            this.mlColor = new MetroFramework.Controls.MetroLabel();
            this.mlFont = new MetroFramework.Controls.MetroLabel();
            this.mcbTheme = new MetroFramework.Controls.MetroComboBox();
            this.mcbColor = new MetroFramework.Controls.MetroComboBox();
            this.mcbFont = new MetroFramework.Controls.MetroComboBox();
            this.mtNews = new MetroFramework.Controls.MetroTile();
            this.mtNetPath1 = new MetroFramework.Controls.MetroTile();
            this.mtNetPath2 = new MetroFramework.Controls.MetroTile();
            this.mtPath1 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mtPaht2 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtTimer
            // 
            this.mtTimer.ActiveControl = null;
            this.mtTimer.Location = new System.Drawing.Point(23, 178);
            this.mtTimer.Name = "mtTimer";
            this.mtTimer.Size = new System.Drawing.Size(145, 129);
            this.mtTimer.TabIndex = 0;
            this.mtTimer.Text = "Rest Timer";
            this.mtTimer.TileImage = ((System.Drawing.Image)(resources.GetObject("mtTimer.TileImage")));
            this.mtTimer.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtTimer.UseSelectable = true;
            this.mtTimer.UseTileImage = true;
            this.mtTimer.Click += new System.EventHandler(this.mtTimer_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // mlTheme
            // 
            this.mlTheme.AutoSize = true;
            this.mlTheme.Location = new System.Drawing.Point(494, 37);
            this.mlTheme.Name = "mlTheme";
            this.mlTheme.Size = new System.Drawing.Size(56, 19);
            this.mlTheme.TabIndex = 1;
            this.mlTheme.Text = "Theme :";
            // 
            // mlColor
            // 
            this.mlColor.AutoSize = true;
            this.mlColor.Location = new System.Drawing.Point(494, 72);
            this.mlColor.Name = "mlColor";
            this.mlColor.Size = new System.Drawing.Size(49, 19);
            this.mlColor.TabIndex = 2;
            this.mlColor.Text = "Color :";
            // 
            // mlFont
            // 
            this.mlFont.AutoSize = true;
            this.mlFont.Location = new System.Drawing.Point(494, 107);
            this.mlFont.Name = "mlFont";
            this.mlFont.Size = new System.Drawing.Size(42, 19);
            this.mlFont.TabIndex = 3;
            this.mlFont.Text = "Font :";
            this.mlFont.Click += new System.EventHandler(this.mcbColor_Click);
            // 
            // mcbTheme
            // 
            this.mcbTheme.FormattingEnabled = true;
            this.mcbTheme.ItemHeight = 23;
            this.mcbTheme.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.mcbTheme.Location = new System.Drawing.Point(591, 37);
            this.mcbTheme.Name = "mcbTheme";
            this.mcbTheme.Size = new System.Drawing.Size(121, 29);
            this.mcbTheme.TabIndex = 4;
            this.mcbTheme.UseSelectable = true;
            // 
            // mcbColor
            // 
            this.mcbColor.FormattingEnabled = true;
            this.mcbColor.ItemHeight = 23;
            this.mcbColor.Items.AddRange(new object[] {
            "Default",
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Line",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red"});
            this.mcbColor.Location = new System.Drawing.Point(591, 72);
            this.mcbColor.Name = "mcbColor";
            this.mcbColor.Size = new System.Drawing.Size(121, 29);
            this.mcbColor.TabIndex = 5;
            this.mcbColor.UseSelectable = true;
            this.mcbColor.SelectedIndexChanged += new System.EventHandler(this.mcbColor_SelectedIndexChanged);
            // 
            // mcbFont
            // 
            this.mcbFont.FormattingEnabled = true;
            this.mcbFont.ItemHeight = 23;
            this.mcbFont.Location = new System.Drawing.Point(591, 107);
            this.mcbFont.Name = "mcbFont";
            this.mcbFont.Size = new System.Drawing.Size(121, 29);
            this.mcbFont.TabIndex = 6;
            this.mcbFont.UseSelectable = true;
            // 
            // mtNews
            // 
            this.mtNews.ActiveControl = null;
            this.mtNews.Location = new System.Drawing.Point(23, 345);
            this.mtNews.Name = "mtNews";
            this.mtNews.Size = new System.Drawing.Size(145, 129);
            this.mtNews.TabIndex = 8;
            this.mtNews.Text = "News Crawler";
            this.mtNews.TileImage = ((System.Drawing.Image)(resources.GetObject("mtNews.TileImage")));
            this.mtNews.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtNews.UseSelectable = true;
            this.mtNews.UseTileImage = true;
            this.mtNews.Click += new System.EventHandler(this.mtNews_Click);
            // 
            // mtNetPath1
            // 
            this.mtNetPath1.ActiveControl = null;
            this.mtNetPath1.Location = new System.Drawing.Point(494, 193);
            this.mtNetPath1.Name = "mtNetPath1";
            this.mtNetPath1.Size = new System.Drawing.Size(86, 85);
            this.mtNetPath1.TabIndex = 9;
            this.mtNetPath1.Text = "Google";
            this.mtNetPath1.TileImage = ((System.Drawing.Image)(resources.GetObject("mtNetPath1.TileImage")));
            this.mtNetPath1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtNetPath1.UseSelectable = true;
            this.mtNetPath1.UseTileImage = true;
            // 
            // mtNetPath2
            // 
            this.mtNetPath2.ActiveControl = null;
            this.mtNetPath2.Location = new System.Drawing.Point(616, 193);
            this.mtNetPath2.Name = "mtNetPath2";
            this.mtNetPath2.Size = new System.Drawing.Size(86, 85);
            this.mtNetPath2.TabIndex = 0;
            this.mtNetPath2.Text = "Naver";
            this.mtNetPath2.TileImage = ((System.Drawing.Image)(resources.GetObject("mtNetPath2.TileImage")));
            this.mtNetPath2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtNetPath2.UseSelectable = true;
            this.mtNetPath2.UseTileImage = true;
            // 
            // mtPath1
            // 
            this.mtPath1.ActiveControl = null;
            this.mtPath1.Location = new System.Drawing.Point(494, 316);
            this.mtPath1.Name = "mtPath1";
            this.mtPath1.Size = new System.Drawing.Size(86, 85);
            this.mtPath1.TabIndex = 10;
            this.mtPath1.Text = "Notepad";
            this.mtPath1.TileImage = ((System.Drawing.Image)(resources.GetObject("mtPath1.TileImage")));
            this.mtPath1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPath1.UseSelectable = true;
            this.mtPath1.UseTileImage = true;
            this.mtPath1.Click += new System.EventHandler(this.mtExe_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(243, 178);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(506, 337);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // mtPaht2
            // 
            this.mtPaht2.ActiveControl = null;
            this.mtPaht2.Location = new System.Drawing.Point(616, 316);
            this.mtPaht2.Name = "mtPaht2";
            this.mtPaht2.Size = new System.Drawing.Size(86, 85);
            this.mtPaht2.TabIndex = 0;
            this.mtPaht2.Text = "Calculator";
            this.mtPaht2.TileImage = ((System.Drawing.Image)(resources.GetObject("mtPaht2.TileImage")));
            this.mtPaht2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPaht2.UseSelectable = true;
            this.mtPaht2.UseTileImage = true;
            this.mtPaht2.Click += new System.EventHandler(this.mtExe_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.mtPath1);
            this.Controls.Add(this.mtNetPath2);
            this.Controls.Add(this.mtNetPath1);
            this.Controls.Add(this.mtNews);
            this.Controls.Add(this.mcbFont);
            this.Controls.Add(this.mcbColor);
            this.Controls.Add(this.mcbTheme);
            this.Controls.Add(this.mlFont);
            this.Controls.Add(this.mlColor);
            this.Controls.Add(this.mlTheme);
            this.Controls.Add(this.mtTimer);
            this.Controls.Add(this.mtPaht2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "MainForm";
            this.Text = "Task Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtTimer;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel mlTheme;
        private MetroFramework.Controls.MetroLabel mlColor;
        private MetroFramework.Controls.MetroLabel mlFont;
        private MetroFramework.Controls.MetroComboBox mcbTheme;
        private MetroFramework.Controls.MetroComboBox mcbColor;
        private MetroFramework.Controls.MetroComboBox mcbFont;
        private MetroFramework.Controls.MetroTile mtNews;
        private MetroFramework.Controls.MetroTile mtNetPath1;
        private MetroFramework.Controls.MetroTile mtNetPath2;
        private MetroFramework.Controls.MetroTile mtPath1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile mtPaht2;
    }
}

