using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boop
{
    public class Car
    {
        public string CarMake { get; set; }
        public string CarColor { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public string Picture { get; set; }

        public override string ToString()
        {
            return $"{CarMake}";
        }
    }
}
