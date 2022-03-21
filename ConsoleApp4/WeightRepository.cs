using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class WeightRepository
    {
        IEnumerable<WeigtCalcuator> weights;

        public WeightRepository()
        {
            weights = new List<WeigtCalcuator>()
            {
                new WeigtCalcuator { Height = 175, Sex = 'W' },
                new WeigtCalcuator{Height = 180, Sex = 'm'},
                new WeigtCalcuator {Height = 190, Sex = 'm'}
            };
        }

        public IEnumerable<WeigtCalcuator> GetWeigtCalcuatorList()
        {
            return weights;
        }
        

    }
}
