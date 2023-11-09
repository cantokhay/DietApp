using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DATA
{
    public class AppUser : BaseClass
    {
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double TargetWeight { get; set; }


        public string FullName { get { return Name + " " + Lastname; } }

        //public decimal IdealDailyCal { get; set; } //ToDo



        //Navigation


        public List<Activity> Activities { get; set; }

        public List<Product> Products { get; set; }



    }
}
