using System.Windows.Forms;
using System.Media;
using System;
using System.IO;

namespace Corona
{
    public partial class Form1 : Form
    {
        Scrapper scrapper = new Scrapper();
        Settings settings = new Settings();

        public Form1()
        {
            InitializeComponent();
            scrapper.scrappovat(); // pusti sa scrapovanie
            zobraz();              //nacitaju sa udaje do textovych poli
            hraj();               //pusti sa void hraj a podla nastavenia sa bud spusti alebo nespusti hudba


            foreach (string countryname in scrapper.countryname)  
            {
                comboBox1.Items.Add(countryname);                //do comboboxu prida zoznam krajín
               
            }
        }
        public void hraj()         //prehrava pesničky podla zvolenej skladby v nastaveniach a podla toho či je hudba mutnuta alebo nie
        {
            if (settings.unmut)
            {
                string folder = Directory.GetCurrentDirectory();
                if (Properties.Settings.Default.piesen_save == "Ring Around the Rosie")
                {
                    SoundPlayer sndPlayer = new SoundPlayer(folder + "\\Resources\\Ring Around the Rosie.wav");
                    sndPlayer.Play();
                }
                if (Properties.Settings.Default.piesen_save == "Coronavirus song")
                {
                    SoundPlayer sndPlayer = new SoundPlayer(folder + "\\Resources\\Coronavirus song.wav");
                    sndPlayer.Play();
                }
            }
        }

        public void zobraz() // nacíta udaje do textových polí
        {
            label1.Text = scrapper.nakazeny;
            label2.Text = scrapper.mrtvy;
            label3.Text = scrapper.vylieceny;

            label11.Text = scrapper.vybernakazeny;
            label12.Text = scrapper.vybermrtvy;
            label13.Text = scrapper.vybervylieceny;

            label7.Text = scrapper.vybercountry;
        }
                     
          
        private void settingsbutton_Click(object sender, System.EventArgs e)  //ked sa klikne na tlačidlo Nastavenia otvori sa okno nastavenia
        {
            Settings openSettings = new Settings();
            openSettings.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //ked si vyberies krajnu v comboboxe
        {
            scrapper.vybercountry = comboBox1.Text;        //do premennej ""scrapper.vybercountry sa nastavy vybrana krajna z comboboxu
            scrapper.scrappovat();                         //pusti sa scrapovanie
            zobraz();                                      //znovu sa nacitaju udaje do textovych polí
        }
    }
}
