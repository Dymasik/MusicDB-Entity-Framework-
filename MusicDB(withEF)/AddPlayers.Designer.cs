namespace MusicDB_withEF_
{
    partial class AddPlayers
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
            this.tBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lBArtist = new System.Windows.Forms.ListBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.artistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.bCancel);
            this.groupBox.Controls.Add(this.bAdd);
            this.groupBox.Controls.Add(this.lBArtist);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.tBName);
            this.groupBox.Location = new System.Drawing.Point(12, 31);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(410, 183);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Add music player";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(195, 37);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(174, 20);
            this.tBName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artist";
            // 
            // lBArtist
            // 
            this.lBArtist.DataSource = this.artistsBindingSource;
            this.lBArtist.DisplayMember = "A_name";
            this.lBArtist.FormattingEnabled = true;
            this.lBArtist.Location = new System.Drawing.Point(195, 65);
            this.lBArtist.Name = "lBArtist";
            this.lBArtist.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lBArtist.Size = new System.Drawing.Size(174, 69);
            this.lBArtist.TabIndex = 3;
            this.lBArtist.ValueMember = "A_id";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(114, 154);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 4;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(195, 154);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // artistsBindingSource
            // 
            this.artistsBindingSource.DataSource = typeof(MusicDataEF.Artists);
            // 
            // AddPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.groupBox);
            this.MaximumSize = new System.Drawing.Size(450, 300);
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "AddPlayers";
            this.Text = "AddPlayers";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.ListBox lBArtist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.BindingSource artistsBindingSource;
    }
}