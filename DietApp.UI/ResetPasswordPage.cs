using DietApp.DAL.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietApp.UI
{
    public partial class ResetPasswordPage : Form
    {
        AppDBContext context = new AppDBContext();
        public ResetPasswordPage()
        {
            InitializeComponent();

        }

        private void ResetPasswordPage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            AppDBContext context = new AppDBContext();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();


            var user = context.AppUsers.FirstOrDefault(a => a.Email == email);
            if (user != null)
            {
                MessageBox.Show("Şifre sıfırlama linki mail adresinize gönderildi.");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola hatalı girildi.");
                txtEmail.Text = "";
                return;
            }
        }

        private void pbxGeriLogin_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }


    }
}
