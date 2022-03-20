using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp4;

namespace TestProject1
{
    [TestClass]
    public class WeigtCalcuatorTests  
    {
        
        [TestMethod]
        public void GetIdealBodyWeight_SexIsM_And_Height_180_Reture_72_5()
        {

            // Arrange
            WeigtCalcuator sut = new WeigtCalcuator
            {
                Sex = 'm',
                Height = 180


            };

            // Act

            double actual = sut.GetIdealBodyWeight();
            double expected = 72.5;


            //Assert

            //    AreEqul  betyder att är dem som jg förväntar

            Assert.AreEqual(expected, actual);




        }
    }
}
