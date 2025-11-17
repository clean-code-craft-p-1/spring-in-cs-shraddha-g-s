using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    public class Stats
    {
        private double min;
        private double max;
        private double average;

        public Stats()
        {
            min = double.NaN;
            max = double.NaN;
            average = double.NaN;
        }

        public double Min
        {
            get { return min; }
            set { min = value; }
        }

        public double Max
        {
            get { return max; }
            set { max = value; }
        }

        public double Average
        {
            get { return average; }
            set { average = value; }
        }
    }
}
