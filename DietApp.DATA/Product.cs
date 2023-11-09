using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DATA
{
    public class Product : BaseClass
    {
        public int CategoryID { get; set; }
        public double Calory { get; set; }
        public double PortionGram { get; set; }
     

        //Navigation Property
        public Category Category { get; set; }
        public List<AppUser> Users { get; set; }



    }
}
