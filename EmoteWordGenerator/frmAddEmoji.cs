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
    public partial class frmAddEmoji : Form
    {        
        public static bool bAdding = false;//if we are adding an emoji
        public static string sEditEmoji = "";//emoji we are editing
        public frmAddEmoji()
        {
            InitializeComponent();
        }

        private void frmAddEmoji_Load(object sender, EventArgs e)
        {
            if (bAdding)
            {
                this.Text = "Add Emoji";
                btnAction.Text = "&Add";
            }
            else
            {
                this.Text = "Edit Emoji";
                btnAction.Text = "&Save";
                txtEmoji.Text = sEditEmoji;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {

            string sEmoji = txtEmoji.Text.ToLower();

            if (bAdding)
            {
                //add emoji to list
                if (sEmoji.Length == 0)
                {
                    MessageBox.Show("You can't add a blank emoji!", "Invalid emoji to add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmoji.Focus();
                    return;//stop
                }
                frmMain.Emotes.Add(sEmoji);
                this.Close();
            }
            else
            {
                
                if (sEmoji.Length == 0)
                {
                    MessageBox.Show("If you want to delete the emoji, go to the previous screen and delete it.","Cannot delete emoji here.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;//stop
                }
                //find emoji we edited
                int iPlace = frmMain.Emotes.FindIndex(x => x.Equals(sEditEmoji));
                if (iPlace < 0)
                {
                    //we didn't find it
                    MessageBox.Show("We didn't find the emote to edit.");
                }
                else
                {
                    //we found it
                    frmMain.Emotes.RemoveAt(iPlace);
                    frmMain.Emotes.Add(sEmoji);
                    sEditEmoji = "";
                    this.Close();
                }
                
            }
        }
    }
}
