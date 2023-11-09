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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DietApp.UI
{
    public partial class CreatAccount : Form
    {

        AppDBContext context;
        public CreatAccount()
        {
            InitializeComponent();

        }

        private void CreatAccount_Load(object sender, EventArgs e)
        {
            new AppDBContext();
            this.CenterToScreen();
            //txtPassword.PasswordChar = '*';
            txtPassword.UseSystemPasswordChar = true;

        }

        private void ckbGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGoster.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;

            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        //private void btn_Click(object sender, EventArgs e)
        //{
        //    System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
        //    string btnName = btn.Tag.ToString();

        //    switch (btnName)
        //    {
        //        case "HesapOlustur": HesapOlustur(); break;

        //    }
        //}

        //private void HesapOlustur()
        //{
        //    AppDBContext context = new AppDBContext();

        //    AppUser appUser = new AppUser();
        //    Weight weight = new Weight();

        //    try
        //    {
        //        if (txtName.Text == string.Empty || txtLastname.Text == string.Empty)
        //        {
        //            MessageBox.Show("Lütfen adınızı ve soyadınız giriniz");
        //            return;
        //        }

        //        else if (!txtEmail.Text.Contains("@", StringComparison.OrdinalIgnoreCase))
        //        {
        //            MessageBox.Show("Lütfen doğru bir e-posta adresi giriniz.");
        //            txtEmail.Text = "";
        //            return;
        //        }

        //        else if (txtPassword.Text.Length < 8)
        //        {
        //            MessageBox.Show("Lütfen güvenliğiniz için en az 8 karakterli ve daha güvenli bir parola giriniz.");
        //            txtPassword.Text = "";
        //            return;
        //        }

        //        else if (dateBirthDate.Value == DateTime.Now)
        //        {
        //            MessageBox.Show("Lütfen geçerli bir doğum tarihi giriniz.");
        //            return;
        //        }

        //        else if (Convert.ToInt32(txtHeight.Text) > 220 && Convert.ToInt32(txtHeight.Text) < 40)
        //        {
        //            MessageBox.Show("Lütfen boyunuzu rakamlarla santimetre cinsinden doğru bir şekilde giriniz");
        //            return;

        //        }

        //        else if (Convert.ToInt32(txtTargetWeight.Text) > 200 && Convert.ToInt32(txtTargetWeight.Text) < 20)
        //        {
        //            MessageBox.Show("Lütfen hedef kilonuzu rakamlarla kilogram cinsinden doğru bir şekilde giriniz");
        //            return;
        //        }

        //        else if (!rdoErkek.Checked && !rdoKadin.Checked)
        //        {
        //            MessageBox.Show("Lütfen cinsiyetinizi seçiniz.");
        //            return;
        //        }


        //        else if (!ckbConditions.Checked)
        //        {
        //            MessageBox.Show("Lütfen şart ve koşulları okuyup, onaylayınız.");
        //            return;
        //        }

        //        else
        //        {
        //            appUser = new AppUser
        //            {
        //                Name = txtName.Text,
        //                Lastname = txtLastname.Text,
        //                Email = txtEmail.Text,
        //                Password = txtPassword.Text,
        //                Height = Convert.ToInt32(txtHeight.Text),
        //                TargetWeight = Convert.ToInt32(txtTargetWeight.Text),
        //                Gender = rdoErkek.Checked.ToString(),
        //                BirthDate = dateBirthDate.Value

        //            };

        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message + "Hatalı bir işlem gerçekleşti!");
        //    }


        //    context.AppUsers.Add(appUser);

        //    context.SaveChanges();
        //}



        private void btnHesapOlustur_Click(object sender, EventArgs e)
        {
            AppDBContext context = new AppDBContext();

            AppUser appUser = new AppUser();
            Weight weight = new Weight();

            try
            {
                var CheckPerson = context.AppUsers.Where(x => x.Email == txtEmail.Text).FirstOrDefault();   

                if(CheckPerson != null)
                {
                    MessageBox.Show("Bu e-posta adresi ile daha önce hesap oluşturulmuş.");
                    return;
                }


                if (txtName.Text == string.Empty || txtLastname.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen adınızı ve soyadınız giriniz");
                    return;
                }

                else if (!txtEmail.Text.Contains("@", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Lütfen doğru bir e-posta adresi giriniz.");
                    txtEmail.Text = "";
                    return;
                }

                else if (txtPassword.Text.Length < 8)
                {
                    MessageBox.Show("Lütfen güvenliğiniz için en az 8 karakterli ve daha güvenli bir parola giriniz.");
                    txtPassword.Text = "";
                    return;
                }

                else if (dateBirthDate.Value >= DateTime.Today)
                {
                    MessageBox.Show("Lütfen geçerli bir doğum tarihi giriniz.");
                    return;
                }

                else if(Convert.ToInt32(txtYas.Text) <0 || Convert.ToInt32(txtYas.Text) == null)
                {
                    MessageBox.Show("Lütfen boyunuzu rakamlarla santimetre cinsinden doğru bir şekilde giriniz");
                    return;
                }

                else if (Convert.ToInt32(txtHeight.Text) > 220 && Convert.ToInt32(txtHeight.Text) < 40)
                {
                    MessageBox.Show("Lütfen boyunuzu rakamlarla santimetre cinsinden doğru bir şekilde giriniz");
                    return;

                }

                else if (Convert.ToInt32(txtTargetWeight.Text) > 200 && Convert.ToInt32(txtTargetWeight.Text) < 20)
                {
                    MessageBox.Show("Lütfen hedef kilonuzu rakamlarla kilogram cinsinden doğru bir şekilde giriniz");
                    return;
                }

                else if (!rdoErkek.Checked && !rdoKadin.Checked)
                {
                    MessageBox.Show("Lütfen cinsiyetinizi seçiniz.");
                    return;
                }


                else if (!ckbConditions.Checked)
                {
                    MessageBox.Show("Lütfen şart ve koşulları okuyup, onaylayınız.");
                    return;
                }

                else
                {
                    appUser = new AppUser
                    {
                        Name = txtName.Text,
                        Lastname = txtLastname.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        Height = Convert.ToInt32(txtHeight.Text),
                        TargetWeight = Convert.ToInt32(txtTargetWeight.Text),
                        Gender = rdoErkek.Checked.ToString(),
                        BirthDate = dateBirthDate.Value,
                        AddedDate = DateTime.Today,


                    };
                    MessageBox.Show("Hesabınız başarıyla oluşturulmuştur.");
                    btnHesapOlustur.Enabled = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "Hatalı bir işlem gerçekleşti!");
            }


            context.AppUsers.Add(appUser);

            context.SaveChanges();

        }

        private void CreatAccountBack_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }


    }

}
