using System;
using System.IO;
using System.Windows.Forms;

namespace Corona
{
    public partial class Settings : Form
    {
        Scrapper scrapper = new Scrapper();
        public bool unmut = true;
        public string piesen;
        
        public Settings()
        {
            this.unmut = Properties.Settings.Default.unmut_save;      //načíta do premennej "unmut" uloženú hodnotu v Properties
            this.piesen = Properties.Settings.Default.piesen_save;    //načíta do premennej "piesen" uloženú hodnotu v Properties

            InitializeComponent();
            muteunmutelogo();
            vyber_piesen();
            
            linkLabel1.Text = scrapper.stranka;

        }

        public void vyber_piesen()   
        {
            string[] songsFiles = Directory.GetFiles("./Resources/", "*.wav");  //do premennej "" vypíše všetky súbory z priečinku Resources a príponou .wav
            comboBox1.Items.Clear();

            foreach (string file in songsFiles)
            {
                string tmpFile = file.Substring(12); // Remove the "./Resources/" part
                tmpFile = tmpFile.Substring(0, tmpFile.Length - 4); // Remove the  ".wav" part
                comboBox1.Items.Add(tmpFile);  //do comboboxu vypíše premennú "tmpFile"
            }
        }

        private void muteunmute_Click(object sender, EventArgs e) //ked sa klikne na tlacitko
        {
            if (unmut) //ked je premenná "unmut" true nastaví premennú "unmut" na false a vyvolá void "muteunmutelogo()"
            {
                unmut = false;
                muteunmutelogo();
            }
            else
            {
                unmut = true;
                muteunmutelogo();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            piesen = comboBox1.Text;  //do premennej piesen ulozi hodnotu ktoru vyberies v comboboxe
        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.unmut_save = unmut;      //do Properties nacita hodnotu z premennej "unmut"
            Properties.Settings.Default.piesen_save = piesen;    //do Properties nacita hodnotu z premennej "piesen"
            Properties.Settings.Default.Save();                  //ulozi vsetky Properties, takze ked sa program vypne a zapne hodnoty budu stale ulozene
            Close();                                             //zavrie okno Settings
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close(); //zavrie okno Settings
        }


        private void muteunmutelogo()   //ked je premenná unmut true nastaví obrazok unmute,ked nie nastaví obrazok mute
        {
            if (unmut)
            {
                this.muteunmute.Image = Properties.Resources.unmute;
            }
            else
            {
                this.muteunmute.Image = Properties.Resources.mute;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)   //ked sa klikne na link otvori sa stranka
        {
            System.Diagnostics.Process.Start(((LinkLabel)sender).Text);
        }
    }
}