using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicDB_withEF_
{
    public partial class EditSong : Form
    {
        private MusicDataEF.DBMusicEntities ctx;
        private MusicDataEF.Songs song;

        public EditSong()
        {
            InitializeComponent();
        }

        public EditSong(MusicDataEF.Songs song)
        {
            InitializeComponent();
            ctx = new MusicDataEF.DBMusicEntities();
            this.song = song;
            this.Text = "Edit of song: " + song.S_name;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var query = (from c in ctx.SongGanre where song.S_id == c.SG_songId select c);
            query.Load();
            ctx.Ganres.Load();
            ganresBindingSource.DataSource = ctx.Ganres.Local.ToBindingList();
            songGanreBindingSource.DataSource = ctx.SongGanre.Local.ToBindingList();

            this.dGVEdit.Columns["sGidDataGridViewTextBoxColumn"].Visible = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            var unsaved = ctx.ChangeTracker.Entries<MusicDataEF.SongGanre>().Where(a => a.State != EntityState.Unchanged).ToList();
            if (unsaved.Count != 0)
            {
                DialogResult result = MessageBox.Show("The data has been not saved yet, do you want to save?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ctx.SaveChanges();
                }
            }
            ctx.Dispose();
        }

        private void dGVEdit_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            songGanreBindingSource.RemoveCurrent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            var unsaved = ctx.ChangeTracker.Entries<MusicDataEF.SongGanre>().Where(a => a.State != EntityState.Unchanged).ToList();
            if (unsaved.Count != 0)
            {
                DialogResult result = MessageBox.Show("The data has been not saved yet, do you want to save?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ctx.SaveChanges();
                }
                else
                {
                    return;
                }
            }
            int g_id = (int)cBGanres.SelectedValue;
            int s_id = song.S_id;
            var exist = (from c in ctx.SongGanre
                         where (g_id == c.SG_ganreId) && (s_id == c.SG_songId)
                         select c).Any();
            if (exist)
            {
                MessageBox.Show("This song has already had this ganre");
            }
            else
            {
                MusicDataEF.SongGanre sg = new MusicDataEF.SongGanre();
                sg.SG_songId = s_id;
                sg.SG_ganreId = g_id;
                ctx.SongGanre.Add(sg);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }
    }
}
