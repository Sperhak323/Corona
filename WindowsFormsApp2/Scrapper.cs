using HtmlAgilityPack;
using System.Collections.Generic;

namespace Corona
{
   public class Scrapper
    {


        public string stranka = ("https://www.worldometers.info/coronavirus/");
        public string country = ("Slovakia");
        public string nakazeny;
        public string mrtvy;
        public string vylieceny;
        public string aktivny;

        public string vybercountry = ("World");
        public string vybernakazeny;
        public string vybermrtvy;
        public string vybervylieceny;

        public List<string> countryname;  //aby sa vedelo nacitat viac dat do jedneho stringu
       



        public Scrapper()
        {
            
        }
        
        public void scrappovat()
        {

            countryname = new List<string>();
          
            // cele to sluzi nato aby nacitalo data z tabulky na internetovej stranke.Vyhlada hodnotu v nultom stlpci tabulky co je krajna a vypise k danej krajne 
            // udaje ktore su v riadku danej krajny

            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument document = htmlWeb.Load(stranka);
            HtmlNodeCollection rows = document.DocumentNode.SelectNodes("//*[@id=\"main_table_countries_today\"]/tbody[1]/tr");

            {
                

                foreach (HtmlNode row in rows)
                    {
                    
                    HtmlNodeCollection  columns = row.SelectNodes("td");
                        countryname.Add(columns[1].InnerText);           //do premennej nacita vsetky hodnoty z tabulky z prveho stlpca co su krajny




                    if (columns[1].InnerText == country)             //ked sa hodnota v stlpci 0 rovná hodnote v premennej country
                        {
                            nakazeny = columns[2].InnerText;         //do premennej nacita hodnotu z tabulky zo stlpca
                            mrtvy = columns[4].InnerText;            //do premennej nacita hodnotu z tabulky zo stlpca
                            vylieceny = columns[6].InnerText;         //do premennej nacita hodnotu z tabulky zo stlpca
                            aktivny = columns[8].InnerText;         //do premennej nacita hodnotu z tabulky zo stlpca
                    }

                        if (columns[1].InnerText == vybercountry)
                        {
                            vybernakazeny = columns[2].InnerText;   //do premennej nacita hodnotu z tabulky zo stlpca
                            vybermrtvy = columns[4].InnerText;      //do premennej nacita hodnotu z tabulky zo stlpca
                            vybervylieceny = columns[6].InnerText;  //do premennej nacita hodnotu z tabulky zo stlpca


                    }
 
                }           
            }
        }
    }

}




              









    

