
namespace Dashboard.UI
{
    partial class Conditionsearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchB = new Sunny.UI.UIButton();
            this.searchview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.movieS = new Sunny.UI.UITextBox();
            this.movieimage = new System.Windows.Forms.PictureBox();
            this.genreBox = new Sunny.UI.UIComboBox();
            this.CountryBox = new Sunny.UI.UIComboBox();
            this.yearFBox = new Sunny.UI.UIComboBox();
            this.yearABox = new Sunny.UI.UIComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieimage)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchB
            // 
            this.searchB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchB.Location = new System.Drawing.Point(256, 53);
            this.searchB.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchB.Name = "searchB";
            this.searchB.Size = new System.Drawing.Size(135, 103);
            this.searchB.Style = Sunny.UI.UIStyle.Custom;
            this.searchB.TabIndex = 0;
            this.searchB.Text = "찾기";
            this.searchB.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // searchview
            // 
            this.searchview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.searchview.HideSelection = false;
            this.searchview.Location = new System.Drawing.Point(12, 166);
            this.searchview.Name = "searchview";
            this.searchview.Size = new System.Drawing.Size(841, 332);
            this.searchview.TabIndex = 1;
            this.searchview.UseCompatibleStateImageBehavior = false;
            this.searchview.View = System.Windows.Forms.View.Details;
            this.searchview.SelectedIndexChanged += new System.EventHandler(this.searchview_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "영화제목";
            this.columnHeader1.Width = 199;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "링크";
            this.columnHeader2.Width = 30;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "이미지";
            this.columnHeader3.Width = 30;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "부제목";
            this.columnHeader4.Width = 121;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "개봉일";
            this.columnHeader5.Width = 131;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "감독";
            this.columnHeader6.Width = 124;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "배우";
            this.columnHeader7.Width = 117;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "평점";
            this.columnHeader8.Width = 187;
            // 
            // movieS
            // 
            this.movieS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.movieS.FillColor = System.Drawing.Color.White;
            this.movieS.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.movieS.Location = new System.Drawing.Point(55, 13);
            this.movieS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.movieS.Maximum = 2147483647D;
            this.movieS.Minimum = -2147483648D;
            this.movieS.MinimumSize = new System.Drawing.Size(1, 1);
            this.movieS.Name = "movieS";
            this.movieS.Padding = new System.Windows.Forms.Padding(5);
            this.movieS.Size = new System.Drawing.Size(150, 29);
            this.movieS.Style = Sunny.UI.UIStyle.Custom;
            this.movieS.TabIndex = 2;
            this.movieS.Text = "연관 검색";
            this.movieS.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // movieimage
            // 
            this.movieimage.Location = new System.Drawing.Point(23, 12);
            this.movieimage.Name = "movieimage";
            this.movieimage.Size = new System.Drawing.Size(159, 146);
            this.movieimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.movieimage.TabIndex = 3;
            this.movieimage.TabStop = false;
            // 
            // genreBox
            // 
            this.genreBox.FillColor = System.Drawing.Color.White;
            this.genreBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.genreBox.Items.AddRange(new object[] {
            "1.드라마",
            "2.판타지",
            "3. 서부 ",
            "4. 공포",
            "5. 로맨스 ",
            "6. 모험",
            "7. 스릴러 ",
            "8. 느와르",
            "9. 컬트 ",
            "10. 다큐멘터리",
            "11. 코미디 ",
            "12. 가족",
            "13. 미스터리 ",
            "14. 전쟁",
            "15. 애니메이션 ",
            "16. 범죄",
            "17. 뮤지컬 ",
            "18. SF",
            "19. 액션",
            "20. 무협",
            "21. 에로 ",
            "22. 서스펜스",
            "23. 서사 ",
            "24. 블랙코미디",
            "25. 실험 ",
            "26. 영화카툰",
            "27. 영화음악 ",
            "28. 영화패러디포스터"});
            this.genreBox.Location = new System.Drawing.Point(213, 13);
            this.genreBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.genreBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.genreBox.Name = "genreBox";
            this.genreBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.genreBox.Size = new System.Drawing.Size(150, 29);
            this.genreBox.Style = Sunny.UI.UIStyle.Custom;
            this.genreBox.TabIndex = 4;
            this.genreBox.Text = "장르";
            this.genreBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CountryBox
            // 
            this.CountryBox.FillColor = System.Drawing.Color.White;
            this.CountryBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CountryBox.Items.AddRange(new object[] {
            "KR 한국",
            "JP 일본  ",
            "US 미국 ",
            "HK 홍콩 ",
            "GB 영국",
            "FR 프랑스  ",
            "ETC 기타 "});
            this.CountryBox.Location = new System.Drawing.Point(55, 52);
            this.CountryBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CountryBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.CountryBox.Size = new System.Drawing.Size(150, 29);
            this.CountryBox.Style = Sunny.UI.UIStyle.Custom;
            this.CountryBox.TabIndex = 5;
            this.CountryBox.Text = "나라";
            this.CountryBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yearFBox
            // 
            this.yearFBox.FillColor = System.Drawing.Color.White;
            this.yearFBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.yearFBox.Items.AddRange(new object[] {
            "1950",
            "1960",
            "1970",
            "1980",
            "1990",
            "2000",
            "2010",
            "2020"});
            this.yearFBox.Location = new System.Drawing.Point(55, 91);
            this.yearFBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yearFBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.yearFBox.Name = "yearFBox";
            this.yearFBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.yearFBox.Size = new System.Drawing.Size(150, 29);
            this.yearFBox.Style = Sunny.UI.UIStyle.Custom;
            this.yearFBox.TabIndex = 5;
            this.yearFBox.Text = "연도";
            this.yearFBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yearABox
            // 
            this.yearABox.FillColor = System.Drawing.Color.White;
            this.yearABox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.yearABox.Items.AddRange(new object[] {
            "1960",
            "1970",
            "1980",
            "1990",
            "2000",
            "2010",
            "2020"});
            this.yearABox.Location = new System.Drawing.Point(55, 124);
            this.yearABox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yearABox.MinimumSize = new System.Drawing.Size(63, 0);
            this.yearABox.Name = "yearABox";
            this.yearABox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.yearABox.Size = new System.Drawing.Size(150, 29);
            this.yearABox.Style = Sunny.UI.UIStyle.Custom;
            this.yearABox.TabIndex = 6;
            this.yearABox.Text = "연도";
            this.yearABox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(210, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "에서";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(210, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "까지";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.movieS);
            this.uiPanel1.Controls.Add(this.label2);
            this.uiPanel1.Controls.Add(this.genreBox);
            this.uiPanel1.Controls.Add(this.searchB);
            this.uiPanel1.Controls.Add(this.yearABox);
            this.uiPanel1.Controls.Add(this.yearFBox);
            this.uiPanel1.Controls.Add(this.CountryBox);
            this.uiPanel1.Controls.Add(this.label1);
            this.uiPanel1.FillColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(189, 2);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Transparent;
            this.uiPanel1.Size = new System.Drawing.Size(457, 156);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.TabIndex = 8;
            this.uiPanel1.Text = "uiPanel1";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(824, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Conditionsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(855, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.movieimage);
            this.Controls.Add(this.searchview);
            this.Name = "Conditionsearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Conditionsearch";
            ((System.ComponentModel.ISupportInitialize)(this.movieimage)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton searchB;
        private System.Windows.Forms.ListView searchview;
        private Sunny.UI.UITextBox movieS;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.PictureBox movieimage;
        private Sunny.UI.UIComboBox genreBox;
        private Sunny.UI.UIComboBox CountryBox;
        private Sunny.UI.UIComboBox yearFBox;
        private Sunny.UI.UIComboBox yearABox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIPanel uiPanel1;
        private System.Windows.Forms.Button button1;
    }
}