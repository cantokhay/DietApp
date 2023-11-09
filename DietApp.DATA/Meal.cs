using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DATA
{
    public class Meal:BaseClass
    {
        //tarih verilecek
        //product list yiyecek tutulacak
        //öğün tipi de tutulacak
        //Kalori miktarı

        //Metot ile toplam yğ kaloridir.


        //Category n-to-n Meal

        //navigation

        public List<Product> Products { get; set; }
        
        public List<Category> Categories { get; set; }

       


      
    }
}
