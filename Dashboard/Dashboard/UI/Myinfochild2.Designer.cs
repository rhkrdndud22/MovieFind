
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
            this.uiButton1 = new Sunny.UI.UIButton();
            this.searchview = new System.Windows.Forms.ListView();
            this.movieS = new Sunny.UI.UITextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiComboBox2 = new Sunny.UI.UIComboBox();
            this.uiComboBox3 = new Sunny.UI.UIComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiButton1.Location = new System.Drawing.Point(181, 12);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 0;
            this.uiButton1.Text = "uiButton1";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(308, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox1.Location = new System.Drawing.Point(24, 53);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox1.TabIndex = 4;
            this.uiComboBox1.Text = "uiComboBox1";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox2
            // 
            this.uiComboBox2.FillColor = System.Drawing.Color.White;
            this.uiComboBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox2.Location = new System.Drawing.Point(24, 92);
            this.uiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox2.Name = "uiComboBox2";
            this.uiComboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox2.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox2.TabIndex = 5;
            this.uiComboBox2.Text = "uiComboBox2";
            this.uiComboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox3
            // 
            this.uiComboBox3.FillColor = System.Drawing.Color.White;
            this.uiComboBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiComboBox3.Location = new System.Drawing.Point(24, 129);
            this.uiComboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox3.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox3.Name = "uiComboBox3";
            this.uiComboBox3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox3.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox3.TabIndex = 5;
            this.uiComboBox3.Text = "uiComboBox3";
            this.uiComboBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Myinfochild2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(855, 510);
            this.Controls.Add(this.uiComboBox2);
            this.Controls.Add(this.uiComboBox3);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.movieS);
            this.Controls.Add(this.searchview);
            this.Controls.Add(this.uiButton1);
            this.Name = "Myinfochild2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton uiButton1;
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
    }
}