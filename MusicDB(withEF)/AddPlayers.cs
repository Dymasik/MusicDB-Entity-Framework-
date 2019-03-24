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
    public partial class AddPlayers : Form
    {
        private MusicDataEF.DBMusicEntities ctx;

        public AddPlayers()
        {
            InitializeComponent();
            ctx = new MusicDataEF.DBMusicEntities();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ctx.Artists.Load();
            artistsBindingSource.DataSource = ctx.Artists.Local.ToBindingList();
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
            if (tBName.Text != "")
            {
                MusicDataEF.MusicPlayers mp = new MusicDataEF.MusicPlayers();
                mp.MP_name = tBName.Text;
                ctx.MusicPlayers.Add(mp);
                ctx.SaveChanges();
                foreach(var art in lBArtist.SelectedItems)
                {
                    MusicDataEF.ArtistPlayer con = new MusicDataEF.ArtistPlayer();
                    //DataRowView drv = (DataRowView)lBArtist.Items[(int)id];
                    //artists.Add((int)drv["A_id"]);
                    //MessageBox.Show(id.ToString() + " " + drv["A_id"].ToString());
                    con.AP_artId = ((MusicDataEF.Artists)art).A_id;
                    con.Ap_playerId = mp.MP_id;
                    ctx.ArtistPlayer.Add(con);
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
