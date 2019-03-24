namespace MusicDB_withEF_
{
    partial class AddSongs
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lBGanres = new System.Windows.Forms.ListBox();
            this.nUDLength = new System.Windows.Forms.NumericUpDown();
            this.cBAlbum = new System.Windows.Forms.ComboBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ganresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.bCancel);
            this.groupBox.Controls.Add(this.bAdd);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.lBGanres);
            this.groupBox.Controls.Add(this.nUDLength);
            this.groupBox.Controls.Add(this.cBAlbum);
            this.groupBox.Controls.Add(this.tBName);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(360, 237);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Add song";
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(184, 208);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 9;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(103, 208);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ganres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Album";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Length";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // lBGanres
            // 
            this.lBGanres.DataSource = this.ganresBindingSource;
            this.lBGanres.DisplayMember = "G_name";
            this.lBGanres.FormattingEnabled = true;
            this.lBGanres.Location = new System.Drawing.Point(161, 98);
            this.lBGanres.Name = "lBGanres";
            this.lBGanres.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lBGanres.Size = new System.Drawing.Size(143, 69);
            this.lBGanres.TabIndex = 3;
            this.lBGanres.ValueMember = "G_id";
            // 
            // nUDLength
            // 
            this.nUDLength.Location = new System.Drawing.Point(161, 45);
            this.nUDLength.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nUDLength.Name = "nUDLength";
            this.nUDLength.Size = new System.Drawing.Size(144, 20);
            this.nUDLength.TabIndex = 2;
            // 
            // cBAlbum
            // 
            this.cBAlbum.DataSource = this.albumsBindingSource;
            this.cBAlbum.DisplayMember = "AL_name";
            this.cBAlbum.FormattingEnabled = true;
            this.cBAlbum.Location = new System.Drawing.Point(161, 71);
            this.cBAlbum.Name = "cBAlbum";
            this.cBAlbum.Size = new System.Drawing.Size(143, 21);
            this.cBAlbum.TabIndex = 1;
            this.cBAlbum.ValueMember = "AL_id";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(161, 19);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(144, 20);
            this.tBName.TabIndex = 0;
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataSource = typeof(MusicDataEF.Albums);
            // 
            // ganresBindingSource
            // 
            this.ganresBindingSource.DataSource = typeof(MusicDataEF.Ganres);
            // 
            // AddSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.groupBox);
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "AddSongs";
            this.Text = "AddSongs";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBGanres;
        private System.Windows.Forms.NumericUpDown nUDLength;
        private System.Windows.Forms.ComboBox cBAlbum;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.BindingSource ganresBindingSource;
        private System.Windows.Forms.BindingSource albumsBindingSource;
    }
}