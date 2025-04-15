namespace MetroUIManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mtTimer = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mlTheme = new MetroFramework.Controls.MetroLabel();
            this.mlColor = new MetroFramework.Controls.MetroLabel();
            this.mlFont = new MetroFramework.Controls.MetroLabel();
            this.mcbTheme = new MetroFramework.Controls.MetroComboBox();
            this.mcbColor = new MetroFramework.Controls.MetroComboBox();
            this.mcbFont = new MetroFramework.Controls.MetroComboBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mtNetPath1 = new MetroFramework.Controls.MetroTile();
            this.mtNetPath2 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
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
            this.mlFont.Click += new System.EventHandler(this.metroLabel3_Click);
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
            this.mcbColor.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
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
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(23, 345);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(145, 129);
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "News Crawler";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
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
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(494, 316);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(86, 85);
            this.metroTile2.TabIndex = 10;
            this.metroTile2.Text = "Note";
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.mtNetPath2);
            this.Controls.Add(this.mtNetPath1);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.mcbFont);
            this.Controls.Add(this.mcbColor);
            this.Controls.Add(this.mcbTheme);
            this.Controls.Add(this.mlFont);
            this.Controls.Add(this.mlColor);
            this.Controls.Add(this.mlTheme);
            this.Controls.Add(this.mtTimer);
            this.Name = "Form1";
            this.Text = "Task Management";
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
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile mtNetPath1;
        private MetroFramework.Controls.MetroTile mtNetPath2;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}

