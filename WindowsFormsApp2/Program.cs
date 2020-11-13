using System;
using System.Windows.Forms;


namespace Corona
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       
            [STAThread]
       
           
            
            static void Main()
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());                             //spusti okno Form1

            
        }
    }
}

