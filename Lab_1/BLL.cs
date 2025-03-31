using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class BLL
    {
        List<Alternative> alternatives = new List<Alternative>();
        double[] coefficients;
        public BLL(List<Alternative> alternatives, double[] coefficients)
        {
            this.alternatives = alternatives;
            this.coefficients = coefficients;
        }

        public List<Alternative> GetMaxAlternatives()
        { 
            List<Alternative> maxAlternatives = new List<Alternative>();
            if (alternatives.Count <= 0 || coefficients.Count() <= 0)
            {
                maxAlternatives.Add(new Alternative
                {
                    Name = "Дані задані не коректно",
                    Stability = 0,
                    Stagnation = 0,
                    HighInflation = 0,
                    Result = null
                });
                return maxAlternatives;
            }
            foreach (var alternative in alternatives)
            {
                for (int i = 0; i < coefficients.Count()-2; i++)
                {
                    alternative.Result = alternative.Stability * coefficients[i] + alternative.Stagnation * coefficients[i+1] + alternative.HighInflation * coefficients[i+2];
                }
                //alternative.Result = alternative.Stability * coefficients[0] + alternative.Stagnation * coefficients[1] + alternative.HighInflation * coefficients[2];
            }
            double maxResult = alternatives.Max(x => x.Result.Value);
            for (int i = 0; i < alternatives.Count; i++)
            {
                if (alternatives[i].Result == maxResult)
                {
                    maxAlternatives.Add(alternatives[i]);
                }
            }
            return maxAlternatives;
        }
    }
}
