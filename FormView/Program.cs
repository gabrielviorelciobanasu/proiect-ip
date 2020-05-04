using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Commons;

namespace FormView
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MovieReviewApplication());

            //Commons.Type[] types = new Commons.Type[3];
            //types[0] = new Movie("Rambo 3", 1997, "Action", 122, "Rambo omoara pe toti si toate!", null);
            //string aux = types[0].GetName() + " " + types[0].GetYear().ToString();
            //MessageBox.Show(aux);
        }
    }
}
