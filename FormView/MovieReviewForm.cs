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
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace FormView
{
    public partial class MovieReviewApplication : Form
    {
        List<TvProduct> tvProducts;
        RichTextBox info, review;


        public MovieReviewApplication()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            tvProducts = new List<TvProduct>();
            info = new RichTextBox();
            review = new RichTextBox();

            ToJson();

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            tabControlData.Visible = true;

            info.Text = "";

            info.Width = tabControlData.Width;
            info.Height = tabControlData.Height;
            info.Font = new Font("Calibri", 20, FontStyle.Regular);

            review.Width = tabControlData.Width;
            review.Height = tabControlData.Height;
            review.Font = new Font("Calibri", 20, FontStyle.Regular);

            tabPageReview.Controls.Add(review);
     
            foreach(TvProduct aux in tvProducts)
            {
                if (aux.GetName() == comboBoxSearch.SelectedItem.ToString())
                {
                    info.Text = aux.MyToString();
                    tabPageInfo.Controls.Add(info);
                }
            }
        }

        private void ToJson()
        {
            string json;
            using (StreamReader r = new StreamReader("lista2.json"))
            {
                json = r.ReadToEnd();
                var aux = JArray.Parse(json);
                foreach (JObject jo in aux)
                {
                    comboBoxSearch.Items.Add(jo["name"]);
                    if (jo["type"].ToString() == "film")
                    {
                        Movie movie = JsonConvert.DeserializeObject<Movie>(jo.ToString());
                        tvProducts.Add(movie); 
                    }
                    else
                    {
                        TvShow show = JsonConvert.DeserializeObject<TvShow>(jo.ToString());
                        tvProducts.Add(show);
                    }
                }
            }
        }
    }
}
    