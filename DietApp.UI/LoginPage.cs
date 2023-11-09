using DietApp.DAL.Context;
using DietApp.DATA;
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
    public partial class LoginPage : Form
    {
        AppDBContext context = new AppDBContext();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            txtPassword.PasswordChar = '*';
            AppDBContext context = new AppDBContext();

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            var user = context.AppUsers.FirstOrDefault(a => a.Email == email && a.Password == password);

            if (user != null)
            {
                MessageBox.Show("Giriş Başarılı");
                UserDashboard userDashboard = new UserDashboard();
                userDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola hatalı girildi.");
                txtEmail.Text = txtPassword.Text = "";
                return;
            }


            context.SaveChanges();
        }

        private void lblHesapOlustur_Click(object sender, EventArgs e)
        {
            CreatAccount creatAccount = new CreatAccount();
            creatAccount.Show();
            this.Hide();


        }


        private void lblParolamiUnuttum_Click(object sender, EventArgs e)
        {
            ResetPasswordPage resetPasswordPage = new ResetPasswordPage();
            resetPasswordPage.Show();
            this.Hide();
        }

        private void lblParolamiUnuttum_Click_1(object sender, EventArgs e)
        {
            ResetPasswordPage resetPasswordPage = new ResetPasswordPage();
            resetPasswordPage.Show();
            this.Hide();
        }

        private void LoginPage_Load_1(object sender, EventArgs e)
        {

        }
    }
    //private void btn_Click(object sender, EventArgs e)
    //{
    //    Button btn = (Button)sender;
    //    string btnName = btn.Tag.ToString();

    //    switch (btn.Tag)
    //    {
    //        case "GirisYap": GirisYap(); break;

    //    }
    //}


    //private void GirisYap()
    //{
    //    string email = txtEmail.Text.Trim();
    //    string password = txtPassword.Text.Trim();

    //    var user = context.AppUsers.FirstOrDefault(a => a.Email == email && a.Password == password);

    //    if (user != null)
    //    {
    //        MessageBox.Show("Giriş Başarılı");
    //        //HomePage homePage = new HomePage();
    //        //homePage.Show();
    //        //this.Hide();
    //    }
    //    else
    //    {
    //        MessageBox.Show("Kullanıcı adı veya parrola hatalı girildi.");
    //        txtEmail.Text = txtPassword.Text = "";
    //    }
    //    context.SaveChanges();
    //}

    //private void lblHesapOlustur_Click(object sender, EventArgs e)
    //{
    //    CreatAccount creatAccount = new CreatAccount();
    //    creatAccount.Show();
    //    this.Hide();


    //}

    //private void LoginPage_Load(object sender, EventArgs e)
    //{
    //    context = new AppDBContext();
    //    txtPassword.PasswordChar = '*';
    //    this.CenterToScreen();
    //}

    //private void lblParolamiUnuttum_Click(object sender, EventArgs e)
    //{
    //    ResetPasswordPage resetPasswordPage = new ResetPasswordPage();
    //    resetPasswordPage.Show();
    //    this.Hide();
    //}
}


