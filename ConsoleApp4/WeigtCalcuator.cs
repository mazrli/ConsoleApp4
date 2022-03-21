using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class WeigtCalcuator 
    {
        public double Height { get; set; }
        public char Sex { get; set; }

        public double GetIdealBodyWeight()
        {
            switch (Sex)
            {
                case 'M' or 'm':
                    return (Height - 100) - ((Height - 150) / 4);
                case 'W' or 'm':
                    return (Height - 100) - ((Height - 150) / 2);
                default:
                    throw new ArgumentException("The Sex argument is not valid");
            }
        }



        public  List<double> GetIdealBodyWeightFromDataSource()
        {
            List<double> result = new List<double>();


            var repo = new WeightRepository();


            IEnumerable<WeigtCalcuator> weights = repo.GetWeigtCalcuatorList();
            foreach (var weight in weights)
            {
                result.Add(weight.GetIdealBodyWeight());
            }
            return result;
        }



    }
}
