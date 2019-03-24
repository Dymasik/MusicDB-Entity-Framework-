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
    public partial class AddSongs : Form
    {
        private MusicDataEF.DBMusicEntities ctx;

        public AddSongs()
        {
            InitializeComponent();
            ctx = new MusicDataEF.DBMusicEntities();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ctx.Albums.Load();
            ctx.Ganres.Load();
            albumsBindingSource.DataSource = ctx.Albums.Local.ToBindingList();
            ganresBindingSource.DataSource = ctx.Ganres.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ctx.Dispose();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if(tBName.Text != "" && nUDLength.Value > 0)
            {
                MusicDataEF.Songs song = new MusicDataEF.Songs();
                song.S_name = tBName.Text;
                song.S_length = (int)nUDLength.Value;
                song.S_albId = (int)cBAlbum.SelectedValue;
                ctx.Songs.Add(song);
                ctx.SaveChanges();
                foreach (var ganre in lBGanres.SelectedItems)
                {
                    MusicDataEF.SongGanre con = new MusicDataEF.SongGanre();
                    con.SG_ganreId = ((MusicDataEF.Ganres)ganre).G_id;
                    con.SG_songId = song.S_id;
                    ctx.SongGanre.Add(con);
                    ctx.SaveChanges();
                }
                Close();
            }
            else
            {
                MessageBox.Show("Wrong information");
            }
        }
    }
}
