using AuthTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;

namespace AuthTests
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestSumar()
        {
            //Dados
            int num1 = 1;
            int num2 = 2;
            int esperado = 3;

            //Cuando
            int calculado = Program.Addition(num1 ,num2);
            Assert.AreEqual(esperado, calculado);
        }

        [TestMethod]
        public void TestCadenaTrue()
        {
            string aux = "polopolo";
            bool result = AuthTesting.Program.GetTheFirst4CharactersIfTheStringHas8Characters(aux);
            Assert.IsTrue(true, aux);
        }
        [TestMethod]
        public void TestCadenaFalse()
        {
            string aux = "polopolojjjj";
            bool result = AuthTesting.Program.GetTheFirst4CharactersIfTheStringHas8Characters(aux);
            Assert.IsTrue(true, aux);

        }
        [TestMethod]
        public void TestIntToBoolean()
        {
            //Dados
            int num1 = 1;
            bool result = AuthTesting.Program.ConvertIntToBoolean(num1);
            Assert.AreEqual(result, true);

        }
        [TestMethod]
        public void TestBooleanToInt()
        {
            //Dados
            bool aux = true;
            int result = AuthTesting.Program.ConvertBooleanToInt(aux);
            Assert.AreEqual(result, 1);

        }
        [TestMethod]
        public void TestStringToBool()
        {
            //Dados
            string aux = "true";
            bool result = AuthTesting.Program.ParseStringToBool(aux);
            Assert.AreEqual(result, 1);

        }
     
    }
}
