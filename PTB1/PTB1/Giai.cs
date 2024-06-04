using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTB1
{
    public class Giai
    {
        private double a, b;
        public Giai(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double Solve()
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    throw new ArgumentException("Phương trình có vô số nghiệm.");
                }
                else
                {
                    throw new ArgumentException("Phương trình vô nghiệm.");
                }
            }
            return -b / a;
        }    }
}
