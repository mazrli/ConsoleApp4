using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp4;
using System.Collections.Generic;
using FluentAssertions;

namespace TestProject1
{
    [TestClass]
    public class WeigtCalcuatorTests  
    {
        
        [TestMethod]
        public void GetIdealBodyWeight_SexIsM_And_Height_180_Reture_72_5()
        {

        //    // Arrange
        //    WeigtCalcuator sut = new WeigtCalcuator
        //    {
        //        Sex = 'm',
        //        Height = 180


        //    };

        //    // Act

        //    double actual = sut.GetIdealBodyWeight();
        //    double expected = 72.5;


        //    //Assert

        //    //    AreEqul  betyder att är dem som jag förväntar

        //    Assert.AreEqual(expected, actual);




        }
        //[TestMethod]
        //public void  Assert_Tests()
        //{
        //   Assert.AreNotEqual(100, 90 + 10);


        //}


        [TestMethod]
         public void StringAssert_tests()
        {
            string name = "Aziz";
            StringAssert.Contains(name, "zi");
        }

        [TestMethod]
        public void ColectionAssert_Tests()
        {
            List<string> names = new List<string>() { "aziz", "Tony", "Phoebe", "Niklas"};

            CollectionAssert.AllItemsAreNotNull(names);
            CollectionAssert.Contains(names, "aziz");
            

        }

        [TestMethod]
        public void FluentAssertinons_Tess()
        {
            string name = "Aziz";
            name.Should().StartWith("A");


            int nummer = 10;
            nummer.Should().BeGreaterThan(4);


            List<string> names = new List<string>() { "Tony", "Peoebe" };

            names.Should().HaveCount(2);    

        }
    }
}
