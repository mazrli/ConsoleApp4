using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Tests
{
    [TestClass()]
    public class WeigtCalcuatorTests
    {
        [AssemblyInitialize]
        public void GetIdealBodyWeightTest(TestContext context)
        {
            context.WriteLine("In Assemby Initalize");
        }

        [AssemblyCleanup]
        public void AssemblyCleanup()
        {

        }
    }
}