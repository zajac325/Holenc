using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace holenc
{

    public class Data
    {
        public string Nr { get; set; }
        public double X { get; set; }
        public double Y { get; set; }


        public Data(string Nr, double X, double Y)
        {
            this.Nr = Nr;
            this.X = X;
            this.Y = Y;
        }

    }
}
