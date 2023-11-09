using DietApp.DAL.Context;
using DietApp.DATA;

namespace DietApp.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new UserReport());


            AppDBContext context = new AppDBContext();

            //List<Category> category = new List<Category>();

            //category.Add(new Category() { Name = "Beyaz Et" });
            //category.Add(new Category() { Name = "Kırmızı Et" });
            //category.Add(new Category() { Name = "Baklagil" });
            //category.Add(new Category() { Name = "Salata" });
            //category.Add(new Category() { Name = "Meyve" });
            //category.Add(new Category() { Name = "İçecek" });
            //category.Add(new Category() { Name = "Kuruyemiş" });
            //category.Add(new Category() { Name = "Temel Gıda" });
            //category.Add(new Category() { Name = "Atıştırmalık" });
            //category.Add(new Category() { Name = "Unlu Mamüller" });
            //category.Add(new Category() { Name = "Süt Ürünleri" });
            //category.Add(new Category() { Name = "Fast Food" });
            //category.Add(new Category() { Name = "Tatlı & Tuzlu" });
            //category.Add(new Category() { Name = "Sebze" });


            //context.Categories.AddRange(category);

            //List<Product> product = new List<Product>();
            //product.Add(new Product() { Name = "Tavuk Göğsü", Calory = 110, CategoryID = 1 });
            //product.Add(new Product() { Name = "Tavuk Sote", Calory = 288, CategoryID = 1 });
            //product.Add(new Product() { Name = "Tavuk Kanat", Calory = 252, CategoryID = 1 });
            //product.Add(new Product() { Name = "Tavuk Çorbası", Calory = 132, CategoryID = 1 });
            //product.Add(new Product() { Name = "Tavuk Baget", Calory = 238, CategoryID = 1 });
            //product.Add(new Product() { Name = "Tavuk Göğüs", Calory = 120, CategoryID = 1 });
            //product.Add(new Product() { Name = "Tavuk Şiş", Calory = 208, CategoryID = 1 });
            //product.Add(new Product() { Name = "Tavuk Döner", Calory = 149, CategoryID = 1 });
            //product.Add(new Product() { Name = "Tavuk Ciğer", Calory = 167, CategoryID = 1 });
            //product.Add(new Product() { Name = "Tavuk Izgara", Calory = 274, CategoryID = 1 });
            //product.Add(new Product() { Name = "Tavuk Tantuni", Calory = 415, CategoryID = 1 });
            //product.Add(new Product() { Name = "Hindi But(1 but 546g)", Calory = 1136, CategoryID = 1 });
            //product.Add(new Product() { Name = "Hindi Göğüs(1/2 864g)", Calory = 1166, CategoryID = 1 });
            //product.Add(new Product() { Name = "Hindi Kanat", Calory = 221, CategoryID = 1 });
            //product.Add(new Product() { Name = "Ördek(634g)", Calory = 337, CategoryID = 1 });
            //product.Add(new Product() { Name = "Balık Kızartma(200g)", Calory = 585, CategoryID = 1 });
            //product.Add(new Product() { Name = "Balık Izgara", Calory = 230, CategoryID = 1 });
            //product.Add(new Product() { Name = "Balık Buğlama", Calory = 398, CategoryID = 1 });
            //product.Add(new Product() { Name = "Balık Çorbası", Calory = 146, CategoryID = 1 });
            //product.Add(new Product() { Name = "Fırında Balık", Calory = 334, CategoryID = 1 });
            //product.Add(new Product() { Name = "Balık Nuget", Calory = 196, CategoryID = 1 });
            //product.Add(new Product() { Name = "Ton Balık(80gr)", Calory = 110, CategoryID = 1 });

            //product.Add(new Product() { Name = "Antrikot", Calory = 303, CategoryID = 2 });
            //product.Add(new Product() { Name = "İskender", Calory = 476, CategoryID = 2 });
            //product.Add(new Product() { Name = "Bonfile", Calory = 276, CategoryID = 2 });
            //product.Add(new Product() { Name = "Dana Kıyma", Calory = 172, CategoryID = 2 });
            //product.Add(new Product() { Name = "Kuzu Pirzola", Calory = 276, CategoryID = 2 });
            //product.Add(new Product() { Name = "Sığır Eti", Calory = 248, CategoryID = 2 });
            //product.Add(new Product() { Name = "Dana Kavurma", Calory = 360, CategoryID = 2 });
            //product.Add(new Product() { Name = "Sığır Eti", Calory = 248, CategoryID = 2 });
            //product.Add(new Product() { Name = "Et Şiş", Calory = 324, CategoryID = 2 });
            //product.Add(new Product() { Name = "Ciğer Şiş", Calory = 287, CategoryID = 2 });
            //product.Add(new Product() { Name = "Haşlama Çorbası", Calory = 159, CategoryID = 2 });
            //product.Add(new Product() { Name = "Etli Biber Dolması", Calory = 95, CategoryID = 2 });
            //product.Add(new Product() { Name = "Et Döner", Calory = 301, CategoryID = 2 });

            //product.Add(new Product() { Name = "Bamya", Calory = 33, CategoryID = 3 });
            //product.Add(new Product() { Name = "Bezelye", Calory = 42, CategoryID = 3 });
            //product.Add(new Product() { Name = "Barbunya Fasulye", Calory = 347, CategoryID = 3 });
            //product.Add(new Product() { Name = "Kuru Fasulye", Calory = 336, CategoryID = 3 });
            //product.Add(new Product() { Name = "Mercimek", Calory = 353, CategoryID = 3 });
            //product.Add(new Product() { Name = "Yeşil Mercimek", Calory = 257, CategoryID = 3 });
            //product.Add(new Product() { Name = "Nohut", Calory = 364, CategoryID = 3 });

            //product.Add(new Product() { Name = "Çoban Salata", Calory = 115, CategoryID = 4 });
            //product.Add(new Product() { Name = "Mevsim Salata", Calory = 59, CategoryID = 4 });
            //product.Add(new Product() { Name = "Sezar Salata", Calory = 466, CategoryID = 4 });
            //product.Add(new Product() { Name = "Tavuklu Salata", Calory = 130, CategoryID = 4 });
            //product.Add(new Product() { Name = "Ton Balıklı Salata", Calory = 327, CategoryID = 4 });

            //product.Add(new Product() { Name = "Ahududu", Calory = 64, CategoryID = 5 });
            //product.Add(new Product() { Name = "Ananas", Calory = 50, CategoryID = 5 });
            //product.Add(new Product() { Name = "Armut", Calory = 57, CategoryID = 5 });
            //product.Add(new Product() { Name = "Avokado", Calory = 160, CategoryID = 5 });
            //product.Add(new Product() { Name = "Ayva", Calory = 57, CategoryID = 5 });
            //product.Add(new Product() { Name = "Böğürtlen", Calory = 43, CategoryID = 5 });
            //product.Add(new Product() { Name = "Elma", Calory = 52, CategoryID = 5 });
            //product.Add(new Product() { Name = "Erik", Calory = 46, CategoryID = 5 });
            //product.Add(new Product() { Name = "Üzüm", Calory = 56, CategoryID = 5 });
            //product.Add(new Product() { Name = "İncir", Calory = 74, CategoryID = 5 });
            //product.Add(new Product() { Name = "Muz", Calory = 122, CategoryID = 5 });
            //product.Add(new Product() { Name = "Karpuz", Calory = 30, CategoryID = 5 });
            //product.Add(new Product() { Name = "Kayısı", Calory = 48, CategoryID = 5 });
            //product.Add(new Product() { Name = "Kiraz", Calory = 50, CategoryID = 5 });
            //product.Add(new Product() { Name = "Kivi", Calory = 61, CategoryID = 5 });
            //product.Add(new Product() { Name = "Limon", Calory = 29, CategoryID = 5 });
            //product.Add(new Product() { Name = "Mandalina", Calory = 53, CategoryID = 5 });
            //product.Add(new Product() { Name = "Nar", Calory = 83, CategoryID = 5 });
            //product.Add(new Product() { Name = "Portakal", Calory = 47, CategoryID = 5 });
            //product.Add(new Product() { Name = "Şeftali", Calory = 39, CategoryID = 5 });
            //product.Add(new Product() { Name = "Çilek", Calory = 32, CategoryID = 5 });
            //product.Add(new Product() { Name = "Şeftali", Calory = 39, CategoryID = 5 });
            //product.Add(new Product() { Name = "Kavun", Calory = 34, CategoryID = 5 });

            //product.Add(new Product() { Name = "Boza", Calory = 370, CategoryID = 6 });
            //product.Add(new Product() { Name = "Coca Cola", Calory = 139, CategoryID = 6 });
            //product.Add(new Product() { Name = "Gazoz", Calory = 105, CategoryID = 6 });
            //product.Add(new Product() { Name = "Ice Tea", Calory = 135, CategoryID = 6 });
            //product.Add(new Product() { Name = "Kahve", Calory = 2, CategoryID = 6 });
            //product.Add(new Product() { Name = "Cola Zero", Calory = 1, CategoryID = 6 });
            //product.Add(new Product() { Name = "Latte Macchiato", Calory = 57, CategoryID = 6 });
            //product.Add(new Product() { Name = "Limonata", Calory = 42, CategoryID = 6 });
            //product.Add(new Product() { Name = "Milkshake", Calory = 329, CategoryID = 6 });
            //product.Add(new Product() { Name = "Süt", Calory = 61, CategoryID = 6 });
            //product.Add(new Product() { Name = "Sıcak Çikolata", Calory = 89, CategoryID = 6 });
            //product.Add(new Product() { Name = "Türk Kahvesi", Calory = 2, CategoryID = 6 });
            //product.Add(new Product() { Name = "Çay", Calory = 2, CategoryID = 6 });
            //product.Add(new Product() { Name = "Bitki Çayı", Calory = 2, CategoryID = 6 });
            //product.Add(new Product() { Name = "Fanta", Calory = 140, CategoryID = 6 });
            //product.Add(new Product() { Name = "Meyveli Soda", Calory = 94, CategoryID = 6 });
            //product.Add(new Product() { Name = "Portakal Suyu", Calory = 90, CategoryID = 6 });
            //product.Add(new Product() { Name = "Ayran", Calory = 76, CategoryID = 6 });
            //product.Add(new Product() { Name = "Espresso", Calory = 151, CategoryID = 6 });
            //product.Add(new Product() { Name = "Frappuccino ", Calory = 258, CategoryID = 6 });
            //product.Add(new Product() { Name = "White Chocolate Mocha", Calory = 257, CategoryID = 6 });
            //product.Add(new Product() { Name = "Viski", Calory = 125, CategoryID = 6 });
            //product.Add(new Product() { Name = "Rakı", Calory = 131, CategoryID = 6 });
            //product.Add(new Product() { Name = "Bira", Calory = 138, CategoryID = 6 });
            //product.Add(new Product() { Name = "Şarap", Calory = 111, CategoryID = 6 });
            //product.Add(new Product() { Name = "Votka", Calory = 116, CategoryID = 6 });

            //product.Add(new Product() { Name = "Fındık", Calory = 154, CategoryID = 7 });
            //product.Add(new Product() { Name = "Badem", Calory = 150, CategoryID = 7 });
            //product.Add(new Product() { Name = "Ceviz", Calory = 164, CategoryID = 7 });
            //product.Add(new Product() { Name = "Lebleli", Calory = 24, CategoryID = 7 });
            //product.Add(new Product() { Name = "Antep Fıstığı", Calory = 101, CategoryID = 7 });
            //product.Add(new Product() { Name = "Kaju", Calory = 138, CategoryID = 7 });
            //product.Add(new Product() { Name = "Fıstık", Calory = 170, CategoryID = 7 });
            //product.Add(new Product() { Name = "Kabak Çekirdeği", Calory = 56, CategoryID = 7 });

            //product.Add(new Product() { Name = "Makarna", Calory = 141, CategoryID = 8 });
            //product.Add(new Product() { Name = "Pirinç Pilavı", Calory = 258, CategoryID = 8 });
            //product.Add(new Product() { Name = "Bulgur Pilavı", Calory = 149, CategoryID = 8 });

            //product.Add(new Product() { Name = "Cips", Calory = 124, CategoryID = 9 });
            //product.Add(new Product() { Name = "Patetes Kızartması", Calory = 250, CategoryID = 9 });

            //product.Add(new Product() { Name = "1 dilim Ekmek", Calory = 640, CategoryID = 10 });

            //product.Add(new Product() { Name = "Beyaz Peynir", Calory = 931, CategoryID = 11 });
            //product.Add(new Product() { Name = "Kaşar Peyniri", Calory = 711, CategoryID = 11 });
            //product.Add(new Product() { Name = "Yoğurt", Calory = 1221, CategoryID = 11 });

            //product.Add(new Product() { Name = "Tavuk Burger", Calory = 2742, CategoryID = 12 });
            //product.Add(new Product() { Name = "Hamburger", Calory = 3862, CategoryID = 12 });
            //product.Add(new Product() { Name = "Cheeseburger", Calory = 4102, CategoryID = 12 });

            //product.Add(new Product() { Name = "Sütlaç", Calory = 2503, CategoryID = 13 });
            //product.Add(new Product() { Name = "Kazandibi", Calory = 2003, CategoryID = 13 });
            //product.Add(new Product() { Name = "Baklava", Calory = 1653, CategoryID = 13 });
            //product.Add(new Product() { Name = "Künefe", Calory = 4203, CategoryID = 13 });

            //product.Add(new Product() { Name = "Biber", Calory = 204, CategoryID = 14 });
            //product.Add(new Product() { Name = "Brokoli", Calory = 2074, CategoryID = 14 });
            //product.Add(new Product() { Name = "Lahana", Calory = 84, CategoryID = 14 });
            //product.Add(new Product() { Name = "Domates", Calory = 204, CategoryID = 14 });
            //product.Add(new Product() { Name = "Ispanak", Calory = 784, CategoryID = 14 });
            //product.Add(new Product() { Name = "Kabak", Calory = 514, CategoryID = 14 });
            //product.Add(new Product() { Name = "Kara Lahana", Calory = 124, CategoryID = 14 });
            //product.Add(new Product() { Name = "Karnıbahar", Calory = 34, CategoryID = 14 });
            //product.Add(new Product() { Name = "Kırmızı Biber", Calory = 124, CategoryID = 14 });
            //product.Add(new Product() { Name = "Mantar", Calory = 224, CategoryID = 14 });
            //product.Add(new Product() { Name = "Mısır", Calory = 3654, CategoryID = 14 });
            //product.Add(new Product() { Name = "Patates", Calory = 1644, CategoryID = 14 });
            //product.Add(new Product() { Name = "Patlıcan", Calory = 1154, CategoryID = 14 });
            //product.Add(new Product() { Name = "Pırasa", Calory = 614, CategoryID = 14 });
            //product.Add(new Product() { Name = "Roka", Calory = 14, CategoryID = 14 });
            //product.Add(new Product() { Name = "Salatalık", Calory = 334, CategoryID = 14 });
            //product.Add(new Product() { Name = "Sarımsak", Calory = 44, CategoryID = 14 });
            //product.Add(new Product() { Name = "Soğan", Calory = 344, CategoryID = 14 });
            //product.Add(new Product() { Name = "Turp", Calory = 344, CategoryID = 14 });
            //product.Add(new Product() { Name = "Havuç", Calory = 254, CategoryID = 14 });

            //context.Products.AddRange(product);

            //List<Meal> meals = new List<Meal>();
            //meals.Add(new Meal() { Name = "Sabah" });
            //meals.Add(new Meal() { Name = "Öğle" });
            //meals.Add(new Meal() { Name = "Akşam" });
            //meals.Add(new Meal() { Name = "Aperatif" });

            //context.Meals.AddRange(meals);

            //context.SaveChanges();




        }




    }
}