namespace DietApp.UI
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            panel1 = new Panel();
            lblUserTargetWeight = new Label();
            lblTargetWeigth = new Label();
            lblUserWeight = new Label();
            lblUserHeigth = new Label();
            lblWeight = new Label();
            lblHeigth = new Label();
            lblAge = new Label();
            lblFullName = new Label();
            panel2 = new Panel();
            lblUserConsumedCalorie = new Label();
            lblConsumedCalorie = new Label();
            lblUserCalorieToConsume = new Label();
            lblUserSpentCalorie = new Label();
            lblCalorieToConsume = new Label();
            lblSpentCalorie = new Label();
            panel3 = new Panel();
            lblActivityDurationTotal = new Label();
            lbActivitylDuration2 = new Label();
            lblActivity2 = new Label();
            lbActivitylDuration1 = new Label();
            lblActivity1 = new Label();
            lblToday = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand3 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand4 = new Microsoft.Data.SqlClient.SqlCommand();
            lblAddBreakfast = new Label();
            grpBreakfast = new GroupBox();
            pBoxBreakfast = new PictureBox();
            grpLunch = new GroupBox();
            pBoxLunch = new PictureBox();
            lblAddLunch = new Label();
            grpDinner = new GroupBox();
            pboxDinner = new PictureBox();
            lblAddDinner = new Label();
            grpSnack = new GroupBox();
            pBoxSnack = new PictureBox();
            lblAddSnack = new Label();
            pBoxSettings = new PictureBox();
            grpActivity = new GroupBox();
            pBoxActivity = new PictureBox();
            lblAddActivity = new Label();
            grpWater = new GroupBox();
            nmrWater = new NumericUpDown();
            pictureBox1 = new PictureBox();
            lblConsumedWater = new Label();
            label1 = new Label();
            btnDisplayReport = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            grpBreakfast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxBreakfast).BeginInit();
            grpLunch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxLunch).BeginInit();
            grpDinner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pboxDinner).BeginInit();
            grpSnack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxSnack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSettings).BeginInit();
            grpActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxActivity).BeginInit();
            grpWater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrWater).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblUserTargetWeight);
            panel1.Controls.Add(lblTargetWeigth);
            panel1.Controls.Add(lblUserWeight);
            panel1.Controls.Add(lblUserHeigth);
            panel1.Controls.Add(lblWeight);
            panel1.Controls.Add(lblHeigth);
            panel1.Controls.Add(lblAge);
            panel1.Controls.Add(lblFullName);
            panel1.Location = new Point(26, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 148);
            panel1.TabIndex = 0;
            // 
            // lblUserTargetWeight
            // 
            lblUserTargetWeight.AutoSize = true;
            lblUserTargetWeight.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserTargetWeight.Location = new Point(372, 103);
            lblUserTargetWeight.Name = "lblUserTargetWeight";
            lblUserTargetWeight.Size = new Size(99, 25);
            lblUserTargetWeight.TabIndex = 0;
            lblUserTargetWeight.Tag = "Kalori";
            lblUserTargetWeight.Text = "Hedef Kilo";
            // 
            // lblTargetWeigth
            // 
            lblTargetWeigth.AutoSize = true;
            lblTargetWeigth.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTargetWeigth.Location = new Point(372, 58);
            lblTargetWeigth.Name = "lblTargetWeigth";
            lblTargetWeigth.Size = new Size(99, 25);
            lblTargetWeigth.TabIndex = 0;
            lblTargetWeigth.Text = "Hedef Kilo";
            // 
            // lblUserWeight
            // 
            lblUserWeight.AutoSize = true;
            lblUserWeight.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserWeight.Location = new Point(93, 103);
            lblUserWeight.Name = "lblUserWeight";
            lblUserWeight.Size = new Size(44, 25);
            lblUserWeight.TabIndex = 0;
            lblUserWeight.Tag = "Kalori";
            lblUserWeight.Text = "Kilo";
            // 
            // lblUserHeigth
            // 
            lblUserHeigth.AutoSize = true;
            lblUserHeigth.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserHeigth.Location = new Point(239, 103);
            lblUserHeigth.Name = "lblUserHeigth";
            lblUserHeigth.Size = new Size(43, 25);
            lblUserHeigth.TabIndex = 0;
            lblUserHeigth.Tag = "Kalori";
            lblUserHeigth.Text = "Boy";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblWeight.Location = new Point(93, 58);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(44, 25);
            lblWeight.TabIndex = 0;
            lblWeight.Text = "Kilo";
            // 
            // lblHeigth
            // 
            lblHeigth.AutoSize = true;
            lblHeigth.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeigth.Location = new Point(239, 58);
            lblHeigth.Name = "lblHeigth";
            lblHeigth.Size = new Size(43, 25);
            lblHeigth.TabIndex = 0;
            lblHeigth.Text = "Boy";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.BackColor = Color.Transparent;
            lblAge.Location = new Point(372, 16);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(30, 20);
            lblAge.TabIndex = 0;
            lblAge.Text = "Yaş";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Location = new Point(209, 16);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(73, 20);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Ad Soyad";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblUserConsumedCalorie);
            panel2.Controls.Add(lblConsumedCalorie);
            panel2.Controls.Add(lblUserCalorieToConsume);
            panel2.Controls.Add(lblUserSpentCalorie);
            panel2.Controls.Add(lblCalorieToConsume);
            panel2.Controls.Add(lblSpentCalorie);
            panel2.Location = new Point(26, 582);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 95);
            panel2.TabIndex = 0;
            // 
            // lblUserConsumedCalorie
            // 
            lblUserConsumedCalorie.AutoSize = true;
            lblUserConsumedCalorie.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserConsumedCalorie.Location = new Point(14, 45);
            lblUserConsumedCalorie.Name = "lblUserConsumedCalorie";
            lblUserConsumedCalorie.Size = new Size(120, 25);
            lblUserConsumedCalorie.TabIndex = 0;
            lblUserConsumedCalorie.Tag = "Kalori";
            lblUserConsumedCalorie.Text = "Alınan Kalori";
            // 
            // lblConsumedCalorie
            // 
            lblConsumedCalorie.AutoSize = true;
            lblConsumedCalorie.Location = new Point(14, 23);
            lblConsumedCalorie.Name = "lblConsumedCalorie";
            lblConsumedCalorie.Size = new Size(51, 20);
            lblConsumedCalorie.TabIndex = 0;
            lblConsumedCalorie.Text = "Alınan";
            // 
            // lblUserCalorieToConsume
            // 
            lblUserCalorieToConsume.AutoSize = true;
            lblUserCalorieToConsume.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserCalorieToConsume.Location = new Point(325, 45);
            lblUserCalorieToConsume.Name = "lblUserCalorieToConsume";
            lblUserCalorieToConsume.Size = new Size(213, 25);
            lblUserCalorieToConsume.TabIndex = 0;
            lblUserCalorieToConsume.Tag = "Kalori";
            lblUserCalorieToConsume.Text = "Alınması Gereken Kalori";
            // 
            // lblUserSpentCalorie
            // 
            lblUserSpentCalorie.AutoSize = true;
            lblUserSpentCalorie.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserSpentCalorie.Location = new Point(172, 45);
            lblUserSpentCalorie.Name = "lblUserSpentCalorie";
            lblUserSpentCalorie.Size = new Size(125, 25);
            lblUserSpentCalorie.TabIndex = 0;
            lblUserSpentCalorie.Tag = "Kalori";
            lblUserSpentCalorie.Text = "Yakılan Kalori";
            // 
            // lblCalorieToConsume
            // 
            lblCalorieToConsume.AutoSize = true;
            lblCalorieToConsume.Location = new Point(325, 23);
            lblCalorieToConsume.Name = "lblCalorieToConsume";
            lblCalorieToConsume.Size = new Size(167, 20);
            lblCalorieToConsume.TabIndex = 0;
            lblCalorieToConsume.Text = "Alınması Gereken Kalori";
            // 
            // lblSpentCalorie
            // 
            lblSpentCalorie.AutoSize = true;
            lblSpentCalorie.Location = new Point(172, 23);
            lblSpentCalorie.Name = "lblSpentCalorie";
            lblSpentCalorie.Size = new Size(55, 20);
            lblSpentCalorie.TabIndex = 0;
            lblSpentCalorie.Text = "Yakılan";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(lblActivityDurationTotal);
            panel3.Controls.Add(lbActivitylDuration2);
            panel3.Controls.Add(lblActivity2);
            panel3.Controls.Add(lbActivitylDuration1);
            panel3.Controls.Add(lblActivity1);
            panel3.Controls.Add(lblToday);
            panel3.Location = new Point(26, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(580, 74);
            panel3.TabIndex = 2;
            // 
            // lblActivityDurationTotal
            // 
            lblActivityDurationTotal.AutoSize = true;
            lblActivityDurationTotal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblActivityDurationTotal.Location = new Point(28, 32);
            lblActivityDurationTotal.Name = "lblActivityDurationTotal";
            lblActivityDurationTotal.Size = new Size(189, 23);
            lblActivityDurationTotal.TabIndex = 0;
            lblActivityDurationTotal.Text = "Yapılan Aktivite Toplamı";
            // 
            // lbActivitylDuration2
            // 
            lbActivitylDuration2.AutoSize = true;
            lbActivitylDuration2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbActivitylDuration2.Location = new Point(371, 36);
            lbActivitylDuration2.Name = "lbActivitylDuration2";
            lbActivitylDuration2.Size = new Size(53, 23);
            lbActivitylDuration2.TabIndex = 0;
            lbActivitylDuration2.Text = "Süre2";
            // 
            // lblActivity2
            // 
            lblActivity2.AutoSize = true;
            lblActivity2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblActivity2.Location = new Point(371, 9);
            lblActivity2.Name = "lblActivity2";
            lblActivity2.Size = new Size(75, 23);
            lblActivity2.TabIndex = 0;
            lblActivity2.Text = "Aktivite2";
            // 
            // lbActivitylDuration1
            // 
            lbActivitylDuration1.AutoSize = true;
            lbActivitylDuration1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbActivitylDuration1.Location = new Point(255, 36);
            lbActivitylDuration1.Name = "lbActivitylDuration1";
            lbActivitylDuration1.Size = new Size(53, 23);
            lbActivitylDuration1.TabIndex = 0;
            lbActivitylDuration1.Text = "Süre1";
            // 
            // lblActivity1
            // 
            lblActivity1.AutoSize = true;
            lblActivity1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblActivity1.Location = new Point(255, 9);
            lblActivity1.Name = "lblActivity1";
            lblActivity1.Size = new Size(75, 23);
            lblActivity1.TabIndex = 0;
            lblActivity1.Text = "Aktivite1";
            // 
            // lblToday
            // 
            lblToday.AutoSize = true;
            lblToday.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblToday.Location = new Point(28, 9);
            lblToday.Name = "lblToday";
            lblToday.Size = new Size(60, 23);
            lblToday.TabIndex = 0;
            lblToday.Text = "Bugün";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.Connection = null;
            sqlCommand2.Notification = null;
            sqlCommand2.Transaction = null;
            // 
            // sqlCommand3
            // 
            sqlCommand3.CommandTimeout = 30;
            sqlCommand3.Connection = null;
            sqlCommand3.Notification = null;
            sqlCommand3.Transaction = null;
            // 
            // sqlCommand4
            // 
            sqlCommand4.CommandTimeout = 30;
            sqlCommand4.Connection = null;
            sqlCommand4.Notification = null;
            sqlCommand4.Transaction = null;
            // 
            // lblAddBreakfast
            // 
            lblAddBreakfast.AutoSize = true;
            lblAddBreakfast.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddBreakfast.Location = new Point(94, 57);
            lblAddBreakfast.Name = "lblAddBreakfast";
            lblAddBreakfast.Size = new Size(70, 46);
            lblAddBreakfast.TabIndex = 0;
            lblAddBreakfast.Tag = "AddBreakfast";
            lblAddBreakfast.Text = "+/-";
            // 
            // grpBreakfast
            // 
            grpBreakfast.Controls.Add(pBoxBreakfast);
            grpBreakfast.Controls.Add(lblAddBreakfast);
            grpBreakfast.Location = new Point(26, 272);
            grpBreakfast.Name = "grpBreakfast";
            grpBreakfast.Size = new Size(170, 140);
            grpBreakfast.TabIndex = 5;
            grpBreakfast.TabStop = false;
            grpBreakfast.Text = "Kahvaltı";
            // 
            // pBoxBreakfast
            // 
            pBoxBreakfast.BackgroundImageLayout = ImageLayout.None;
            pBoxBreakfast.Image = (Image)resources.GetObject("pBoxBreakfast.Image");
            pBoxBreakfast.Location = new Point(15, 46);
            pBoxBreakfast.Name = "pBoxBreakfast";
            pBoxBreakfast.Size = new Size(75, 75);
            pBoxBreakfast.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxBreakfast.TabIndex = 1;
            pBoxBreakfast.TabStop = false;
            // 
            // grpLunch
            // 
            grpLunch.Controls.Add(pBoxLunch);
            grpLunch.Controls.Add(lblAddLunch);
            grpLunch.Location = new Point(232, 273);
            grpLunch.Name = "grpLunch";
            grpLunch.Size = new Size(170, 140);
            grpLunch.TabIndex = 5;
            grpLunch.TabStop = false;
            grpLunch.Text = "Öğle Yemeği";
            // 
            // pBoxLunch
            // 
            pBoxLunch.BackgroundImageLayout = ImageLayout.None;
            pBoxLunch.Image = (Image)resources.GetObject("pBoxLunch.Image");
            pBoxLunch.InitialImage = null;
            pBoxLunch.Location = new Point(15, 46);
            pBoxLunch.Name = "pBoxLunch";
            pBoxLunch.Size = new Size(75, 75);
            pBoxLunch.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxLunch.TabIndex = 1;
            pBoxLunch.TabStop = false;
            // 
            // lblAddLunch
            // 
            lblAddLunch.AutoSize = true;
            lblAddLunch.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddLunch.Location = new Point(94, 57);
            lblAddLunch.Name = "lblAddLunch";
            lblAddLunch.Size = new Size(70, 46);
            lblAddLunch.TabIndex = 0;
            lblAddLunch.Tag = "AddLunch";
            lblAddLunch.Text = "+/-";
            // 
            // grpDinner
            // 
            grpDinner.Controls.Add(pboxDinner);
            grpDinner.Controls.Add(lblAddDinner);
            grpDinner.Location = new Point(232, 420);
            grpDinner.Name = "grpDinner";
            grpDinner.Size = new Size(170, 140);
            grpDinner.TabIndex = 5;
            grpDinner.TabStop = false;
            grpDinner.Text = "Akşam Yemeği";
            // 
            // pboxDinner
            // 
            pboxDinner.BackgroundImageLayout = ImageLayout.None;
            pboxDinner.Image = (Image)resources.GetObject("pboxDinner.Image");
            pboxDinner.InitialImage = null;
            pboxDinner.Location = new Point(15, 46);
            pboxDinner.Name = "pboxDinner";
            pboxDinner.Size = new Size(75, 75);
            pboxDinner.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxDinner.TabIndex = 1;
            pboxDinner.TabStop = false;
            // 
            // lblAddDinner
            // 
            lblAddDinner.AutoSize = true;
            lblAddDinner.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddDinner.Location = new Point(94, 57);
            lblAddDinner.Name = "lblAddDinner";
            lblAddDinner.Size = new Size(70, 46);
            lblAddDinner.TabIndex = 0;
            lblAddDinner.Tag = "AddDinner";
            lblAddDinner.Text = "+/-";
            // 
            // grpSnack
            // 
            grpSnack.Controls.Add(pBoxSnack);
            grpSnack.Controls.Add(lblAddSnack);
            grpSnack.Location = new Point(26, 421);
            grpSnack.Name = "grpSnack";
            grpSnack.Size = new Size(170, 140);
            grpSnack.TabIndex = 5;
            grpSnack.TabStop = false;
            grpSnack.Text = "Atıştırmalık";
            // 
            // pBoxSnack
            // 
            pBoxSnack.BackgroundImageLayout = ImageLayout.None;
            pBoxSnack.Image = (Image)resources.GetObject("pBoxSnack.Image");
            pBoxSnack.InitialImage = null;
            pBoxSnack.Location = new Point(15, 46);
            pBoxSnack.Name = "pBoxSnack";
            pBoxSnack.Size = new Size(75, 75);
            pBoxSnack.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxSnack.TabIndex = 1;
            pBoxSnack.TabStop = false;
            // 
            // lblAddSnack
            // 
            lblAddSnack.AutoSize = true;
            lblAddSnack.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddSnack.Location = new Point(94, 57);
            lblAddSnack.Name = "lblAddSnack";
            lblAddSnack.Size = new Size(70, 46);
            lblAddSnack.TabIndex = 0;
            lblAddSnack.Tag = "AddSnack";
            lblAddSnack.Text = "+/-";
            // 
            // pBoxSettings
            // 
            pBoxSettings.BackgroundImageLayout = ImageLayout.Stretch;
            pBoxSettings.Cursor = Cursors.Hand;
            pBoxSettings.Image = (Image)resources.GetObject("pBoxSettings.Image");
            pBoxSettings.Location = new Point(542, 691);
            pBoxSettings.Name = "pBoxSettings";
            pBoxSettings.Size = new Size(64, 56);
            pBoxSettings.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxSettings.TabIndex = 4;
            pBoxSettings.TabStop = false;
            // 
            // grpActivity
            // 
            grpActivity.Controls.Add(pBoxActivity);
            grpActivity.Controls.Add(lblAddActivity);
            grpActivity.Location = new Point(436, 273);
            grpActivity.Name = "grpActivity";
            grpActivity.Size = new Size(170, 140);
            grpActivity.TabIndex = 5;
            grpActivity.TabStop = false;
            grpActivity.Text = "Aktivite";
            // 
            // pBoxActivity
            // 
            pBoxActivity.BackgroundImageLayout = ImageLayout.None;
            pBoxActivity.Image = (Image)resources.GetObject("pBoxActivity.Image");
            pBoxActivity.InitialImage = null;
            pBoxActivity.Location = new Point(15, 46);
            pBoxActivity.Name = "pBoxActivity";
            pBoxActivity.Size = new Size(75, 75);
            pBoxActivity.SizeMode = PictureBoxSizeMode.StretchImage;
            pBoxActivity.TabIndex = 1;
            pBoxActivity.TabStop = false;
            // 
            // lblAddActivity
            // 
            lblAddActivity.AutoSize = true;
            lblAddActivity.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddActivity.Location = new Point(94, 57);
            lblAddActivity.Name = "lblAddActivity";
            lblAddActivity.Size = new Size(70, 46);
            lblAddActivity.TabIndex = 0;
            lblAddActivity.Tag = "AddActivity";
            lblAddActivity.Text = "+/-";
            // 
            // grpWater
            // 
            grpWater.Controls.Add(nmrWater);
            grpWater.Controls.Add(pictureBox1);
            grpWater.Controls.Add(lblConsumedWater);
            grpWater.Controls.Add(label1);
            grpWater.Location = new Point(436, 416);
            grpWater.Name = "grpWater";
            grpWater.Size = new Size(170, 140);
            grpWater.TabIndex = 5;
            grpWater.TabStop = false;
            grpWater.Text = "Su";
            // 
            // nmrWater
            // 
            nmrWater.Location = new Point(105, 91);
            nmrWater.Name = "nmrWater";
            nmrWater.Size = new Size(59, 27);
            nmrWater.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(15, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblConsumedWater
            // 
            lblConsumedWater.AutoSize = true;
            lblConsumedWater.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblConsumedWater.Location = new Point(15, 20);
            lblConsumedWater.Name = "lblConsumedWater";
            lblConsumedWater.Size = new Size(103, 23);
            lblConsumedWater.TabIndex = 0;
            lblConsumedWater.Tag = "";
            lblConsumedWater.Text = "Tüketilen Su";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(94, 43);
            label1.Name = "label1";
            label1.Size = new Size(70, 46);
            label1.TabIndex = 0;
            label1.Tag = "AddWater";
            label1.Text = "+/-";
            // 
            // btnDisplayReport
            // 
            btnDisplayReport.Location = new Point(218, 693);
            btnDisplayReport.Name = "btnDisplayReport";
            btnDisplayReport.Size = new Size(170, 49);
            btnDisplayReport.TabIndex = 6;
            btnDisplayReport.Text = "RAPOR";
            btnDisplayReport.UseVisualStyleBackColor = true;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 785);
            Controls.Add(btnDisplayReport);
            Controls.Add(grpSnack);
            Controls.Add(grpDinner);
            Controls.Add(grpWater);
            Controls.Add(grpActivity);
            Controls.Add(grpLunch);
            Controls.Add(grpBreakfast);
            Controls.Add(pBoxSettings);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "UserDashboard";
            Text = "UserDashboard";
            Load += UserDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            grpBreakfast.ResumeLayout(false);
            grpBreakfast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxBreakfast).EndInit();
            grpLunch.ResumeLayout(false);
            grpLunch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxLunch).EndInit();
            grpDinner.ResumeLayout(false);
            grpDinner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pboxDinner).EndInit();
            grpSnack.ResumeLayout(false);
            grpSnack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxSnack).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxSettings).EndInit();
            grpActivity.ResumeLayout(false);
            grpActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxActivity).EndInit();
            grpWater.ResumeLayout(false);
            grpWater.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrWater).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblAge;
        private Label lblFullName;
        private Label lblTargetWeigth;
        private Label lblHeigth;
        private Panel panel2;
        private Label lblWeight;
        private Label lblSpentCalorie;
        private Label lblUserConsumedCalorie;
        private Label lblConsumedCalorie;
        private Label lblUserSpentCalorie;
        private Panel panel3;
        private Label lblActivityDurationTotal;
        private Label lblToday;
        private Label lblActivity1;
        private Label lblActivity2;
        private Label lbActivitylDuration2;
        private Label lbActivitylDuration1;
        private Label lblUserTargetWeight;
        private Label lblUserWeight;
        private Label lblUserHeigth;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand4;
        private Label lblUserCalorieToConsume;
        private Label lblCalorieToConsume;
        private Label lblAddBreakfast;
        private GroupBox grpBreakfast;
        private PictureBox pBoxBreakfast;
        private GroupBox grpLunch;
        private PictureBox pBoxLunch;
        private Label lblAddLunch;
        private GroupBox grpDinner;
        private PictureBox pboxDinner;
        private Label lblAddDinner;
        private GroupBox grpSnack;
        private PictureBox pBoxSnack;
        private Label lblAddSnack;
        private PictureBox pBoxSettings;
        private GroupBox grpActivity;
        private PictureBox pBoxActivity;
        private Label lblAddActivity;
        private GroupBox grpWater;
        private PictureBox pictureBox1;
        private Label label1;
        private NumericUpDown nmrWater;
        private Label lblConsumedWater;
        private Button btnDisplayReport;
    }
}