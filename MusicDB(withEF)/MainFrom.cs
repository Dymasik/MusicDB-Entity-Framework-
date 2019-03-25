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

        private void bSArtists_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void bDArtists_Click(object sender, EventArgs e)
        {
            try
            {
                Artists artist = (Artists)dGVArtists.CurrentRow.DataBoundItem;
                var a_count = (from a in ctx.Albums
                               where a.AL_artId == artist.A_id
                               select a).Count();
                if (a_count > 0)
                {
                    MessageBox.Show("Impossible to delete, artist has albums", "Warning");
                }
                else
                {
                    var players = (from c in ctx.ArtistPlayer where (artist.A_id == c.AP_artId) select c).Any();

                    if (players)
                    {
                        DialogResult result = MessageBox.Show("Are you sure, you want to delete this artist, you will have no chance to restore data?", "Warning", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            deleteArtist(artist);
                        }
                    }
                    else
                    {
                        artistsBindingSource.RemoveCurrent();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error of deleting", "Error");
            }
        }

        private void deleteArtist(Artists artist)
        {
            var needDelete = (from c in ctx.ArtistPlayer
                              where c.AP_artId == artist.A_id
                              select c).ToArray();
            foreach (var s in needDelete)
            {
                ctx.ArtistPlayer.Remove(s);
            }
            ctx.Artists.Remove(artist);
        }

        private void dGVArtists_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

        }

        private void dGVAlbums_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

        }

        private void dGVSongs_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

        }

        private void bSAlbums_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void bDAlbums_Click(object sender, EventArgs e)
        {
            try
            {
                Albums album = (Albums)dGVAlbums.CurrentRow.DataBoundItem;
                var al_count = (from a in ctx.Songs
                               where a.S_albId == album.AL_id
                               select a).Count();
                if (al_count > 0)
                {
                    MessageBox.Show("Impossible to delete, album has songs", "Warning");
                }
                else
                {
                    albumsBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error of deleting", "Error");
            }
        }

        private void bSGanres_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void bDGanres_Click(object sender, EventArgs e)
        {
            try
            {
                Ganres ganre = (Ganres)dGVGanres.CurrentRow.DataBoundItem;
                var g_count = (from g in ctx.SongGanre
                                where g.SG_ganreId == ganre.G_id
                                select g).Count();
                if (g_count > 0)
                {
                    MessageBox.Show("Impossible to delete, ganre has songs", "Warning");
                }
                else
                {
                    ganresBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error of deleting information", "Error");
            }
        }

        private void bSCountries_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void bDCountries_Click(object sender, EventArgs e)
        {
            try
            {
                Countries country = (Countries)dGVCountries.CurrentRow.DataBoundItem;
                var c_count = (from c in ctx.Artists
                               where c.A_countryId == country.C_id
                               select c).Count();
                if (c_count > 0)
                {
                    MessageBox.Show("Impossible to delete, country has artists", "Warning");
                }
                else
                {
                    countriesBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error of deleting information", "Error");
            }
        }

        private void bSSongs_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void bDSongs_Click(object sender, EventArgs e)
        {
            try
            {
                Songs song = (Songs)dGVSongs.CurrentRow.DataBoundItem;
                var ganres = (from g in ctx.SongGanre where (song.S_id == g.SG_songId) select g).Any();

                if (ganres)
                {
                    DialogResult result = MessageBox.Show("Are you sure, you want to delete this song, you will have no chance to restore data?", "Warning", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        deleteSong(song);
                    }
                }
                else
                {
                    songsBindingSource.RemoveCurrent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error of deleting information", "Error");
            }
        }

        private void deleteSong(Songs song)
        {
            var needDelete = (from c in ctx.SongGanre
                              where song.S_id == c.SG_songId
                              select c).ToList();
            foreach (var s in needDelete)
            {
                ctx.SongGanre.Remove(s);
            }
            ctx.Songs.Remove(song);
        }

        private void bESongs_Click(object sender, EventArgs e)
        {
            Songs song = (Songs)dGVSongs.CurrentRow.DataBoundItem;
            EditSong frm = new EditSong(song);
            frm.ShowDialog(this);
            frm.Dispose();
        }

        private void bASongs_Click(object sender, EventArgs e)
        {
            AddSongs frm = new AddSongs();
            frm.ShowDialog(this);
            frm.Dispose();
            ctx.Songs.Load();
        }

        private void dGVGanres_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Ganres ganre = (Ganres)dGVGanres.CurrentRow.DataBoundItem;
            SearchForm frm = new SearchForm(ganre);
            frm.ShowDialog(this);
            frm.Dispose();
        }
    }
}
