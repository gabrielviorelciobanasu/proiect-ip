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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelChooseFromComboBox = new System.Windows.Forms.Label();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxLogin.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.textBoxPassword);
            this.groupBoxLogin.Controls.Add(this.textBoxUser);
            this.groupBoxLogin.Controls.Add(this.labelPassword);
            this.groupBoxLogin.Controls.Add(this.labelUser);
            this.groupBoxLogin.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(296, 153);
            this.groupBoxLogin.TabIndex = 0;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Autentificare";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(101, 108);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 27);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(122, 68);
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
            this.labelPassword.Location = new System.Drawing.Point(22, 68);
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
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.labelChooseFromComboBox);
            this.groupBoxSearch.Controls.Add(this.comboBoxSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(376, 12);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(345, 153);
            this.groupBoxSearch.TabIndex = 1;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Cautare";
            this.groupBoxSearch.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(135, 108);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 27);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Cauta";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // labelChooseFromComboBox
            // 
            this.labelChooseFromComboBox.AutoSize = true;
            this.labelChooseFromComboBox.Location = new System.Drawing.Point(6, 34);
            this.labelChooseFromComboBox.Name = "labelChooseFromComboBox";
            this.labelChooseFromComboBox.Size = new System.Drawing.Size(100, 17);
            this.labelChooseFromComboBox.TabIndex = 1;
            this.labelChooseFromComboBox.Text = "Alege din lista:";
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(6, 61);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(333, 24);
            this.comboBoxSearch.TabIndex = 0;
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);

          
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(790, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrare";
            // 
            // MovieReviewApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 723);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.groupBoxLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MovieReviewApplication";
            this.Text = "Movie Review Application";
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label labelChooseFromComboBox;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

