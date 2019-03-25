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
using MusicDataEF;

namespace MusicDB_withEF_
{
    public partial class SearchForm : Form
    {
        private Ganres ganre;
        private DBMusicEntities ctx;

        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(Ganres ganre)
        {
            InitializeComponent();
            this.ganre = ganre;
            Text = "Search in ganre: " + ganre.G_name;
            ctx = new DBMusicEntities();

            FindSongs();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            dGVSongs.Columns["sidDataGridViewTextBoxColumn"].Visible = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            ctx.Dispose();
        }

        private void FindSongs()
        {
            var unsaved = ctx.ChangeTracker.Entries<Songs>().Where(a => a.State != System.Data.Entity.EntityState.Unchanged).ToList();
            if(unsaved.Count != 0)
            {
                MessageBox.Show("Need to save changes");
            }
            else
            {
                ctx.Dispose();
                ctx = new DBMusicEntities();
                var needId = (from g in ctx.SongGanre where g.SG_ganreId == ganre.G_id select g.SG_songId).ToList();
                var query = (from s in ctx.Songs where needId.Contains(s.S_id) select s);
                if (!String.IsNullOrWhiteSpace(tBName.Text))
                {
                    query = query.Where(s => s.S_name.Contains(tBName.Text));
                }

                if (!String.IsNullOrWhiteSpace(tBAlbum.Text))
                {
                    query = query.Where(s => s.Albums.AL_name.Contains(tBAlbum.Text));
                }

                if (!String.IsNullOrWhiteSpace(tBArtist.Text))
                {
                    query = query.Where(s => s.Albums.Artists.A_name.Contains(tBArtist.Text));
                }
                query = query.Where(s => s.S_length > nUDLow.Value && s.S_length < nUDHigh.Value);
                query.Load();
                songsBindingSource.DataSource = ctx.Songs.Local.ToBindingList();
                ctx.Albums.Load();
                albumsBindingSource.DataSource = ctx.Albums.Local.ToBindingList();
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            FindSongs();
        }

    }
}
