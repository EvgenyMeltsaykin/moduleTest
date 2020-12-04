using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsInput
{
    [TestClass]
    public class InputTest
    {
        [TestMethod]
        public void InputVarsTest()
        {
            InputClass input = new InputClass();
            Assert.AreEqual(false, input.wrongInput("2", "2"), "Ошибка в тесте");
            Assert.AreEqual(true, input.wrongInput("fdsf", "2"), "Ошибка в тесте");
            Assert.AreEqual(true, input.wrongInput("2", "fdg"), "Ошибка в тесте");
            Assert.AreEqual(true, input.wrongInput("", ""), "Ошибка в тесте");
        }

        [TestMethod]
        public void InputVarTest()
        {
            InputClass input = new InputClass();
            Assert.AreEqual(false, input.wrongInputVar("2", "int"), "Ошибка в тесте");
            Assert.AreEqual(true, input.wrongInputVar("fdsf", "int"), "Ошибка в тесте");
            Assert.AreEqual(false, input.wrongInputVar("2", "double"), "Ошибка в тесте");
            Assert.AreEqual(true, input.wrongInputVar("2.3", "int"), "Ошибка в тесте");
            Assert.AreEqual(false, input.wrongInputVar("2,3", "double"), "Ошибка в тесте");
        }
    }
}
