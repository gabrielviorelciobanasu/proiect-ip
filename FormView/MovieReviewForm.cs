using Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormView
{
    public partial class MovieReviewApplication : Form
    {
        FileHandler _fileHandler = new FileHandler();


        public MovieReviewApplication()
        {
            InitializeComponent();


            foreach (string a in _fileHandler.GetTitles())
            {
                comboBoxSearch.Items.Add(a);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
