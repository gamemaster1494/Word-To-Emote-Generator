using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmoteWordGenerator
{
    public partial class frmMain : Form
    {
        
        //setup word layout
        public static Dictionary<string, int[,]> Letters = new Dictionary<string, int[,]>();
        public static List<string> Emotes = new List<string>();
        public string sBackgroundEmote = "";//emote for the background
        public string sCharacterEmote = "";//emote for the character
        public string sPhrase = "";//phrase to generate

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //check that background is set
            if(cmbBackground.Text.Length == 0)
            {
                MessageBox.Show("No background emote was set!", "No background emote.", MessageBoxButtons.OK, MessageBoxIcon.Error);//show error
                cmbBackground.Focus();//focus text box
                return;//stop running
            }

            //check the character emote is set
            if(cmbCharacter.Text.Length == 0)
            {
                MessageBox.Show("No character emote was set!", "No character emote.", MessageBoxButtons.OK, MessageBoxIcon.Error);//show error
                cmbCharacter.Focus();//focus text box
                return;//stop running
            }

            //check the phrase is set
            if(txtPhrase.Text.Length == 0)
            {
                MessageBox.Show("Uh.... Didn't you want to generate something?","No phrase to generate.",MessageBoxButtons.OK, MessageBoxIcon.Error);//show error
                txtPhrase.Focus();//focus text box
                return;//stop running
            }

            //set vars with :
            sBackgroundEmote = AddCommaToFrontAndBack(cmbBackground.Text);
            sCharacterEmote = AddCommaToFrontAndBack(cmbCharacter.Text);

            //Set phrase
            sPhrase = txtPhrase.Text;

            string sConvertedPhrase = GeneratePhrase();
            System.Windows.Forms.Clipboard.SetText(sConvertedPhrase);//copy text to clipboard
            if (sConvertedPhrase.Length > 40000)
            {
                MessageBox.Show("Phrase coppied to clipboard. However, it's too long for slack!", "Done... But problems.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Phrase of " + sConvertedPhrase.Length + " characters copied to clipboard!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //load letters
            LoadLetters();
            //load emotes
            LoadEmotes();
        }
        
        public string AddCommaToFrontAndBack(string sEmote)
        {
            string sResult = sEmote;//set result var

            if (!sEmote.StartsWith(":"))
            {
                sResult = ":" + sEmote;//add : to beginning
            }

            if (!sEmote.EndsWith(":"))
            {
                sResult += ":";//add : to end
            }

            return sResult;//return result
        }//AddCommaToFrontAndBack()

        public string RemoveCommaFromFrontAndBack(string sEmote)
        {
            string sResult = sEmote;

            if (sResult.StartsWith(":"))
            {
                //remove : char from the start              
                sResult = sResult.TrimStart(':');
            }

            if (sResult.EndsWith(":"))
            {
                //Remove : char from  end
                sResult = sResult.TrimEnd(':');
            }

            return sResult;
        }//RemoveCommaFromFrontAndBack

        public void LoadLetters()
        {
            FileStream fsStream;//filestream
            StreamReader srReader;//stream reader
            try
            {
                fsStream = new FileStream("letterlayout.txt", FileMode.OpenOrCreate, FileAccess.Read);//load file stream
                srReader = new StreamReader(fsStream);//load stream reader


                string sKey = "";//key for the dictionary
                int[,] iValues = new int[5, 5];//holds the layout of the letter
                int iRowCount = 0;//row for storing ints
                string sLine = "";//holds line from reader
                sLine = srReader.ReadLine();//read first line
                while(sLine != null)
                {
                    if(sLine.Length == 1)
                    {
                        //start of a new character
                        if(sKey.Length > 0)
                        {
                            Letters.Add(sKey, iValues);//add setup to dictonary
                            iValues = new int[5, 5];//reset values
                        }
                        sKey = sLine;//set key
                        iRowCount = 0;//reset row
                    }//if start of character
                    else if (sLine.Length == 5)
                    {                        
                        for(int i = 0; i < 5; i++)
                        {                            
                            iValues[iRowCount, i] = int.Parse(sLine[i].ToString());//set layout int
                        }//for every layout int
                        iRowCount++;//increase row
                    }//if a layout row
                    sLine = srReader.ReadLine();//read next line
                }//for every line in the file
                Letters.Add(sKey, iValues);//add last entry
                srReader.Close();//close reader
                fsStream.Close();//close stream
            }
            catch (FormatException ex)
            {
                //show error
                MessageBox.Show("Invalid letter configuration file! Did you put a letter where a number should be?","Invalid letter format",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                //show error
                MessageBox.Show(ex.Message);
            }
        }//LoadLetters()

        public void LoadEmotes()
        {
            FileStream fsStream;
            StreamReader srReader;

            try
            {
                fsStream = new FileStream("emojilist.txt", FileMode.OpenOrCreate, FileAccess.Read);//create file stream
                srReader = new StreamReader(fsStream);//create stream reader

                string sLine = "";//holds line from file
                sLine = srReader.ReadLine();//read first line
                while(sLine != null)
                {
                    string sEmote = RemoveCommaFromFrontAndBack(sLine);//remove commas so it doesn't show up in the box and ruin sorting

                    Emotes.Add(sEmote);//add emote
                    cmbBackground.Items.Add(sEmote);
                    cmbCharacter.Items.Add(sEmote);

                    sLine = srReader.ReadLine();//read next line
                }//while not end of file

                srReader.Close();//close reader
                fsStream.Close();//close file stream
            }//try
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);//show issue
            }//catch
        }//LoadEmotes

        public void SaveEmotes()
        {
            FileStream fsStream;
            StreamWriter swWrite;

            try
            {
                fsStream = new FileStream("emojilist.txt", FileMode.Create, FileAccess.Write);
                swWrite = new StreamWriter(fsStream);

                foreach (string emoji in Emotes)
                {
                    swWrite.WriteLine(emoji);
                }

                swWrite.Close();
                fsStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string GeneratePhrase()
        {
            string sResult = "";//holds the result

            string[] sLines = new string[5];//5 lines for the output
            for(int i = 0; i < 5; i++)
            {
                //initilize sLines
                sLines[i] = "";
            }

            for(int i = 0; i < 5; i++)
            {
                //for each row of the result                
                for(int s = 0; s < sPhrase.Length; s++)
                {
                    //for each character in the phrase
                    sLines[i] += sBackgroundEmote;//set a spacer between every character for easy reading
                    int[,] iLayout = new int[5, 5];//holds the layout of the char we are looking for
                    string sLetter = sPhrase[s].ToString().ToUpper();//get the char we are looking for
                    if(Letters.TryGetValue(sLetter, out iLayout))
                    {
                        //we got the letter to generate
                        for(int x = 0; x < 5; x++)
                        {
                            //for every layout int
                            if(iLayout[i,x] == 0)
                            {
                                //write background
                                sLines[i] += sBackgroundEmote;
                            }
                            else
                            {
                                //write character
                                sLines[i] += sCharacterEmote;                                
                            }
                        }//for each layout int
                    }
                    else
                    {
                        //default write a space
                        sLines[i] += sBackgroundEmote;
                    }
                          
                }//for each character in the phrase
                sLines[i] += sBackgroundEmote;
            }//for each row of the result

            for(int i = 0; i < 5; i++)
            {
                //put spacer between each line
                sResult += sLines[i] + '\n';
            }
            return sResult;//return result
        }//GeneratePhrase()

        private void addEmoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditEmoji frmEmoji = new frmEditEmoji();
            frmEmoji.ShowDialog();
            SaveEmotes();
            Emotes.Clear();
            cmbBackground.Items.Clear();
            cmbCharacter.Items.Clear();
            LoadEmotes();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();//close the form
        }

        public static void DeleteEmote(string sEmoteToDelete)
        {
            Emotes.Remove(sEmoteToDelete);
        }
    }//class
}//namespace