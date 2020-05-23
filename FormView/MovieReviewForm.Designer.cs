using Commons;

namespace FormView
{
    partial class MovieReviewApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.groupBoxUtilizatorAutentificat = new System.Windows.Forms.GroupBox();
            this.labelUserAutentificat = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCreareCont = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.comboBoxTip = new System.Windows.Forms.ComboBox();
            this.labelGen = new System.Windows.Forms.Label();
            this.comboBoxGen = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelChooseFromComboBox = new System.Windows.Forms.Label();
            this.comboBoxTvProduct = new System.Windows.Forms.ComboBox();
            this.groupBoxAdaugareReview = new System.Windows.Forms.GroupBox();
            this.buttonAdaugareReview = new System.Windows.Forms.Button();
            this.richTextBoxComentariu = new System.Windows.Forms.RichTextBox();
            this.numericNota = new System.Windows.Forms.NumericUpDown();
            this.labelComentariu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNota = new System.Windows.Forms.Label();
            this.tabControlData = new System.Windows.Forms.TabControl();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.tabPageReview = new System.Windows.Forms.TabPage();
            this.richTextBoxReviews = new System.Windows.Forms.RichTextBox();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxUtilizatorAutentificat.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxAdaugareReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNota)).BeginInit();
            this.tabControlData.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            this.tabPageReview.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.groupBoxUtilizatorAutentificat);
            this.groupBoxLogin.Controls.Add(this.buttonCreareCont);
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxLogin.Controls.Add(this.textBoxUser);
            this.groupBoxLogin.Controls.Add(this.labelPassword);
            this.groupBoxLogin.Controls.Add(this.labelUser);
            this.groupBoxLogin.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(296, 171);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Autentificare";
            // 
            // groupBoxUtilizatorAutentificat
            // 
            this.groupBoxUtilizatorAutentificat.Controls.Add(this.labelUserAutentificat);
            this.groupBoxUtilizatorAutentificat.Controls.Add(this.buttonLogout);
            this.groupBoxUtilizatorAutentificat.Controls.Add(this.label2);
            this.groupBoxUtilizatorAutentificat.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUtilizatorAutentificat.Name = "groupBoxUtilizatorAutentificat";
            this.groupBoxUtilizatorAutentificat.Size = new System.Drawing.Size(296, 171);
            this.groupBoxUtilizatorAutentificat.TabIndex = 1;
            this.groupBoxUtilizatorAutentificat.TabStop = false;
            this.groupBoxUtilizatorAutentificat.Text = "Autentificare";
            this.groupBoxUtilizatorAutentificat.Visible = false;
            // 
            // labelUserAutentificat
            // 
            this.labelUserAutentificat.AutoSize = true;
            this.labelUserAutentificat.Location = new System.Drawing.Point(95, 43);
            this.labelUserAutentificat.Name = "labelUserAutentificat";
            this.labelUserAutentificat.Size = new System.Drawing.Size(36, 17);
            this.labelUserAutentificat.TabIndex = 5;
            this.labelUserAutentificat.Text = "user";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(98, 118);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 27);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logat ca:";
            // 
            // buttonCreareCont
            // 
            this.buttonCreareCont.Location = new System.Drawing.Point(25, 123);
            this.buttonCreareCont.Name = "buttonCreareCont";
            this.buttonCreareCont.Size = new System.Drawing.Size(96, 27);
            this.buttonCreareCont.TabIndex = 4;
            this.buttonCreareCont.Text = "Creare cont";
            this.buttonCreareCont.UseVisualStyleBackColor = true;
            this.buttonCreareCont.Click += new System.EventHandler(this.buttonCreareCont_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(165, 123);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 27);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(122, 73);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(139, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(122, 34);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(139, 22);
            this.textBoxUser.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(22, 73);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 17);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Parola:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(22, 34);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(67, 17);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Utilizator:";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.labelTip);
            this.groupBoxSearch.Controls.Add(this.comboBoxTip);
            this.groupBoxSearch.Controls.Add(this.labelGen);
            this.groupBoxSearch.Controls.Add(this.comboBoxGen);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.labelChooseFromComboBox);
            this.groupBoxSearch.Controls.Add(this.comboBoxTvProduct);
            this.groupBoxSearch.Location = new System.Drawing.Point(376, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(345, 171);
            this.groupBoxSearch.TabIndex = 1;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Cautare";
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(6, 123);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(32, 17);
            this.labelTip.TabIndex = 5;
            this.labelTip.Text = "Tip:";
            // 
            // comboBoxTip
            // 
            this.comboBoxTip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTip.FormattingEnabled = true;
            this.comboBoxTip.Items.AddRange(new object[] {
            "Film",
            "Serial"});
            this.comboBoxTip.Location = new System.Drawing.Point(8, 141);
            this.comboBoxTip.Name = "comboBoxTip";
            this.comboBoxTip.Size = new System.Drawing.Size(141, 24);
            this.comboBoxTip.TabIndex = 4;
            this.comboBoxTip.SelectedIndexChanged += new System.EventHandler(this.comboBoxTip_SelectedIndexChanged);
            // 
            // labelGen
            // 
            this.labelGen.AutoSize = true;
            this.labelGen.Location = new System.Drawing.Point(6, 70);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(39, 17);
            this.labelGen.TabIndex = 3;
            this.labelGen.Text = "Gen:";
            // 
            // comboBoxGen
            // 
            this.comboBoxGen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxGen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxGen.FormattingEnabled = true;
            this.comboBoxGen.Items.AddRange(new object[] {
            "Actiune",
            "Animatie",
            "Comedie",
            "Drama",
            "Horror",
            "Mister",
            "Sci-Fi",
            "Thriller"});
            this.comboBoxGen.Location = new System.Drawing.Point(9, 91);
            this.comboBoxGen.Name = "comboBoxGen";
            this.comboBoxGen.Size = new System.Drawing.Size(140, 24);
            this.comboBoxGen.TabIndex = 1;
            this.comboBoxGen.SelectedIndexChanged += new System.EventHandler(this.comboBoxGen_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(191, 106);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(120, 44);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Cauta";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelChooseFromComboBox
            // 
            this.labelChooseFromComboBox.AutoSize = true;
            this.labelChooseFromComboBox.Location = new System.Drawing.Point(5, 23);
            this.labelChooseFromComboBox.Name = "labelChooseFromComboBox";
            this.labelChooseFromComboBox.Size = new System.Drawing.Size(100, 17);
            this.labelChooseFromComboBox.TabIndex = 1;
            this.labelChooseFromComboBox.Text = "Alege din lista:";
            // 
            // comboBoxTvProduct
            // 
            this.comboBoxTvProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTvProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTvProduct.FormattingEnabled = true;
            this.comboBoxTvProduct.Location = new System.Drawing.Point(9, 43);
            this.comboBoxTvProduct.Name = "comboBoxTvProduct";
            this.comboBoxTvProduct.Size = new System.Drawing.Size(323, 24);
            this.comboBoxTvProduct.TabIndex = 0;
            this.comboBoxTvProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxTvProduct_SelectedIndexChanged);
            // 
            // groupBoxAdaugareReview
            // 
            this.groupBoxAdaugareReview.Controls.Add(this.buttonAdaugareReview);
            this.groupBoxAdaugareReview.Controls.Add(this.richTextBoxComentariu);
            this.groupBoxAdaugareReview.Controls.Add(this.numericNota);
            this.groupBoxAdaugareReview.Controls.Add(this.labelComentariu);
            this.groupBoxAdaugareReview.Controls.Add(this.label1);
            this.groupBoxAdaugareReview.Controls.Add(this.labelNota);
            this.groupBoxAdaugareReview.Enabled = false;
            this.groupBoxAdaugareReview.Location = new System.Drawing.Point(790, 12);
            this.groupBoxAdaugareReview.Name = "groupBoxAdaugareReview";
            this.groupBoxAdaugareReview.Size = new System.Drawing.Size(377, 171);
            this.groupBoxAdaugareReview.TabIndex = 2;
            this.groupBoxAdaugareReview.TabStop = false;
            this.groupBoxAdaugareReview.Text = "Adaugă review";
            // 
            // buttonAdaugareReview
            // 
            this.buttonAdaugareReview.Location = new System.Drawing.Point(155, 123);
            this.buttonAdaugareReview.Name = "buttonAdaugareReview";
            this.buttonAdaugareReview.Size = new System.Drawing.Size(75, 27);
            this.buttonAdaugareReview.TabIndex = 6;
            this.buttonAdaugareReview.Text = "Adaugă";
            this.buttonAdaugareReview.UseVisualStyleBackColor = true;
            this.buttonAdaugareReview.Click += new System.EventHandler(this.buttonAdaugareReview_Click);
            // 
            // richTextBoxComentariu
            // 
            this.richTextBoxComentariu.Location = new System.Drawing.Point(126, 70);
            this.richTextBoxComentariu.Name = "richTextBoxComentariu";
            this.richTextBoxComentariu.Size = new System.Drawing.Size(245, 36);
            this.richTextBoxComentariu.TabIndex = 5;
            this.richTextBoxComentariu.Text = "";
            // 
            // numericNota
            // 
            this.numericNota.Location = new System.Drawing.Point(126, 35);
            this.numericNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericNota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNota.Name = "numericNota";
            this.numericNota.Size = new System.Drawing.Size(120, 22);
            this.numericNota.TabIndex = 4;
            this.numericNota.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelComentariu
            // 
            this.labelComentariu.AutoSize = true;
            this.labelComentariu.Location = new System.Drawing.Point(26, 68);
            this.labelComentariu.Name = "labelComentariu";
            this.labelComentariu.Size = new System.Drawing.Size(84, 17);
            this.labelComentariu.TabIndex = 2;
            this.labelComentariu.Text = "Comentariu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(26, 34);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(42, 17);
            this.labelNota.TabIndex = 0;
            this.labelNota.Text = "Notă:";
            // 
            // tabControlData
            // 
            this.tabControlData.Controls.Add(this.tabPageInfo);
            this.tabControlData.Controls.Add(this.tabPageReview);
            this.tabControlData.Location = new System.Drawing.Point(12, 189);
            this.tabControlData.Name = "tabControlData";
            this.tabControlData.SelectedIndex = 0;
            this.tabControlData.Size = new System.Drawing.Size(1155, 531);
            this.tabControlData.TabIndex = 3;
            this.tabControlData.Visible = false;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.richTextBoxInfo);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(1147, 502);
            this.tabPageInfo.TabIndex = 0;
            this.tabPageInfo.Text = "Informații";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Enabled = false;
            this.richTextBoxInfo.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxInfo.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(1147, 506);
            this.richTextBoxInfo.TabIndex = 0;
            this.richTextBoxInfo.Text = "";
            // 
            // tabPageReview
            // 
            this.tabPageReview.Controls.Add(this.richTextBoxReviews);
            this.tabPageReview.Location = new System.Drawing.Point(4, 25);
            this.tabPageReview.Name = "tabPageReview";
            this.tabPageReview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReview.Size = new System.Drawing.Size(1147, 502);
            this.tabPageReview.TabIndex = 1;
            this.tabPageReview.Text = "Recenzii";
            this.tabPageReview.UseVisualStyleBackColor = true;
            // 
            // richTextBoxReviews
            // 
            this.richTextBoxReviews.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxReviews.Location = new System.Drawing.Point(3, 1);
            this.richTextBoxReviews.Name = "richTextBoxReviews";
            this.richTextBoxReviews.Size = new System.Drawing.Size(1148, 505);
            this.richTextBoxReviews.TabIndex = 0;
            this.richTextBoxReviews.Text = "";
            // 
            // MovieReviewApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 723);
            this.Controls.Add(this.tabControlData);
            this.Controls.Add(this.groupBoxAdaugareReview);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MovieReviewApplication";
            this.Text = "Movie Review Application";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxUtilizatorAutentificat.ResumeLayout(false);
            this.groupBoxUtilizatorAutentificat.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxAdaugareReview.ResumeLayout(false);
            this.groupBoxAdaugareReview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericNota)).EndInit();
            this.tabControlData.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            this.tabPageReview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxTvProduct;
        private System.Windows.Forms.Label labelChooseFromComboBox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxAdaugareReview;
        private System.Windows.Forms.TabControl tabControlData;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.TabPage tabPageReview;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.RichTextBox richTextBoxReviews;
        private System.Windows.Forms.Label labelComentariu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.RichTextBox richTextBoxComentariu;
        private System.Windows.Forms.NumericUpDown numericNota;
        private System.Windows.Forms.Button buttonAdaugareReview;
        private System.Windows.Forms.Button buttonCreareCont;
        private System.Windows.Forms.Label labelGen;
        private System.Windows.Forms.ComboBox comboBoxGen;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.ComboBox comboBoxTip;
        private System.Windows.Forms.GroupBox groupBoxUtilizatorAutentificat;
        private System.Windows.Forms.Label labelUserAutentificat;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label label2;
    }
}

