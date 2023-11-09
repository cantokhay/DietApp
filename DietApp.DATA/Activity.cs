using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DATA
{
    public class Activity : BaseClass
    {
       
        public int Steps { get; set; }
        private double _avgCalories;
        public double AvgCalories
        {
            get { return _avgCalories; }
            set { _avgCalories = (1400 / (AppUser.Weight * 2.2046) * 0.5) * Steps; }


        }   //{ return (1400 / (ActivityUpdatedWeight * 2.2046) * 0.5) * Steps; } }

        public double BurnedCaloriePerHour { get; set; }
        public AppUser AppUser { get; set; }


      

    }
}
