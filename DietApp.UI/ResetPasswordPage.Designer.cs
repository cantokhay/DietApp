namespace DietApp.UI
{
    partial class ResetPasswordPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordPage));
            lblEposta = new Label();
            txtEmail = new TextBox();
            btnGonder = new Button();
            label1 = new Label();
            pbxGeriLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbxGeriLogin).BeginInit();
            SuspendLayout();
            // 
            // lblEposta
            // 
            lblEposta.AutoSize = true;
            lblEposta.BackColor = Color.Transparent;
            lblEposta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblEposta.Location = new Point(126, 181);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(142, 23);
            lblEposta.TabIndex = 5;
            lblEposta.Text = "Eposta Adresiniz";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(88, 214);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 27);
            txtEmail.TabIndex = 4;
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(147, 299);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(100, 50);
            btnGonder.TabIndex = 3;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += btnGonder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 8.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(35, 135);
            label1.Name = "label1";
            label1.Size = new Size(426, 20);
            label1.TabIndex = 5;
            label1.Text = "Parolanızı yeniden oluşturmak  için e-posta adresinizi giriniz";
            // 
            // pbxGeriLogin
            // 
            pbxGeriLogin.BackColor = Color.Transparent;
            pbxGeriLogin.Image = (Image)resources.GetObject("pbxGeriLogin.Image");
            pbxGeriLogin.Location = new Point(12, 485);
            pbxGeriLogin.Name = "pbxGeriLogin";
            pbxGeriLogin.Size = new Size(64, 56);
            pbxGeriLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxGeriLogin.TabIndex = 6;
            pbxGeriLogin.TabStop = false;
            pbxGeriLogin.Click += pbxGeriLogin_Click;
            // 
            // ResetPasswordPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(922, 553);
            Controls.Add(pbxGeriLogin);
            Controls.Add(label1);
            Controls.Add(lblEposta);
            Controls.Add(txtEmail);
            Controls.Add(btnGonder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ResetPasswordPage";
            Text = "_03_FormParolamiUnuttum";
            Load += ResetPasswordPage_Load;
            ((System.ComponentModel.ISupportInitialize)pbxGeriLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEposta;
        private TextBox txtEmail;
        private Button btnGonder;
        private Label label1;
        private PictureBox pbxGeriLogin;
    }
}