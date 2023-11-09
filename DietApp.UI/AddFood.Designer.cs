namespace DietApp.UI
{
    partial class AddFood
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
            lblCategory = new Label();
            lblKcal = new Label();
            lblProductName = new Label();
            lblCalorie = new Label();
            cBoxMeal = new ComboBox();
            txtProductName = new TextBox();
            nmrCalorie = new NumericUpDown();
            btnAddPicture = new Button();
            pBoxPicture = new PictureBox();
            txtImagePath = new TextBox();
            btnAddProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrCalorie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxPicture).BeginInit();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategory.Location = new Point(170, 107);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(59, 25);
            lblCategory.TabIndex = 0;
            lblCategory.Tag = "";
            lblCategory.Text = "Öğün";
            // 
            // lblKcal
            // 
            lblKcal.AutoSize = true;
            lblKcal.Location = new Point(459, 218);
            lblKcal.Name = "lblKcal";
            lblKcal.Size = new Size(35, 20);
            lblKcal.TabIndex = 0;
            lblKcal.Text = "kcal";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductName.Location = new Point(170, 158);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(99, 25);
            lblProductName.TabIndex = 0;
            lblProductName.Tag = "";
            lblProductName.Text = "Yemek Adı";
            // 
            // lblCalorie
            // 
            lblCalorie.AutoSize = true;
            lblCalorie.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalorie.Location = new Point(170, 212);
            lblCalorie.Name = "lblCalorie";
            lblCalorie.Size = new Size(61, 25);
            lblCalorie.TabIndex = 0;
            lblCalorie.Tag = "";
            lblCalorie.Text = "Kalori";
            // 
            // cBoxMeal
            // 
            cBoxMeal.FormattingEnabled = true;
            cBoxMeal.Location = new Point(291, 104);
            cBoxMeal.Name = "cBoxMeal";
            cBoxMeal.Size = new Size(315, 28);
            cBoxMeal.TabIndex = 2;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(291, 158);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(315, 27);
            txtProductName.TabIndex = 3;
            // 
            // nmrCalorie
            // 
            nmrCalorie.Location = new Point(291, 214);
            nmrCalorie.Name = "nmrCalorie";
            nmrCalorie.Size = new Size(150, 27);
            nmrCalorie.TabIndex = 4;
            // 
            // btnAddPicture
            // 
            btnAddPicture.Location = new Point(135, 265);
            btnAddPicture.Name = "btnAddPicture";
            btnAddPicture.Size = new Size(134, 27);
            btnAddPicture.TabIndex = 7;
            btnAddPicture.Tag = "";
            btnAddPicture.Text = "Resim Ekle";
            btnAddPicture.UseVisualStyleBackColor = true;
            btnAddPicture.Click += btnAddPicture_Click;
            // 
            // pBoxPicture
            // 
            pBoxPicture.BackColor = SystemColors.ControlLight;
            pBoxPicture.Location = new Point(291, 310);
            pBoxPicture.Name = "pBoxPicture";
            pBoxPicture.Size = new Size(150, 150);
            pBoxPicture.TabIndex = 8;
            pBoxPicture.TabStop = false;
            pBoxPicture.Tag = "";
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(291, 265);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(315, 27);
            txtImagePath.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(291, 466);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(150, 58);
            btnAddProduct.TabIndex = 7;
            btnAddProduct.Tag = "";
            btnAddProduct.Text = "Kaydet";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // AddFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 548);
            Controls.Add(pBoxPicture);
            Controls.Add(btnAddProduct);
            Controls.Add(btnAddPicture);
            Controls.Add(lblKcal);
            Controls.Add(nmrCalorie);
            Controls.Add(txtImagePath);
            Controls.Add(txtProductName);
            Controls.Add(cBoxMeal);
            Controls.Add(lblCalorie);
            Controls.Add(lblProductName);
            Controls.Add(lblCategory);
            Name = "AddFood";
            Text = "AddFood";
            Load += AddFood_Load;
            ((System.ComponentModel.ISupportInitialize)nmrCalorie).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategory;
        private Label lblKcal;
        private Label lblProductName;
        private Label lblCalorie;
        private ComboBox cBoxMeal;
        private TextBox txtProductName;
        private NumericUpDown nmrCalorie;
        private Button btnAddPicture;
        private PictureBox pBoxPicture;
        private TextBox txtImagePath;
        private Button btnAddProduct;
    }
}