using DietApp.DAL.Context;
using DietApp.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UserReport : Form
    {
        AppUser appUser;

        List<Product> userMealList;

        List<Activity> userActivityList;

        AppDBContext context = new AppDBContext();
        public UserReport()
        {
            InitializeComponent();
        }


        private void UserReport_Load(object sender, EventArgs e)
        {

        }


        private void btnDisplayList_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dtpDateBeginning.Value.Date;
                DateTime endDate = dtpDateEnd.Value.Date;
                int userId = 2;


                FillMealList(userId, startDate, endDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

            GetTotalCalorie();
            GetTotalBurnedCalorie();
        }


        private void GetTotalBurnedCalorie()
        {
            double totalBurnedCalorie = 0;

            foreach (ListViewItem item in lvActivities.Items)
            {
                double burnedCalorie = 0;
                if (double.TryParse(item.SubItems[1].Text, out burnedCalorie))
                {
                    totalBurnedCalorie += burnedCalorie;
                }
            }

            lblBurnedCalorie.Text = totalBurnedCalorie.ToString();
        }

        private void GetTotalCalorie()
        {
            double totalCalorie = 0;

            foreach (ListViewItem item in lvMeals.Items)
            {

                double calorie = 0;
                if (double.TryParse(item.SubItems[2].Text, out calorie))
                {
                    totalCalorie += calorie;
                }
            }


            lblTotalCalorie.Text = totalCalorie.ToString();
        }




        public List<Product> GetUserProducts(int userId, DateTime startDate, DateTime endDate)
        {
            try
            {
                using (var context = new AppDBContext())
                {
                    var userProducts = context.AppUsers
                        .Where(u => u.ID == userId)
                        .SelectMany(u => u.Products)
                        .Where(p => p.AddedDate >= startDate && p.AddedDate <= endDate)
                        .ToList();

                    return userProducts;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return new List<Product>();
            }
        }

        private void FillMealList(int userId, DateTime startDate, DateTime endDate)
        {
            try
            {
                lvMeals.Items.Clear();

                List<Product> userProducts = GetUserProducts(userId, startDate, endDate); // Database olunca veri gelmiyor

                //                    new List<Product> // Bu şekilde direkt listeden çekince çalışıyor.
                //{
                //    new Product
                //    {
                //        Name = "Ürün 1",
                //        Category = new Category { Name = "Kategori 1" },
                //        Calory = 100,
                //        PortionGram = 200,
                //        AddedDate = DateTime.Now
                //    },
                //    new Product
                //    {
                //        Name = "Ürün 2",
                //        Category = new Category { Name = "Kategori 2" },
                //        Calory = 150,
                //        PortionGram = 250,
                //        AddedDate = DateTime.Now.AddDays(-1)
                //    },

                //};



                foreach (Product item in userProducts)
                {
                    ListViewItem lvi2 = new ListViewItem();
                    lvi2.Text = item.Name;

                    if (item.Category != null)
                    {
                        lvi2.SubItems.Add(item.Category.Name);
                    }
                    else
                    {
                       
                        lvi2.SubItems.Add("Belirtilmemiş");
                    }

                    lvi2.SubItems.Add(item.Calory.ToString());
                    lvi2.SubItems.Add(item.PortionGram.ToString());
                    lvi2.SubItems.Add(item.AddedDate.ToString());

                    lvMeals.Items.Add(lvi2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }






        private List<Activity> GetActivityDetailsByDate(DateTime date1, DateTime date2, AppUser user)
        {
            userActivityList = context.Activities
                .Where(item =>
                    item.AddedDate >= date1 &&
                    item.AddedDate <= date2 &&
                    item.AppUser.ID == user.ID)
                .ToList();

            return userActivityList;
        }


        private void FillActivityList(List<Activity> activityDetails)
        {
            lvActivities.Items.Clear();

            foreach (Activity item in userActivityList)
            {
                ListViewItem lvi3 = new ListViewItem();
                lvi3.Text = item.Name;
                lvi3.SubItems.Add(item.AvgCalories.ToString());
                lvi3.SubItems.Add(item.AddedDate.ToString());
                lvActivities.Items.Add(lvi3);
            }
        }

        private void UserReport_Load_1(object sender, EventArgs e)
        {

        }
    }
}
