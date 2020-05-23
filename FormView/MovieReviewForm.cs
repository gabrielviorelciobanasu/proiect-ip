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
using System.Security.Cryptography;

namespace FormView
{
    public partial class MovieReviewApplication : Form
    {
        List<TvProduct> tvProducts;
        TvProduct auxTvProduct;
        string json;
        dynamic jsonObjTvProducts;
        dynamic jsonObjUsers;
        bool connected = false;

        public MovieReviewApplication()
        {
            InitializeComponent();
            this.MaximizeBox = false;


            tvProducts = new List<TvProduct>();

            ToJson();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            richTextBoxInfo.Text = "";
            richTextBoxReviews.Text = "";
            try
            {
                tabControlData.Visible = true;
               
                if (comboBoxTvProduct.SelectedItem != null)             // Cautare si afisare film
                {
                    if (!tabControlData.TabPages.Contains(tabPageReview))
                    {
                        tabControlData.TabPages.Add(tabPageReview);
                    }
                    

                    foreach (TvProduct aux in tvProducts)
                    {
                        if (aux.GetName() == comboBoxTvProduct.SelectedItem.ToString())
                        {
                            richTextBoxInfo.Text = aux.MyToString();
                            richTextBoxReviews.Text = aux.ReviewToString();
                            groupBoxAdaugareReview.Enabled = true;
                            auxTvProduct = aux;
                            break;
                        }
                    }
                }
                else if (comboBoxGen.SelectedItem != null && comboBoxTip.SelectedItem != null)       // afisare informatii despre genul tipului
                {
                    tabControlData.TabPages.Remove(tabPageReview);

                    List<TvProduct> topTvProducts = tvProducts.OrderBy(tv=>tv.AverageRating()).ToList();
                    topTvProducts.Reverse();

                    richTextBoxInfo.Text = "\t\t\t\t\t\tTop " + comboBoxTip.SelectedItem.ToString() + "e " + comboBoxGen.SelectedItem.ToString() + "\n\n";


                    int i = 1;
                    foreach (TvProduct aux in topTvProducts)
                    {
                        if (aux.GetGenre() == comboBoxGen.SelectedItem.ToString() && aux.MyGetType() == comboBoxTip.SelectedItem.ToString())
                        {

                            richTextBoxInfo.Text += string.Format("{0,0}. {1, 10}  - {2, 10} \n",i, aux.GetName(), aux.AverageRating());
                            i++;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selectati film sau selectati gen si tip pentru a cauta!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Alege film/serial!");
            }


        }

        private void ToJson()
        {
            using (StreamReader r = new StreamReader("lista.json"))
            {
                json = r.ReadToEnd();
                jsonObjTvProducts = JsonConvert.DeserializeObject(json);
                var aux = JArray.Parse(json);
                TvProduct type;
                foreach (JObject jo in aux)
                {
                    comboBoxTvProduct.Items.Add(jo["name"]);
                    if (jo["type"].ToString() == "Film")
                    {
                        type = JsonConvert.DeserializeObject<Movie>(jo.ToString());
                        tvProducts.Add(type);
                    }
                    else
                    {
                        type = JsonConvert.DeserializeObject<TvShow>(jo.ToString());
                        tvProducts.Add(type);
                    }
                    //auxTvProduct = type;
                }
            }
        }

        private void buttonAdaugareReview_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                int nota = Int32.Parse(numericNota.Value.ToString());
                string comentariu = richTextBoxComentariu.Text;
                string autor = labelUserAutentificat.Text;

                Review newReview = new Review(nota, comentariu, autor);
                auxTvProduct.AddReview(newReview);

                var aux = new JObject();
                aux["rating"] = nota;
                aux["comment"] = comentariu;
                aux["autor"] = autor;
                jsonObjTvProducts[comboBoxTvProduct.SelectedIndex]["reviews"].Add(aux);
                string output = JsonConvert.SerializeObject(jsonObjTvProducts, Formatting.Indented);
                File.WriteAllText("lista.json", output);

                richTextBoxReviews.Text += newReview.MyToString();
                richTextBoxInfo.Text = auxTvProduct.MyToString();
            }
            else
            {
                MessageBox.Show("Pentru a adauga review trebuie sa fiti logat!");
            }

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader("users.json"))
            {
                json = r.ReadToEnd();
                jsonObjUsers = JsonConvert.DeserializeObject(json);
                var aux = JArray.Parse(json);
                foreach (JObject jo in aux)
                {
                    if (textBoxUser.Text == jo["user"].ToString() && HashString(textBoxPassword.Text) == jo["password"].ToString())
                    {
                        MessageBox.Show("Bine ai venit, " + jo["user"].ToString() + "!");
                        groupBoxUtilizatorAutentificat.Visible = true;
                        labelUserAutentificat.Text = textBoxUser.Text;
                        groupBoxAdaugareReview.Enabled = true;
                        connected = true;
                        //r.Close();
                        break;
                    }
                }
                if (!connected)
                {
                    MessageBox.Show("Utilizatorul nu exista!");
                }
                textBoxPassword.Text = textBoxUser.Text = "";

                //r.Close();
            }
        }

        private void buttonCreareCont_Click(object sender, EventArgs e)
        {
            bool userFound = false;
            using (StreamReader r = new StreamReader("users.json"))
            {
                json = r.ReadToEnd();
                jsonObjUsers = JsonConvert.DeserializeObject(json);
                var aux = JArray.Parse(json);
                foreach (JObject jo in aux)
                {
                    if (textBoxUser.Text == jo["user"].ToString())
                    {
                        userFound = true;
                        MessageBox.Show("Utilizator deja existent!");
                        break;
                    }
                }
            }

            if (!userFound)
            {
                //MessageBox.Show("user nu a fost gasit!");
                var newUser = new JObject();
                newUser["user"] = textBoxUser.Text;
                newUser["password"] = HashString(textBoxPassword.Text);
                jsonObjUsers.Add(newUser);
                string output = JsonConvert.SerializeObject(jsonObjUsers, Formatting.Indented);
                File.WriteAllText("users.json", output);
                MessageBox.Show("Utilizator adaugat!");
            }
            textBoxPassword.Text = textBoxUser.Text = "";
            //MessageBox.Show("Utilizator adaugat!");
        }

        public string HashString(string str)
        {
            HashAlgorithm sha = new SHA1CryptoServiceProvider();
            byte[] buf = new byte[str.Length];
            for (int i = 0; i < str.Length; i++)
                buf[i] = (byte)str[i];
            byte[] result = sha.ComputeHash(buf);
            return Convert.ToBase64String(result);
        }

        private void comboBoxGen_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if(comboBoxTvProduct.SelectedItem != null)
           // {
                comboBoxTvProduct.SelectedItem = null;
           // }
        }

        private void comboBoxTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxTvProduct.SelectedItem != null)
            //{
                comboBoxTvProduct.SelectedItem = null;
            //}
        }

        private void comboBoxTvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxGen.SelectedItem != null || comboBoxTip.SelectedItem != null)
           // {
                comboBoxGen.SelectedItem = null;
                comboBoxTip.SelectedItem = null;
            //}
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            connected = false;
            groupBoxAdaugareReview.Enabled = false;
            groupBoxLogin.Visible = true;
            groupBoxUtilizatorAutentificat.Visible = false;
            richTextBoxInfo.Text = "";
            richTextBoxReviews.Text = "";
            richTextBoxComentariu.Text = "";
        }
    }
}

