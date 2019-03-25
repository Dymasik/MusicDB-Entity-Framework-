namespace MusicDB_withEF_
{
    partial class SearchForm
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
            this.components = new System.ComponentModel.Container();
            this.dGVSongs = new System.Windows.Forms.DataGridView();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salbIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songGanreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nUDHigh = new System.Windows.Forms.NumericUpDown();
            this.nUDLow = new System.Windows.Forms.NumericUpDown();
            this.tBArtist = new System.Windows.Forms.TextBox();
            this.tBAlbum = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLow)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVSongs
            // 
            this.dGVSongs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVSongs.AutoGenerateColumns = false;
            this.dGVSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sidDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.slengthDataGridViewTextBoxColumn,
            this.salbIdDataGridViewTextBoxColumn,
            this.albumsDataGridViewTextBoxColumn,
            this.songGanreDataGridViewTextBoxColumn});
            this.dGVSongs.DataSource = this.songsBindingSource;
            this.dGVSongs.Location = new System.Drawing.Point(6, 153);
            this.dGVSongs.Name = "dGVSongs";
            this.dGVSongs.ReadOnly = true;
            this.dGVSongs.Size = new System.Drawing.Size(398, 128);
            this.dGVSongs.TabIndex = 0;
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "S_id";
            this.sidDataGridViewTextBoxColumn.HeaderText = "S_id";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.ReadOnly = true;
            this.sidDataGridViewTextBoxColumn.Visible = false;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "S_name";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            this.snameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slengthDataGridViewTextBoxColumn
            // 
            this.slengthDataGridViewTextBoxColumn.DataPropertyName = "S_length";
            this.slengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.slengthDataGridViewTextBoxColumn.Name = "slengthDataGridViewTextBoxColumn";
            this.slengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salbIdDataGridViewTextBoxColumn
            // 
            this.salbIdDataGridViewTextBoxColumn.DataPropertyName = "S_albId";
            this.salbIdDataGridViewTextBoxColumn.DataSource = this.albumsBindingSource;
            this.salbIdDataGridViewTextBoxColumn.DisplayMember = "AL_name";
            this.salbIdDataGridViewTextBoxColumn.HeaderText = "Album";
            this.salbIdDataGridViewTextBoxColumn.Name = "salbIdDataGridViewTextBoxColumn";
            this.salbIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.salbIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.salbIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.salbIdDataGridViewTextBoxColumn.ValueMember = "AL_id";
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataSource = typeof(MusicDataEF.Albums);
            // 
            // albumsDataGridViewTextBoxColumn
            // 
            this.albumsDataGridViewTextBoxColumn.DataPropertyName = "Albums";
            this.albumsDataGridViewTextBoxColumn.HeaderText = "Albums";
            this.albumsDataGridViewTextBoxColumn.Name = "albumsDataGridViewTextBoxColumn";
            this.albumsDataGridViewTextBoxColumn.ReadOnly = true;
            this.albumsDataGridViewTextBoxColumn.Visible = false;
            // 
            // songGanreDataGridViewTextBoxColumn
            // 
            this.songGanreDataGridViewTextBoxColumn.DataPropertyName = "SongGanre";
            this.songGanreDataGridViewTextBoxColumn.HeaderText = "SongGanre";
            this.songGanreDataGridViewTextBoxColumn.Name = "songGanreDataGridViewTextBoxColumn";
            this.songGanreDataGridViewTextBoxColumn.ReadOnly = true;
            this.songGanreDataGridViewTextBoxColumn.Visible = false;
            // 
            // songsBindingSource
            // 
            this.songsBindingSource.DataSource = typeof(MusicDataEF.Songs);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.bSearch);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.nUDHigh);
            this.groupBox.Controls.Add(this.nUDLow);
            this.groupBox.Controls.Add(this.tBArtist);
            this.groupBox.Controls.Add(this.tBAlbum);
            this.groupBox.Controls.Add(this.tBName);
            this.groupBox.Controls.Add(this.dGVSongs);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(410, 287);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Parametrs of search";
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(317, 33);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 10;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Album";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // nUDHigh
            // 
            this.nUDHigh.Location = new System.Drawing.Point(185, 108);
            this.nUDHigh.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDHigh.Name = "nUDHigh";
            this.nUDHigh.Size = new System.Drawing.Size(66, 20);
            this.nUDHigh.TabIndex = 5;
            this.nUDHigh.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // nUDLow
            // 
            this.nUDLow.Location = new System.Drawing.Point(101, 108);
            this.nUDLow.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUDLow.Name = "nUDLow";
            this.nUDLow.Size = new System.Drawing.Size(67, 20);
            this.nUDLow.TabIndex = 4;
            // 
            // tBArtist
            // 
            this.tBArtist.Location = new System.Drawing.Point(101, 82);
            this.tBArtist.Name = "tBArtist";
            this.tBArtist.Size = new System.Drawing.Size(150, 20);
            this.tBArtist.TabIndex = 3;
            // 
            // tBAlbum
            // 
            this.tBAlbum.Location = new System.Drawing.Point(101, 56);
            this.tBAlbum.Name = "tBAlbum";
            this.tBAlbum.Size = new System.Drawing.Size(150, 20);
            this.tBAlbum.TabIndex = 2;
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(101, 30);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(150, 20);
            this.tBName.TabIndex = 1;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.groupBox);
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dGVSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songsBindingSource)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVSongs;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUDHigh;
        private System.Windows.Forms.NumericUpDown nUDLow;
        private System.Windows.Forms.TextBox tBArtist;
        private System.Windows.Forms.TextBox tBAlbum;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn salbIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songGanreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource songsBindingSource;
        private System.Windows.Forms.Button bSearch;
    }
}