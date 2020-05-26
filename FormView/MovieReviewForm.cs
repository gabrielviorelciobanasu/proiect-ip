/**************************************************************************
 *                                                                        *
 *  File:        MoviewReviewForm.cs                                      *
 *  Copyright:   (c) 2020, Aluculesei Pavel, Ciobanasu Gabriel-Viorel     *
 *  Description: Functionalite: autentificare, creare cont,               *
 *  cautare film/serial, afisare top, adaugare review.                    *       
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/




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

            CitireFilmeSeriale();
        }


        // Se adauga filmele si serialele din fisierul json in comboBoxTvProduct
        private void CitireFilmeSeriale()
        {
            try
            {
                if (!File.Exists("filmesiseriale.json"))
                {
                    throw new Exception("Eroare la citirea filmelor si serialelor!");
                }

                using (StreamReader r = new StreamReader("filmesiseriale.json"))
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
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        // 1. Prezinta informatii despre filmul/serialul ales
        // 2. Prezinta un top al filmelor/serialelor in functie de gen, criteriul top-ului: rating-ul
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

                    List<TvProduct> topTvProducts = tvProducts.OrderBy(tv => tv.AverageRating()).ToList();
                    topTvProducts.Reverse();

                    richTextBoxInfo.Text = "\t\t\t\t\t\tTop " + comboBoxTip.SelectedItem.ToString() + "e " + comboBoxGen.SelectedItem.ToString() + "\n\n";

                    int i = 1;
                    foreach (TvProduct aux in topTvProducts)
                    {
                        if (aux.GetGenre() == comboBoxGen.SelectedItem.ToString() && aux.MyGetType() == comboBoxTip.SelectedItem.ToString())
                        {
                            richTextBoxInfo.Text += i+"." + aux.GetName() + "\t\t" + aux.AverageRating() + "\n";
                            i++;
                        }
                    }
                }
                else
                {
                    throw new Exception("Selectati film sau selectati gen si tip pentru a cauta");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private bool reviewExists()
        {

            return true;
        }

        // Se adauga un review la serialul/filmul ales
        private void buttonAdaugareReview_Click(object sender, EventArgs e)
        {
            try
            {
                if (!connected)
                {
                    throw new Exception("Pentru a adauga review trebui sa fiti logati!");
                }

                if (!reviewExists())
                {
                    throw new Exception("Ati adaugat deja un review!");
                }


                int nota = Int32.Parse(numericNota.Value.ToString());
                string comentariu = richTextBoxComentariu.Text.Trim();

                if (comentariu == "")
                {
                    throw new Exception("Adaugati comentariu!");
                }
                string autor = labelUserAutentificat.Text;

                Review newReview = new Review(nota, comentariu, autor);
                auxTvProduct.AddReview(newReview);

                var aux = new JObject();
                aux["rating"] = nota;
                aux["comment"] = comentariu;
                aux["autor"] = autor;
                jsonObjTvProducts[comboBoxTvProduct.SelectedIndex]["reviews"].Add(aux);
                string output = JsonConvert.SerializeObject(jsonObjTvProducts, Formatting.Indented);
                File.WriteAllText("filmesiseriale.json", output);

                richTextBoxReviews.Text += newReview.MyToString();
                richTextBoxInfo.Text = auxTvProduct.MyToString();
                richTextBoxComentariu.Text = "";
                numericNota.Value = 1;
            }
            catch (Exception loginError)
            {
                MessageBox.Show(loginError.Message);
            }

        }

        // Se autentifica utilizatorul 
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("users.json"))
                {
                    throw new Exception("Eroare la citirea utilizatorilor!");
                }

                using (StreamReader r = new StreamReader("users.json"))
                {
                    json = r.ReadToEnd();
                    jsonObjUsers = JsonConvert.DeserializeObject(json);
                    var aux = JArray.Parse(json);
                    foreach (JObject jo in aux)
                    {
                        if (textBoxUser.Text == "" || textBoxPassword.Text == "")
                        {
                            throw new Exception("Campul de utilizator/parola este gol!");
                        }
                        else if (textBoxUser.Text == jo["user"].ToString() && HashString(textBoxPassword.Text) == jo["password"].ToString())
                        {
                            MessageBox.Show("Bine ai venit, " + jo["user"].ToString() + "!");
                            groupBoxUtilizatorAutentificat.Visible = true;
                            labelUserAutentificat.Text = textBoxUser.Text;
                            groupBoxAdaugareReview.Enabled = true;
                            connected = true;
                            r.Close();
                            return;
                        }
                    }
                    if (!connected)
                    {
                        throw new Exception("Nume/parola gresita!");
                    }
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        // Se creeaza cont
        private void buttonCreareCont_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("users.json"))
                {
                    throw new Exception("Eroare la citirea utilizatorilor!");
                }
                
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
                            throw new Exception("Utilizator existent!");
                        }
                    }
                }

                if (!userFound)
                {
                    if (textBoxUser.Text == "" || textBoxPassword.Text == "")
                    {
                        throw new Exception("Campul de utilizator/parola este gol!");
                    }

                    var newUser = new JObject();
                    newUser["user"] = textBoxUser.Text;
                    newUser["password"] = HashString(textBoxPassword.Text);
                    jsonObjUsers.Add(newUser);
                    string output = JsonConvert.SerializeObject(jsonObjUsers, Formatting.Indented);
                    File.WriteAllText("users.json", output);
                    MessageBox.Show("Utilizator adaugat!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        // Se genereaza un o valoare de hash a parolei utilizatorului
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
            comboBoxTvProduct.SelectedItem = null;
        }

        private void comboBoxTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTvProduct.SelectedItem = null;
        }

        private void comboBoxTvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxGen.SelectedItem = null;
            comboBoxTip.SelectedItem = null;
        }

        // Delogare utilizator
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

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
