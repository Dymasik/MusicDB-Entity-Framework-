namespace MusicDB_withEF_
{
    partial class EditSong
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
            this.dGVEdit = new System.Windows.Forms.DataGridView();
            this.sGidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGsongIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGganreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ganresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ganresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songGanreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cBGanres = new System.Windows.Forms.ComboBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songGanreBindingSource)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVEdit
            // 
            this.dGVEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVEdit.AutoGenerateColumns = false;
            this.dGVEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sGidDataGridViewTextBoxColumn,
            this.sGsongIdDataGridViewTextBoxColumn,
            this.sGganreIdDataGridViewTextBoxColumn,
            this.ganresDataGridViewTextBoxColumn,
            this.songsDataGridViewTextBoxColumn});
            this.dGVEdit.DataSource = this.songGanreBindingSource;
            this.dGVEdit.Location = new System.Drawing.Point(12, 143);
            this.dGVEdit.Name = "dGVEdit";
            this.dGVEdit.ReadOnly = true;
            this.dGVEdit.Size = new System.Drawing.Size(360, 150);
            this.dGVEdit.TabIndex = 0;
            this.dGVEdit.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dGVEdit_DataError);
            // 
            // sGidDataGridViewTextBoxColumn
            // 
            this.sGidDataGridViewTextBoxColumn.DataPropertyName = "SG_id";
            this.sGidDataGridViewTextBoxColumn.HeaderText = "SG_id";
            this.sGidDataGridViewTextBoxColumn.Name = "sGidDataGridViewTextBoxColumn";
            this.sGidDataGridViewTextBoxColumn.Visible = false;
            // 
            // sGsongIdDataGridViewTextBoxColumn
            // 
            this.sGsongIdDataGridViewTextBoxColumn.DataPropertyName = "SG_songId";
            this.sGsongIdDataGridViewTextBoxColumn.HeaderText = "SG_songId";
            this.sGsongIdDataGridViewTextBoxColumn.Name = "sGsongIdDataGridViewTextBoxColumn";
            this.sGsongIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // sGganreIdDataGridViewTextBoxColumn
            // 
            this.sGganreIdDataGridViewTextBoxColumn.DataPropertyName = "SG_ganreId";
            this.sGganreIdDataGridViewTextBoxColumn.DataSource = this.ganresBindingSource;
            this.sGganreIdDataGridViewTextBoxColumn.DisplayMember = "G_name";
            this.sGganreIdDataGridViewTextBoxColumn.HeaderText = "Ganre";
            this.sGganreIdDataGridViewTextBoxColumn.Name = "sGganreIdDataGridViewTextBoxColumn";
            this.sGganreIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sGganreIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sGganreIdDataGridViewTextBoxColumn.ValueMember = "G_id";
            // 
            // ganresBindingSource
            // 
            this.ganresBindingSource.DataSource = typeof(MusicDataEF.Ganres);
            // 
            // ganresDataGridViewTextBoxColumn
            // 
            this.ganresDataGridViewTextBoxColumn.DataPropertyName = "Ganres";
            this.ganresDataGridViewTextBoxColumn.HeaderText = "Ganres";
            this.ganresDataGridViewTextBoxColumn.Name = "ganresDataGridViewTextBoxColumn";
            this.ganresDataGridViewTextBoxColumn.Visible = false;
            // 
            // songsDataGridViewTextBoxColumn
            // 
            this.songsDataGridViewTextBoxColumn.DataPropertyName = "Songs";
            this.songsDataGridViewTextBoxColumn.HeaderText = "Songs";
            this.songsDataGridViewTextBoxColumn.Name = "songsDataGridViewTextBoxColumn";
            this.songsDataGridViewTextBoxColumn.Visible = false;
            // 
            // songGanreBindingSource
            // 
            this.songGanreBindingSource.DataSource = typeof(MusicDataEF.SongGanre);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.cBGanres);
            this.groupBox.Controls.Add(this.bAdd);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(221, 125);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Add Ganre";
            // 
            // cBGanres
            // 
            this.cBGanres.DataSource = this.ganresBindingSource;
            this.cBGanres.DisplayMember = "G_name";
            this.cBGanres.FormattingEnabled = true;
            this.cBGanres.Location = new System.Drawing.Point(6, 54);
            this.cBGanres.Name = "cBGanres";
            this.cBGanres.Size = new System.Drawing.Size(203, 21);
            this.cBGanres.TabIndex = 4;
            this.cBGanres.ValueMember = "G_id";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(65, 96);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(297, 37);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 1;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(297, 66);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(146, 326);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // EditSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dGVEdit);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "EditSong";
            this.Text = "EditSong";
            ((System.ComponentModel.ISupportInitialize)(this.dGVEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songGanreBindingSource)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVEdit;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGsongIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sGganreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ganresBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource songGanreBindingSource;
        private System.Windows.Forms.ComboBox cBGanres;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button OK;
    }
}