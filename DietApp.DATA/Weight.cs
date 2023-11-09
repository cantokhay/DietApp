using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DATA
{
    public class Weight
    {
        public DateTime CreatedDate { get; set; }
        [Key]
        public double UpdatedWeight { get; set; }


       

       
    }
}
