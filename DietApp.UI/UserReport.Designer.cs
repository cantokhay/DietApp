namespace DietApp.UI
{
    partial class UserReport
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
            lblBurnedCalorie = new Label();
            lblTotalCalorie = new Label();
            groupBox3 = new GroupBox();
            lblFavouriteActivity = new Label();
            groupBox2 = new GroupBox();
            lblFavouriteProduct = new Label();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            columnHeader10 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label2 = new Label();
            label1 = new Label();
            dtpDateEnd = new DateTimePicker();
            btnDisplayList = new Button();
            lvActivities = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            lvMeals = new ListView();
            dtpDateBeginning = new DateTimePicker();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // lblBurnedCalorie
            // 
            lblBurnedCalorie.AutoSize = true;
            lblBurnedCalorie.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblBurnedCalorie.ForeColor = Color.Blue;
            lblBurnedCalorie.Location = new Point(63, 33);
            lblBurnedCalorie.Name = "lblBurnedCalorie";
            lblBurnedCalorie.Size = new Size(27, 29);
            lblBurnedCalorie.TabIndex = 0;
            lblBurnedCalorie.Text = "0";
            // 
            // lblTotalCalorie
            // 
            lblTotalCalorie.AutoSize = true;
            lblTotalCalorie.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalCalorie.ForeColor = Color.Green;
            lblTotalCalorie.Location = new Point(63, 35);
            lblTotalCalorie.Name = "lblTotalCalorie";
            lblTotalCalorie.Size = new Size(27, 29);
            lblTotalCalorie.TabIndex = 0;
            lblTotalCalorie.Text = "0";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTotalCalorie);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(565, 268);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(184, 71);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Alınan Toplam Kalori";
            // 
            // lblFavouriteActivity
            // 
            lblFavouriteActivity.AutoSize = true;
            lblFavouriteActivity.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFavouriteActivity.ForeColor = Color.Black;
            lblFavouriteActivity.Location = new Point(27, 41);
            lblFavouriteActivity.Name = "lblFavouriteActivity";
            lblFavouriteActivity.Size = new Size(129, 20);
            lblFavouriteActivity.TabIndex = 0;
            lblFavouriteActivity.Text = "Favori Aktivite";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblFavouriteActivity);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(549, 656);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(199, 88);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Favori Aktivite";
            // 
            // lblFavouriteProduct
            // 
            lblFavouriteProduct.AutoSize = true;
            lblFavouriteProduct.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblFavouriteProduct.ForeColor = Color.Black;
            lblFavouriteProduct.Location = new Point(19, 41);
            lblFavouriteProduct.Name = "lblFavouriteProduct";
            lblFavouriteProduct.Size = new Size(131, 20);
            lblFavouriteProduct.TabIndex = 0;
            lblFavouriteProduct.Text = "Favori Yiyecek";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblFavouriteProduct);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(564, 442);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(184, 88);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Favori Yiyecek";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblBurnedCalorie);
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(549, 355);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(201, 70);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "Yakılan Toplam Kalori";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Tarih";
            columnHeader10.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Aktivite";
            columnHeader6.Width = 92;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(90, 635);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 17;
            label2.Text = "Bitiş Tarihi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 567);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 16;
            label1.Text = "Başlangıç Tarihi";
            // 
            // dtpDateEnd
            // 
            dtpDateEnd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateEnd.Format = DateTimePickerFormat.Short;
            dtpDateEnd.Location = new Point(176, 635);
            dtpDateEnd.Name = "dtpDateEnd";
            dtpDateEnd.Size = new Size(145, 27);
            dtpDateEnd.TabIndex = 15;
            // 
            // btnDisplayList
            // 
            btnDisplayList.BackColor = Color.White;
            btnDisplayList.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisplayList.ForeColor = Color.Black;
            btnDisplayList.Location = new Point(58, 685);
            btnDisplayList.Name = "btnDisplayList";
            btnDisplayList.Size = new Size(263, 59);
            btnDisplayList.TabIndex = 14;
            btnDisplayList.Text = "Listele";
            btnDisplayList.UseVisualStyleBackColor = false;
            btnDisplayList.Click += btnDisplayList_Click;
            // 
            // lvActivities
            // 
            lvActivities.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader10 });
            lvActivities.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lvActivities.Location = new Point(58, 268);
            lvActivities.Margin = new Padding(3, 4, 3, 4);
            lvActivities.Name = "lvActivities";
            lvActivities.Size = new Size(318, 278);
            lvActivities.TabIndex = 12;
            lvActivities.UseCompatibleStateImageBehavior = false;
            lvActivities.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Yakılan Kalori";
            columnHeader7.Width = 125;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Tarih";
            columnHeader9.Width = 104;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Porsiyon";
            columnHeader4.Width = 68;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Alınan Kalori";
            columnHeader3.Width = 112;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Yemek Kategorisi";
            columnHeader11.Width = 129;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Yemek Adı";
            columnHeader1.Width = 122;
            // 
            // lvMeals
            // 
            lvMeals.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader11, columnHeader3, columnHeader4, columnHeader9 });
            lvMeals.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lvMeals.Location = new Point(58, 44);
            lvMeals.Margin = new Padding(3, 4, 3, 4);
            lvMeals.Name = "lvMeals";
            lvMeals.Size = new Size(691, 216);
            lvMeals.TabIndex = 11;
            lvMeals.UseCompatibleStateImageBehavior = false;
            lvMeals.View = View.Details;
            // 
            // dtpDateBeginning
            // 
            dtpDateBeginning.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateBeginning.Format = DateTimePickerFormat.Short;
            dtpDateBeginning.Location = new Point(176, 567);
            dtpDateBeginning.Name = "dtpDateBeginning";
            dtpDateBeginning.Size = new Size(145, 27);
            dtpDateBeginning.TabIndex = 13;
            // 
            // UserReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 785);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpDateEnd);
            Controls.Add(btnDisplayList);
            Controls.Add(lvActivities);
            Controls.Add(lvMeals);
            Controls.Add(dtpDateBeginning);
            Name = "UserReport";
            Text = "UserReport";
            Load += UserReport_Load_1;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBurnedCalorie;
        private Label lblTotalCalorie;
        private GroupBox groupBox3;
        private Label lblFavouriteActivity;
        private GroupBox groupBox2;
        private Label lblFavouriteProduct;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader6;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpDateEnd;
        private ListView lvActivities;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader1;
        private ListView lvMeals;
        private DateTimePicker dtpDateBeginning;
        private Button btnDisplayList;
    }
}