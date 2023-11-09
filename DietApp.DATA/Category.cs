using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DATA
{
    public class Category : BaseClass
    {

        public string CategoryName { get; set; }

        //Navigation Property
        public List<Product> Products { get; set; }


    }
}
