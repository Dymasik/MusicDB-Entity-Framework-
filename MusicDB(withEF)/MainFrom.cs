using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MusicDataEF;

namespace MusicDB_withEF_
{
    public partial class MainFrom : Form
    {
        private MusicDataEF.DBMusicEntities ctx;

        public MainFrom()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ctx = new MusicDataEF.DBMusicEntities();
            ctx.MusicPlayers.Load();
            ctx.Artists.Load();
            ctx.Albums.Load();
            ctx.Songs.Load();
            ctx.Ganres.Load();
            ctx.Countries.Load();

            this.musicPlayerBindingSource.DataSource = ctx.MusicPlayers.Local.ToBindingList();
            this.artistsBindingSource.DataSource = ctx.Artists.Local.ToBindingList();
            this.countriesBindingSource.DataSource = ctx.Countries.Local.ToBindingList();
            this.albumsBindingSource.DataSource = ctx.Albums.Local.ToBindingList();
            this.songsBindingSource.DataSource = ctx.Songs.Local.ToBindingList();
            this.ganresBindingSource.DataSource = ctx.Ganres.Local.ToBindingList();

            this.dGVArtists.Columns["aidDataGridViewTextBoxColumn"].Visible = false;
            this.dGVAlbums.Columns["aLidDataGridViewTextBoxColumn"].Visible = false;
            this.dGVSongs.Columns["sidDataGridViewTextBoxColumn"].Visible = false;
            this.dGVGanres.Columns["gidDataGridViewTextBoxColumn"].Visible = false;
            this.dGVCountries.Columns["cidDataGridViewTextBoxColumn"].Visible = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ctx.Dispose();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {

        }

        private void bSPlayers_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void bDPlayers_Click(object sender, EventArgs e)
        {
            try
            {
                MusicPlayers mp = (MusicPlayers)dGVPlayers.CurrentRow.DataBoundItem;
                var artists = (from c in ctx.ArtistPlayer where (mp.MP_id == c.Ap_playerId) select c).Any();

                if (artists)
                {
                    DialogResult result = MessageBox.Show("Are you sure, you want to delete this player, you will have no chance to restore data?", "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        deletePlayer(mp);
                    }
                }
                else
                {
                    musicPlayerBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mistake of deleting music player", "Mistake");
            }
        }

        private void deletePlayer(MusicPlayers mp)
        {
            var needDelete = (from c in ctx.ArtistPlayer
                              where c.Ap_playerId == mp.MP_id
                              select c).ToArray();
            foreach(var s in needDelete)
            {
                ctx.ArtistPlayer.Remove(s);
            }
            ctx.MusicPlayers.Remove(mp);
        }

        private void bEPlayers_Click(object sender, EventArgs e)
        {
            MusicPlayers mp = (MusicPlayers)dGVPlayers.CurrentRow.DataBoundItem;
            EditPlayer frm = new EditPlayer(mp);
            frm.ShowDialog(this);

            frm.Dispose();
        }

        private void bAPlayers_Click(object sender, EventArgs e)
        {
            AddPlayers frm = new AddPlayers();
            frm.ShowDialog(this);
            frm.Dispose();
            ctx.MusicPlayers.Load();
        }
    }
}
