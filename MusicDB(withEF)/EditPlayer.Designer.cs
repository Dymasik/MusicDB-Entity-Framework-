namespace MusicDB_withEF_
{
    partial class EditPlayer
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
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistPlayerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bAdd = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.gB = new System.Windows.Forms.GroupBox();
            this.cBArtist = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.dGVEdit = new System.Windows.Forms.DataGridView();
            this.aPidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPartIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.applayerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicPlayersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistPlayerBindingSource)).BeginInit();
            this.gB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataSource = typeof(MusicDataEF.Artists);
            // 
            // artistPlayerBindingSource
            // 
            this.artistPlayerBindingSource.DataSource = typeof(MusicDataEF.ArtistPlayer);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(84, 69);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 1;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(297, 37);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 2;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // gB
            // 
            this.gB.Controls.Add(this.cBArtist);
            this.gB.Controls.Add(this.bAdd);
            this.gB.Location = new System.Drawing.Point(12, 12);
            this.gB.Name = "gB";
            this.gB.Size = new System.Drawing.Size(255, 98);
            this.gB.TabIndex = 3;
            this.gB.TabStop = false;
            this.gB.Text = "Add Artist";
            // 
            // cBArtist
            // 
            this.cBArtist.DataSource = this.artistsBindingSource;
            this.cBArtist.DisplayMember = "A_name";
            this.cBArtist.FormattingEnabled = true;
            this.cBArtist.Location = new System.Drawing.Point(24, 42);
            this.cBArtist.Name = "cBArtist";
            this.cBArtist.Size = new System.Drawing.Size(198, 21);
            this.cBArtist.TabIndex = 2;
            this.cBArtist.ValueMember = "A_id";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(145, 326);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(297, 66);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 3;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // dGVEdit
            // 
            this.dGVEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVEdit.AutoGenerateColumns = false;
            this.dGVEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVEdit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aPidDataGridViewTextBoxColumn,
            this.aPartIdDataGridViewTextBoxColumn,
            this.applayerIdDataGridViewTextBoxColumn,
            this.artistsDataGridViewTextBoxColumn,
            this.musicPlayersDataGridViewTextBoxColumn});
            this.dGVEdit.DataSource = this.artistPlayerBindingSource;
            this.dGVEdit.Location = new System.Drawing.Point(12, 116);
            this.dGVEdit.Name = "dGVEdit";
            this.dGVEdit.Size = new System.Drawing.Size(360, 204);
            this.dGVEdit.TabIndex = 4;
            // 
            // aPidDataGridViewTextBoxColumn
            // 
            this.aPidDataGridViewTextBoxColumn.DataPropertyName = "AP_id";
            this.aPidDataGridViewTextBoxColumn.HeaderText = "AP_id";
            this.aPidDataGridViewTextBoxColumn.Name = "aPidDataGridViewTextBoxColumn";
            this.aPidDataGridViewTextBoxColumn.Visible = false;
            // 
            // aPartIdDataGridViewTextBoxColumn
            // 
            this.aPartIdDataGridViewTextBoxColumn.DataPropertyName = "AP_artId";
            this.aPartIdDataGridViewTextBoxColumn.DataSource = this.artistsBindingSource;
            this.aPartIdDataGridViewTextBoxColumn.DisplayMember = "A_name";
            this.aPartIdDataGridViewTextBoxColumn.HeaderText = "AP_artId";
            this.aPartIdDataGridViewTextBoxColumn.Name = "aPartIdDataGridViewTextBoxColumn";
            this.aPartIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aPartIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.aPartIdDataGridViewTextBoxColumn.ValueMember = "A_id";
            // 
            // applayerIdDataGridViewTextBoxColumn
            // 
            this.applayerIdDataGridViewTextBoxColumn.DataPropertyName = "Ap_playerId";
            this.applayerIdDataGridViewTextBoxColumn.HeaderText = "Ap_playerId";
            this.applayerIdDataGridViewTextBoxColumn.Name = "applayerIdDataGridViewTextBoxColumn";
            this.applayerIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // artistsDataGridViewTextBoxColumn
            // 
            this.artistsDataGridViewTextBoxColumn.DataPropertyName = "Artists";
            this.artistsDataGridViewTextBoxColumn.HeaderText = "Artists";
            this.artistsDataGridViewTextBoxColumn.Name = "artistsDataGridViewTextBoxColumn";
            this.artistsDataGridViewTextBoxColumn.Visible = false;
            // 
            // musicPlayersDataGridViewTextBoxColumn
            // 
            this.musicPlayersDataGridViewTextBoxColumn.DataPropertyName = "MusicPlayers";
            this.musicPlayersDataGridViewTextBoxColumn.HeaderText = "MusicPlayers";
            this.musicPlayersDataGridViewTextBoxColumn.Name = "musicPlayersDataGridViewTextBoxColumn";
            this.musicPlayersDataGridViewTextBoxColumn.Visible = false;
            // 
            // EditPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.dGVEdit);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.gB);
            this.Controls.Add(this.bDelete);
            this.Name = "EditPlayer";
            this.Text = "EditPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistPlayerBindingSource)).EndInit();
            this.gB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource artistPlayerBindingSource;
        private System.Windows.Forms.BindingSource artistsBindingSource;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.GroupBox gB;
        private System.Windows.Forms.ComboBox cBArtist;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.DataGridView dGVEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn aPartIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applayerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musicPlayersDataGridViewTextBoxColumn;
    }
}