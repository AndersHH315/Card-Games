using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    public class Methods
    {
        public double count(double a)
        {
            double b = a + 2.5;
            double results = a + b;
            return splitOrDouble(results);
        }

        public double splitOrDouble(double a)
        {
            if (a > 25)
            {
                return a / 2;
            }
            else if (a < 25)
            {
                return a * 2;
            }
            else
                return 0;
        }

        public string addtext(double a, string b)
        {
            string c = "Big";
            string d = "Small";
            if (a > 50)
            {
                return a + " " + c;
            }
            else if (a < 50)
            {
                return a + " " + d;
            }
            else
                return null;
        }
    }

}
