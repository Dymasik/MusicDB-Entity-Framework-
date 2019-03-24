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
    public partial class EditPlayer : Form
    {
        private MusicDataEF.DBMusicEntities ctx;
        private MusicDataEF.MusicPlayers mp;

        public EditPlayer()
        {
            InitializeComponent();
        }

        public EditPlayer(MusicDataEF.MusicPlayers mp)
        {
            InitializeComponent();
            
            this.mp = mp;
            this.ctx = new MusicDataEF.DBMusicEntities();
            this.Text = "Edit mode of plyer " + mp.MP_name;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var query = (from c in ctx.ArtistPlayer where mp.MP_id == c.Ap_playerId select c);
            query.Load();
            this.ctx.Artists.Load();
            this.artistPlayerBindingSource.DataSource = this.ctx.ArtistPlayer.Local.ToBindingList();
            this.artistsBindingSource.DataSource = this.ctx.Artists.Local.ToBindingList();

            this.dGVEdit.Columns["aPidDataGridViewTextBoxColumn"].Visible = false;
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ctx.Dispose();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            artistPlayerBindingSource.RemoveCurrent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            var unsaved = ctx.ChangeTracker.Entries<MusicDataEF.ArtistPlayer>().Where(a => a.State != EntityState.Unchanged).ToList();
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
            int a_id = (int)cBArtist.SelectedValue;
            int mp_id = mp.MP_id;
            var exist = (from c in ctx.ArtistPlayer
                         where (a_id == c.AP_artId) && (mp_id == c.Ap_playerId)
                         select c).Any();
            if (exist)
            {
                MessageBox.Show("This player has already presented this artist");
            }
            else
            {
                MusicDataEF.ArtistPlayer ap = new MusicDataEF.ArtistPlayer();
                ap.AP_artId = a_id;
                ap.Ap_playerId = mp_id;
                ctx.ArtistPlayer.Add(ap);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }
    }
}
