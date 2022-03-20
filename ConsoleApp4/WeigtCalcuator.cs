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
                    return 0;
            }
        }



    }
}
