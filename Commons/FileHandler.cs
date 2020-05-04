using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Commons
{
    public class FileHandler
    {
        private List<string> _titles;
        
        public FileHandler()
        {
            try
            {
                _titles = new List<string>();
                StreamReader sr = new StreamReader("lista.txt");

                string[] aux = sr.ReadToEnd().Split("\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
               
                for (int i = 0; i < aux.Length; i++)
                    _titles.Add(aux[i]);
            }
            catch (Exception exc){
                MessageBox.Show(exc.Message);
            }
            

        }
        public List<string> GetTitles()
        {
            return _titles;
        }
    }
}
