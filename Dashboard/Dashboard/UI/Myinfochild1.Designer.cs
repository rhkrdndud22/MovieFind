
namespace Dashboard.UI
{
    partial class Myinfochild1
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.movieselect = new System.Windows.Forms.ComboBox();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.open = new Sunny.UI.UITextBox();
            this.subtitle = new Sunny.UI.UITextBox();
            this.starpoint = new Sunny.UI.UITextBox();
            this.actor = new Sunny.UI.UITextBox();
            this.director = new Sunny.UI.UITextBox();
            this.movietitle = new Sunny.UI.UITextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.moviesearch = new Sunny.UI.UITextBox();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.querytext = new Sunny.UI.UITextBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.querytext);
            this.panel4.Controls.Add(this.movieselect);
            this.panel4.Controls.Add(this.uiSymbolButton2);
            this.panel4.Controls.Add(this.listView1);
            this.panel4.Controls.Add(this.open);
            this.panel4.Controls.Add(this.subtitle);
            this.panel4.Controls.Add(this.starpoint);
            this.panel4.Controls.Add(this.actor);
            this.panel4.Controls.Add(this.director);
            this.panel4.Controls.Add(this.movietitle);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.moviesearch);
            this.panel4.Controls.Add(this.uiSymbolButton1);
            this.panel4.Location = new System.Drawing.Point(-2, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(858, 514);
            this.panel4.TabIndex = 20;
            // 
            // movieselect
            // 
            this.movieselect.FormattingEnabled = true;
            this.movieselect.Items.AddRange(new object[] {
            "1.드라마",
            "2.판타지",
            "3.서부",
            "4.공포",
            "5.로맨스",
            "6.모헙",
            "7.스릴러",
            "8.느와르",
            "9.컬트",
            "10.다큐멘토리",
            "11.코미디",
            "12.가족",
            "13.미스터리",
            "14.전쟁",
            "15.애니메이션",
            "16.범죄",
            "17.뮤지컬",
            "21.에로",
            "22.서스펜스",
            "23.서사",
            "24.블랙코미디",
            "25.실험",
            "26.영화카툰",
            "27.영화음악",
            "28.영화패러디포스터"});
            this.movieselect.Location = new System.Drawing.Point(359, 177);
            this.movieselect.Name = "movieselect";
            this.movieselect.Size = new System.Drawing.Size(121, 20);
            this.movieselect.TabIndex = 5;
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.FillHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.FillPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(515, 162);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.Size = new System.Drawing.Size(74, 35);
            this.uiSymbolButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton2.Symbol = 61473;
            this.uiSymbolButton2.TabIndex = 4;
            this.uiSymbolButton2.Text = "찾기";
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 231);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(855, 280);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // open
            // 
            this.open.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.open.FillColor = System.Drawing.Color.White;
            this.open.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.open.Location = new System.Drawing.Point(429, 100);
            this.open.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.open.Maximum = 2147483647D;
            this.open.Minimum = -2147483648D;
            this.open.MinimumSize = new System.Drawing.Size(1, 1);
            this.open.Name = "open";
            this.open.Padding = new System.Windows.Forms.Padding(5);
            this.open.Size = new System.Drawing.Size(150, 29);
            this.open.TabIndex = 3;
            this.open.Text = "개봉일";
            this.open.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subtitle
            // 
            this.subtitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subtitle.FillColor = System.Drawing.Color.White;
            this.subtitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.subtitle.Location = new System.Drawing.Point(429, 61);
            this.subtitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.subtitle.Maximum = 2147483647D;
            this.subtitle.Minimum = -2147483648D;
            this.subtitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.subtitle.Name = "subtitle";
            this.subtitle.Padding = new System.Windows.Forms.Padding(5);
            this.subtitle.Size = new System.Drawing.Size(150, 29);
            this.subtitle.TabIndex = 3;
            this.subtitle.Text = "영어제목";
            this.subtitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // starpoint
            // 
            this.starpoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.starpoint.FillColor = System.Drawing.Color.White;
            this.starpoint.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.starpoint.Location = new System.Drawing.Point(596, 100);
            this.starpoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.starpoint.Maximum = 2147483647D;
            this.starpoint.Minimum = -2147483648D;
            this.starpoint.MinimumSize = new System.Drawing.Size(1, 1);
            this.starpoint.Name = "starpoint";
            this.starpoint.Padding = new System.Windows.Forms.Padding(5);
            this.starpoint.Size = new System.Drawing.Size(150, 29);
            this.starpoint.TabIndex = 3;
            this.starpoint.Text = "평점";
            this.starpoint.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // actor
            // 
            this.actor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.actor.FillColor = System.Drawing.Color.White;
            this.actor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.actor.Location = new System.Drawing.Point(596, 61);
            this.actor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actor.Maximum = 2147483647D;
            this.actor.Minimum = -2147483648D;
            this.actor.MinimumSize = new System.Drawing.Size(1, 1);
            this.actor.Name = "actor";
            this.actor.Padding = new System.Windows.Forms.Padding(5);
            this.actor.Size = new System.Drawing.Size(150, 29);
            this.actor.TabIndex = 3;
            this.actor.Text = "배우";
            this.actor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // director
            // 
            this.director.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.director.FillColor = System.Drawing.Color.White;
            this.director.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.director.Location = new System.Drawing.Point(596, 22);
            this.director.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.director.Maximum = 2147483647D;
            this.director.Minimum = -2147483648D;
            this.director.MinimumSize = new System.Drawing.Size(1, 1);
            this.director.Name = "director";
            this.director.Padding = new System.Windows.Forms.Padding(5);
            this.director.Size = new System.Drawing.Size(150, 29);
            this.director.TabIndex = 3;
            this.director.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // movietitle
            // 
            this.movietitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.movietitle.FillColor = System.Drawing.Color.White;
            this.movietitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.movietitle.Location = new System.Drawing.Point(429, 22);
            this.movietitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.movietitle.Maximum = 2147483647D;
            this.movietitle.Minimum = -2147483648D;
            this.movietitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.movietitle.Name = "movietitle";
            this.movietitle.Padding = new System.Windows.Forms.Padding(5);
            this.movietitle.Size = new System.Drawing.Size(150, 29);
            this.movietitle.TabIndex = 3;
            this.movietitle.Text = "제목";
            this.movietitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // moviesearch
            // 
            this.moviesearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.moviesearch.FillColor = System.Drawing.Color.White;
            this.moviesearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.moviesearch.Location = new System.Drawing.Point(10, 28);
            this.moviesearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.moviesearch.Maximum = 2147483647D;
            this.moviesearch.Minimum = -2147483648D;
            this.moviesearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.moviesearch.Name = "moviesearch";
            this.moviesearch.Padding = new System.Windows.Forms.Padding(5);
            this.moviesearch.Size = new System.Drawing.Size(150, 29);
            this.moviesearch.TabIndex = 2;
            this.moviesearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.FillHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.FillPressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.FillSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(167, 22);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.Size = new System.Drawing.Size(74, 35);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.Symbol = 61473;
            this.uiSymbolButton1.TabIndex = 2;
            this.uiSymbolButton1.Text = "찾기";
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // querytext
            // 
            this.querytext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.querytext.FillColor = System.Drawing.Color.White;
            this.querytext.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.querytext.Location = new System.Drawing.Point(359, 139);
            this.querytext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.querytext.Maximum = 2147483647D;
            this.querytext.Minimum = -2147483648D;
            this.querytext.MinimumSize = new System.Drawing.Size(1, 1);
            this.querytext.Name = "querytext";
            this.querytext.Padding = new System.Windows.Forms.Padding(5);
            this.querytext.Size = new System.Drawing.Size(150, 29);
            this.querytext.TabIndex = 3;
            this.querytext.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Myinfochild1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(855, 510);
            this.Controls.Add(this.panel4);
            this.Name = "Myinfochild1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private Sunny.UI.UITextBox open;
        private Sunny.UI.UITextBox subtitle;
        private Sunny.UI.UITextBox starpoint;
        private Sunny.UI.UITextBox actor;
        private Sunny.UI.UITextBox director;
        private Sunny.UI.UITextBox movietitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UITextBox moviesearch;
        private System.Windows.Forms.ComboBox movieselect;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UITextBox querytext;
    }
}