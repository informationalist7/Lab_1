using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Alternative
    {
        public string Name { get; set; } = "No name";
        public double Stability { get; set; }
        public double Stagnation { get; set; }
        public double HighInflation { get; set; }
        public double? Result { get; set; } = null;
        public Alternative()
        {
            
        }

        public Alternative(string name, double stability, double stagnation, double highInflation)
        {
            Name = name;
            Stability = stability;
            Stagnation = stagnation;
            HighInflation = highInflation;
            Result = null;
        }
    }
}
