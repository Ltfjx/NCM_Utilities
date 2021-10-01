
namespace NCM_Utilities
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SongInfoInputBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PicBox_SongCover = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SingleSongData = new System.Windows.Forms.DataGridView();
            this.InfoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_SavePic = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_SongCover)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SingleSongData)).BeginInit();
            this.SuspendLayout();
            // 
            // SongInfoInputBox
            // 
            this.SongInfoInputBox.Location = new System.Drawing.Point(12, 12);
            this.SongInfoInputBox.Name = "SongInfoInputBox";
            this.SongInfoInputBox.Size = new System.Drawing.Size(880, 25);
            this.SongInfoInputBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(902, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "获取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GetInfo);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 395);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_SavePic);
            this.tabPage1.Controls.Add(this.SingleSongData);
            this.tabPage1.Controls.Add(this.PicBox_SongCover);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PicBox_SongCover
            // 
            this.PicBox_SongCover.Location = new System.Drawing.Point(31, 30);
            this.PicBox_SongCover.Name = "PicBox_SongCover";
            this.PicBox_SongCover.Size = new System.Drawing.Size(256, 256);
            this.PicBox_SongCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox_SongCover.TabIndex = 0;
            this.PicBox_SongCover.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.SongName,
            this.Artist,
            this.Album});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(980, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // No
            // 
            this.No.HeaderText = "#";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Width = 50;
            // 
            // SongName
            // 
            this.SongName.HeaderText = "曲目";
            this.SongName.MinimumWidth = 6;
            this.SongName.Name = "SongName";
            this.SongName.Width = 377;
            // 
            // Artist
            // 
            this.Artist.HeaderText = "歌手";
            this.Artist.MinimumWidth = 6;
            this.Artist.Name = "Artist";
            this.Artist.Width = 250;
            // 
            // Album
            // 
            this.Album.HeaderText = "专辑";
            this.Album.MinimumWidth = 6;
            this.Album.Name = "Album";
            this.Album.Width = 250;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(992, 366);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SingleSongData
            // 
            this.SingleSongData.AllowUserToAddRows = false;
            this.SingleSongData.AllowUserToDeleteRows = false;
            this.SingleSongData.AllowUserToResizeColumns = false;
            this.SingleSongData.AllowUserToResizeRows = false;
            this.SingleSongData.ColumnHeadersHeight = 29;
            this.SingleSongData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SingleSongData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InfoName,
            this.InfoValue});
            this.SingleSongData.Location = new System.Drawing.Point(318, 20);
            this.SingleSongData.Name = "SingleSongData";
            this.SingleSongData.ReadOnly = true;
            this.SingleSongData.RowHeadersVisible = false;
            this.SingleSongData.RowHeadersWidth = 51;
            this.SingleSongData.RowTemplate.Height = 27;
            this.SingleSongData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SingleSongData.Size = new System.Drawing.Size(649, 326);
            this.SingleSongData.TabIndex = 1;
            // 
            // InfoName
            // 
            this.InfoName.HeaderText = "条目";
            this.InfoName.MinimumWidth = 6;
            this.InfoName.Name = "InfoName";
            this.InfoName.ReadOnly = true;
            this.InfoName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InfoName.Width = 75;
            // 
            // InfoValue
            // 
            this.InfoValue.HeaderText = "数据";
            this.InfoValue.MinimumWidth = 6;
            this.InfoValue.Name = "InfoValue";
            this.InfoValue.ReadOnly = true;
            this.InfoValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InfoValue.Width = 571;
            // 
            // button_SavePic
            // 
            this.button_SavePic.Location = new System.Drawing.Point(31, 297);
            this.button_SavePic.Name = "button_SavePic";
            this.button_SavePic.Size = new System.Drawing.Size(254, 38);
            this.button_SavePic.TabIndex = 2;
            this.button_SavePic.Text = "下载封面到本地";
            this.button_SavePic.UseVisualStyleBackColor = true;
            this.button_SavePic.Click += new System.EventHandler(this.button_SavePic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SongInfoInputBox);
            this.Name = "Form1";
            this.Text = "NCM Utilities";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_SongCover)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SingleSongData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SongInfoInputBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox PicBox_SongCover;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView SingleSongData;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoValue;
        private System.Windows.Forms.Button button_SavePic;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

