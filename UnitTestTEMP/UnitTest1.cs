using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackTemp; 

namespace UnitTestTEMP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Temp temp = new Temp(30, "K");
            Assert.AreEqual(temp.ToFahrenheit(), -405.67);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Temp temp = new Temp(30, "C");
            Assert.AreEqual(temp.ToFahrenheit(), 86);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Temp temp = new Temp(30, "F");
            Assert.AreEqual(temp.ToFahrenheit(), 30);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Temp temp = new Temp(30, "K");
            Assert.AreEqual(temp.ToCelsius(), -243.15);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Temp temp = new Temp(30, "C");
            Assert.AreEqual(temp.ToCelsius(), 30);
        }
        [TestMethod]
        public void TestMethod6()
        {
            Temp temp = new Temp(30, "F");
            Assert.AreEqual(temp.ToCelsius(), -1.11);
        }
        [TestMethod]
        public void TestMethod7()
        {
            Temp temp = new Temp(30, "C");
            Assert.AreEqual(temp.ToKelvin(), 303.15);
        }
        [TestMethod]
        public void TestMethod8()
        {
            Temp temp = new Temp(30, "F");
            Assert.AreEqual(temp.ToKelvin(), 272.04);
        }
        [TestMethod]
        public void TestMethod9()
        {
            Temp temp = new Temp(30, "K");
            Assert.AreEqual(temp.ToKelvin(), 30);
        }
    }
}
