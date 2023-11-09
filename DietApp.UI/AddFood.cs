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
    public partial class AddFood : Form
    {
        AppDBContext context = new AppDBContext();
        //List<Category> mealList;

        List<Meal> mealList;
        AppUser appUser;
        Meal meal;


        public AddFood()
        {
            InitializeComponent();
            appUser = new AppUser();

            //mealList = context.Categories.ToList();

            mealList = new List<Meal>() // TODO Bu liste deneme amaçlıdır. Context bağlantısı sonrası silinecektir. SQL bende hata verdiği için veritabanını kontrol etmeme izin vermiyor benim sistem.
            {
                new Meal {Name="Kahvaltı"}
            };

        }

        private int GetUserIDByEmail(string eMail)
        {
            AppUser appUser = context.AppUsers.FirstOrDefault(x => x.Email == eMail);
            if (appUser != null)
            {
                return appUser.ID;
            }
            else
                return 0;
        }


        private void AddProductByMeal(string eMail, string productName, string mealName, double calories, string imagePath)
        {

            int userID = GetUserIDByEmail(eMail);

        }


        private void AddFood_Load(object sender, EventArgs e)
        {
            FillCategory();
        }

        private void FillCategory()
        {
            cBoxMeal.Items.Clear();

            //cBoxMeal.DataSource = context.Categories.ToList(); // TODO veritabanı bağlantısı için.
            //cBoxMeal.DisplayMember = "Name";
            //cBoxMeal.ValueMember = "ID";
            //cBoxMeal.SelectedIndex = -1;
            //cBoxMeal.Text = "Kategori Seçin";
            cBoxMeal.Items.AddRange(mealList.Select(c => c.Name).ToArray());

        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            pBoxPicture.ImageLocation = fileDialog.FileName;
            pBoxPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            txtImagePath.Text = fileDialog.FileName;

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                meal = new Meal();
                Product product = new Product();

                string eMail = appUser.Email;
                product.Name = txtProductName.Text;
                product.Calory = Convert.ToInt32(nmrCalorie.Value);
                meal.Name = cBoxMeal.SelectedItem.ToString();
                string imagePath = txtImagePath.Text;

                AddProductByMeal(eMail, product.Name, meal.Name, product.Calory, imagePath);

                context.SaveChanges();

                MessageBox.Show("Yemek başarıyla eklendi.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
