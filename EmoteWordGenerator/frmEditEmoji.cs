using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmoteWordGenerator
{
    public partial class frmEditEmoji : Form
    {
        public frmEditEmoji()
        {
            InitializeComponent();
        }

        private void frmEditEmoji_Load(object sender, EventArgs e)
        {
            foreach(string emoji in frmMain.Emotes)
            {
                lstEmojis.Items.Add(emoji);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//exit form
        }

        private void lstEmojis_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;//enable edit
            btnDelete.Enabled = true;//enable delete
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete emote
            DialogResult drResult = MessageBox.Show("Are you sure you want to delete this emote from your list?", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (drResult == DialogResult.Yes)
            {
                string sEmoteToDel = lstEmojis.SelectedItem.ToString();
                frmMain.DeleteEmote(sEmoteToDel);

                lstEmojis.Items.Clear();//clear items
                foreach (string sEmote in frmMain.Emotes)
                {
                    lstEmojis.Items.Add(sEmote);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEmoji frmForm = new frmAddEmoji();
            frmAddEmoji.bAdding = true;
            frmForm.ShowDialog();

            lstEmojis.Items.Clear();//clear items
            foreach(string sEmote in frmMain.Emotes)
            {
                lstEmojis.Items.Add(sEmote);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAddEmoji frmForm = new frmAddEmoji();
            frmAddEmoji.bAdding = false;
            frmAddEmoji.sEditEmoji = lstEmojis.SelectedItem.ToString();
            frmForm.ShowDialog();
            lstEmojis.Items.Clear();//clear items

            foreach (string sEmote in frmMain.Emotes)
            {
                lstEmojis.Items.Add(sEmote);
            }
        }
    }
}
