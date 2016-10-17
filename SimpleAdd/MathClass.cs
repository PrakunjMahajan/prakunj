using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleAdd
{
    public class MathClass
    {
        public int Sum(int n1, int n2)
        {
            int result;

            if (n1 <= 0 && n2 <= 0)
            {
                return 0;
                throw new ArgumentException("No Zero or Negative are allowed");
            }
            else
            {
                //return n1 + n2;
                result = n1 + n2;
                return result;
            }
        }
    }
}
