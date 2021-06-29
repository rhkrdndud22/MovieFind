
namespace Dashboard.UI
{
    partial class Myinfochild2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiComboBox2 = new Sunny.UI.UIComboBox();
            this.uiComboBox3 = new Sunny.UI.UIComboBox();
            this.uiComboBox4 = new Sunny.UI.UIComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchB
            // 
            this.searchB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchB.FillColor = System.Drawing.Color.Transparent;
            this.searchB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.searchB.Location = new System.Drawing.Point(181, 53);
            this.searchB.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchB.Name = "searchB";
            this.searchB.RectColor = System.Drawing.Color.Transparent;
            this.searchB.Size = new System.Drawing.Size(135, 60);
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
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "이미지";
            this.columnHeader3.Width = 118;
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
            this.movieS.Location = new System.Drawing.Point(24, 14);
            this.movieS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.movieS.Maximum = 2147483647D;
            this.movieS.Minimum = -2147483648D;
            this.movieS.MinimumSize = new System.Drawing.Size(1, 1);
            this.movieS.Name = "movieS";
            this.movieS.Padding = new System.Windows.Forms.Padding(5);
            this.movieS.Size = new System.Drawing.Size(150, 29);
            this.movieS.TabIndex = 2;
            this.movieS.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(532, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 146);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox1.Items.AddRange(new object[] {
            "1.드라마",
            "2.판타지",
            "3 서부 ",
            "4: 공포",
            "5: 로맨스 ",
            "6: 모험",
            "7: 스릴러 ",
            "8: 느와르",
            "9: 컬트 ",
            "10: 다큐멘터리",
            "11: 코미디 ",
            "12: 가족",
            "13: 미스터리 ",
            "14: 전쟁",
            "15: 애니메이션 ",
            "16: 범죄",
            "17: 뮤지컬 ",
            "18: SF",
            "19: 액션",
            "20: 무협",
            "21: 에로 ",
            "22: 서스펜스",
            "23: 서사 ",
            "24: 블랙코미디",
            "25: 실험 ",
            "26: 영화카툰",
            "27: 영화음악 ",
            "28: 영화패러디포스터"});
            this.uiComboBox1.Location = new System.Drawing.Point(24, 53);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox1.TabIndex = 4;
            this.uiComboBox1.Text = "장르";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox2
            // 
            this.uiComboBox2.FillColor = System.Drawing.Color.White;
            this.uiComboBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox2.Items.AddRange(new object[] {
            "KR 한국",
            "JP 일본  ",
            "US 미국 ",
            "HK 홍콩 ",
            "GB 영국",
            "FR 프랑스  ",
            "ETC 기타 "});
            this.uiComboBox2.Location = new System.Drawing.Point(24, 92);
            this.uiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox2.Name = "uiComboBox2";
            this.uiComboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox2.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox2.TabIndex = 5;
            this.uiComboBox2.Text = "나라";
            this.uiComboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox3
            // 
            this.uiComboBox3.FillColor = System.Drawing.Color.White;
            this.uiComboBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox3.Items.AddRange(new object[] {
            "1950",
            "1960",
            "1970",
            "1980",
            "1990",
            "2000",
            "2010",
            "2020"});
            this.uiComboBox3.Location = new System.Drawing.Point(24, 129);
            this.uiComboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox3.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox3.Name = "uiComboBox3";
            this.uiComboBox3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox3.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox3.TabIndex = 5;
            this.uiComboBox3.Text = "연도";
            this.uiComboBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox4
            // 
            this.uiComboBox4.FillColor = System.Drawing.Color.White;
            this.uiComboBox4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox4.Items.AddRange(new object[] {
            "1960",
            "1970",
            "1980",
            "1990",
            "2000",
            "2010",
            "2020"});
            this.uiComboBox4.Location = new System.Drawing.Point(225, 129);
            this.uiComboBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox4.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox4.Name = "uiComboBox4";
            this.uiComboBox4.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox4.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox4.TabIndex = 6;
            this.uiComboBox4.Text = "연도";
            this.uiComboBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 140);
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
            this.label2.Location = new System.Drawing.Point(382, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "까지";
            // 
            // Myinfochild2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(855, 510);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiComboBox4);
            this.Controls.Add(this.uiComboBox2);
            this.Controls.Add(this.uiComboBox3);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.movieS);
            this.Controls.Add(this.searchview);
            this.Controls.Add(this.searchB);
            this.Controls.Add(this.label1);
            this.Name = "Myinfochild2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIComboBox uiComboBox2;
        private Sunny.UI.UIComboBox uiComboBox3;
        private Sunny.UI.UIComboBox uiComboBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}