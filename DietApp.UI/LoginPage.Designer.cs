namespace DietApp.UI
{
    partial class LoginPage
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGirisYap = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblEposta = new Label();
            label1 = new Label();
            lblHosgeldiniz = new Label();
            label2 = new Label();
            lblHesapOlustur = new Label();
            lblParolamiUnuttum = new Label();
            SuspendLayout();
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(528, 372);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(100, 50);
            btnGirisYap.TabIndex = 0;
            btnGirisYap.Tag = "GirisYap";
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(481, 293);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(206, 27);
            txtPassword.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(481, 209);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 27);
            txtEmail.TabIndex = 1;
            // 
            // lblEposta
            // 
            lblEposta.AutoSize = true;
            lblEposta.BackColor = Color.Transparent;
            lblEposta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblEposta.Location = new Point(528, 176);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(113, 23);
            lblEposta.TabIndex = 2;
            lblEposta.Text = "Eposta Adresi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(552, 262);
            label1.Name = "label1";
            label1.Size = new Size(57, 23);
            label1.TabIndex = 2;
            label1.Text = "Parola";
            // 
            // lblHosgeldiniz
            // 
            lblHosgeldiniz.AutoSize = true;
            lblHosgeldiniz.BackColor = Color.Transparent;
            lblHosgeldiniz.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblHosgeldiniz.Location = new Point(454, 74);
            lblHosgeldiniz.Name = "lblHosgeldiniz";
            lblHosgeldiniz.Size = new Size(262, 50);
            lblHosgeldiniz.TabIndex = 2;
            lblHosgeldiniz.Text = "HOŞ GELDİNİZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(503, 454);
            label2.Name = "label2";
            label2.Size = new Size(141, 19);
            label2.TabIndex = 2;
            label2.Text = "Bir hesabınız yok mu?";
            // 
            // lblHesapOlustur
            // 
            lblHesapOlustur.AutoSize = true;
            lblHesapOlustur.BackColor = Color.Transparent;
            lblHesapOlustur.Cursor = Cursors.Hand;
            lblHesapOlustur.Font = new Font("Segoe UI", 10F, FontStyle.Underline, GraphicsUnit.Point);
            lblHesapOlustur.Location = new Point(514, 480);
            lblHesapOlustur.Name = "lblHesapOlustur";
            lblHesapOlustur.Size = new Size(118, 23);
            lblHesapOlustur.TabIndex = 2;
            lblHesapOlustur.Tag = "HesapOluştur";
            lblHesapOlustur.Text = "Hesap Oluştur";
            lblHesapOlustur.Click += lblHesapOlustur_Click;
            // 
            // lblParolamiUnuttum
            // 
            lblParolamiUnuttum.AutoSize = true;
            lblParolamiUnuttum.BackColor = Color.Transparent;
            lblParolamiUnuttum.Cursor = Cursors.Hand;
            lblParolamiUnuttum.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblParolamiUnuttum.Location = new Point(559, 323);
            lblParolamiUnuttum.Name = "lblParolamiUnuttum";
            lblParolamiUnuttum.Size = new Size(128, 20);
            lblParolamiUnuttum.TabIndex = 2;
            lblParolamiUnuttum.Tag = "ParolamıUnuttum";
            lblParolamiUnuttum.Text = "Parolamı Unuttum";
            lblParolamiUnuttum.Click += lblParolamiUnuttum_Click_1;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.keto_diet_with_salmon_avocado_eggs_nuts_seed_1006041_77;
            ClientSize = new Size(824, 586);
            Controls.Add(lblParolamiUnuttum);
            Controls.Add(lblHesapOlustur);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHosgeldiniz);
            Controls.Add(lblEposta);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(btnGirisYap);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(514, 480);
            Name = "LoginPage";
            Text = "Form1";
            Load += LoginPage_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGirisYap;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblEposta;
        private Label label1;
        private Label lblHosgeldiniz;
        private Label label2;
        private Label lblHesapOlustur;
        private Label lblParolamiUnuttum;
    }
}