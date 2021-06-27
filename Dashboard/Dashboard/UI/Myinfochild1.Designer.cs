
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.starPBox1 = new Sunny.UI.UIComboBox();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel6 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel5 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.director = new Sunny.UI.UITextBox();
            this.movietitle = new Sunny.UI.UITextBox();
            this.actor = new Sunny.UI.UITextBox();
            this.open = new Sunny.UI.UITextBox();
            this.starpoint = new Sunny.UI.UITextBox();
            this.subtitle = new Sunny.UI.UITextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.moviesearch = new Sunny.UI.UITextBox();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.evoT = new Sunny.UI.UITextBox();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.listView1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.moviesearch);
            this.panel4.Controls.Add(this.uiSymbolButton1);
            this.panel4.Location = new System.Drawing.Point(-2, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(858, 514);
            this.panel4.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.evoT);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.starPBox1);
            this.panel1.Controls.Add(this.uiSymbolButton2);
            this.panel1.Controls.Add(this.uiSymbolLabel6);
            this.panel1.Controls.Add(this.uiSymbolLabel5);
            this.panel1.Controls.Add(this.uiSymbolLabel4);
            this.panel1.Controls.Add(this.uiSymbolLabel3);
            this.panel1.Controls.Add(this.uiSymbolLabel2);
            this.panel1.Controls.Add(this.uiSymbolLabel1);
            this.panel1.Controls.Add(this.director);
            this.panel1.Controls.Add(this.movietitle);
            this.panel1.Controls.Add(this.actor);
            this.panel1.Controls.Add(this.open);
            this.panel1.Controls.Add(this.starpoint);
            this.panel1.Controls.Add(this.subtitle);
            this.panel1.Location = new System.Drawing.Point(313, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 222);
            this.panel1.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(503, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // starPBox1
            // 
            this.starPBox1.FillColor = System.Drawing.Color.White;
            this.starPBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.starPBox1.Items.AddRange(new object[] {
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0",
            "4.5",
            "5.0"});
            this.starPBox1.Location = new System.Drawing.Point(190, 154);
            this.starPBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.starPBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.starPBox1.Name = "starPBox1";
            this.starPBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.starPBox1.Size = new System.Drawing.Size(132, 29);
            this.starPBox1.TabIndex = 22;
            this.starPBox1.Text = "별점";
            this.starPBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.uiSymbolButton2.Location = new System.Drawing.Point(326, 154);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.Size = new System.Drawing.Size(216, 29);
            this.uiSymbolButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton2.Symbol = 61445;
            this.uiSymbolButton2.TabIndex = 21;
            this.uiSymbolButton2.Text = "별점과 한줄평 틍록";
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // uiSymbolLabel6
            // 
            this.uiSymbolLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel6.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel6.Location = new System.Drawing.Point(272, 21);
            this.uiSymbolLabel6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel6.Name = "uiSymbolLabel6";
            this.uiSymbolLabel6.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel6.Size = new System.Drawing.Size(99, 35);
            this.uiSymbolLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel6.Symbol = 61447;
            this.uiSymbolLabel6.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel6.TabIndex = 9;
            this.uiSymbolLabel6.Text = "감독이름";
            // 
            // uiSymbolLabel5
            // 
            this.uiSymbolLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel5.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel5.Location = new System.Drawing.Point(272, 61);
            this.uiSymbolLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel5.Name = "uiSymbolLabel5";
            this.uiSymbolLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel5.Size = new System.Drawing.Size(99, 35);
            this.uiSymbolLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel5.Symbol = 61632;
            this.uiSymbolLabel5.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel5.TabIndex = 8;
            this.uiSymbolLabel5.Text = "출연진";
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel4.Location = new System.Drawing.Point(3, 100);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(99, 35);
            this.uiSymbolLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel4.Symbol = 62104;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel4.TabIndex = 7;
            this.uiSymbolLabel4.Text = "개봉일";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel3.Location = new System.Drawing.Point(272, 100);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(99, 35);
            this.uiSymbolLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel3.Symbol = 61575;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel3.TabIndex = 6;
            this.uiSymbolLabel3.Text = "평균평점";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel2.Location = new System.Drawing.Point(3, 61);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(99, 35);
            this.uiSymbolLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel2.Symbol = 98;
            this.uiSymbolLabel2.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel2.TabIndex = 5;
            this.uiSymbolLabel2.Text = "부제목";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(3, 24);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(99, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 98;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.TabIndex = 4;
            this.uiSymbolLabel1.Text = "제목";
            // 
            // director
            // 
            this.director.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.director.FillColor = System.Drawing.Color.White;
            this.director.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.director.Location = new System.Drawing.Point(378, 24);
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
            this.movietitle.Location = new System.Drawing.Point(109, 24);
            this.movietitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.movietitle.Maximum = 2147483647D;
            this.movietitle.Minimum = -2147483648D;
            this.movietitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.movietitle.Name = "movietitle";
            this.movietitle.Padding = new System.Windows.Forms.Padding(5);
            this.movietitle.Size = new System.Drawing.Size(150, 29);
            this.movietitle.TabIndex = 3;
            this.movietitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // actor
            // 
            this.actor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.actor.FillColor = System.Drawing.Color.White;
            this.actor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.actor.Location = new System.Drawing.Point(378, 63);
            this.actor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.actor.Maximum = 2147483647D;
            this.actor.Minimum = -2147483648D;
            this.actor.MinimumSize = new System.Drawing.Size(1, 1);
            this.actor.Name = "actor";
            this.actor.Padding = new System.Windows.Forms.Padding(5);
            this.actor.Size = new System.Drawing.Size(150, 29);
            this.actor.TabIndex = 3;
            this.actor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // open
            // 
            this.open.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.open.FillColor = System.Drawing.Color.White;
            this.open.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.open.Location = new System.Drawing.Point(109, 102);
            this.open.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.open.Maximum = 2147483647D;
            this.open.Minimum = -2147483648D;
            this.open.MinimumSize = new System.Drawing.Size(1, 1);
            this.open.Name = "open";
            this.open.Padding = new System.Windows.Forms.Padding(5);
            this.open.Size = new System.Drawing.Size(150, 29);
            this.open.TabIndex = 3;
            this.open.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // starpoint
            // 
            this.starpoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.starpoint.FillColor = System.Drawing.Color.White;
            this.starpoint.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.starpoint.Location = new System.Drawing.Point(378, 102);
            this.starpoint.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.starpoint.Maximum = 2147483647D;
            this.starpoint.Minimum = -2147483648D;
            this.starpoint.MinimumSize = new System.Drawing.Size(1, 1);
            this.starpoint.Name = "starpoint";
            this.starpoint.Padding = new System.Windows.Forms.Padding(5);
            this.starpoint.Size = new System.Drawing.Size(150, 29);
            this.starpoint.TabIndex = 3;
            this.starpoint.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subtitle
            // 
            this.subtitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subtitle.FillColor = System.Drawing.Color.White;
            this.subtitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.subtitle.Location = new System.Drawing.Point(109, 63);
            this.subtitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.subtitle.Maximum = 2147483647D;
            this.subtitle.Minimum = -2147483648D;
            this.subtitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.subtitle.Name = "subtitle";
            this.subtitle.Padding = new System.Windows.Forms.Padding(5);
            this.subtitle.Size = new System.Drawing.Size(150, 29);
            this.subtitle.TabIndex = 3;
            this.subtitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "영화제목";
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
            this.moviesearch.Location = new System.Drawing.Point(4, 30);
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
            this.uiSymbolButton1.Location = new System.Drawing.Point(161, 30);
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
            // evoT
            // 
            this.evoT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.evoT.FillColor = System.Drawing.Color.White;
            this.evoT.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.evoT.Location = new System.Drawing.Point(190, 193);
            this.evoT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.evoT.Maximum = 2147483647D;
            this.evoT.Minimum = -2147483648D;
            this.evoT.MinimumSize = new System.Drawing.Size(1, 1);
            this.evoT.Name = "evoT";
            this.evoT.Padding = new System.Windows.Forms.Padding(5);
            this.evoT.Size = new System.Drawing.Size(338, 29);
            this.evoT.TabIndex = 3;
            this.evoT.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private Sunny.UI.UITextBox starpoint;
        private Sunny.UI.UITextBox actor;
        private Sunny.UI.UITextBox director;
        private Sunny.UI.UITextBox movietitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UITextBox moviesearch;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UITextBox open;
        private Sunny.UI.UITextBox subtitle;
        private System.Windows.Forms.Panel panel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel6;
        private Sunny.UI.UISymbolLabel uiSymbolLabel5;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UIComboBox starPBox1;
        private System.Windows.Forms.Button button1;
        private Sunny.UI.UITextBox evoT;
    }
}