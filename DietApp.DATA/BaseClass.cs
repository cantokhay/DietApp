using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DATA
{
    public class BaseClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string? ImagePath { get; set; }

        public DateTime? AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
