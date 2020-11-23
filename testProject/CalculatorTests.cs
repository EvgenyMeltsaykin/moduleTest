using System;
using CalculatorNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testProject
{
	[TestClass]
	public class CalculatorTests 
	{
		[TestMethod]
		public void summaTest()
		{
			Calculator calculator = new Calculator();
			Assert.AreEqual(10, calculator.summa(5,5), 0.001, "Сумма считается неверно");
			Assert.AreEqual(0, calculator.summa(0, 0), 0.001, "Сумма считается неверно");
			Assert.AreEqual(5, calculator.summa(5, 0), 0.001, "Сумма считается неверно");
		}

		[TestMethod]
		public void muptiplicationTest()
		{
			Calculator calculator = new Calculator();
			Assert.AreEqual(25, calculator.multiplication(5, 5), 0.001, "Произведение считается неверно");
			Assert.AreEqual(0, calculator.multiplication(0, 0), 0.001, "Произведение считается неверно");
			Assert.AreEqual(0, calculator.multiplication(5, 0), 0.001, "Произведение считается неверно");
		}

		[TestMethod]
		public void divisionTest()
		{
			Calculator calculator = new Calculator();
			Assert.AreEqual(1, calculator.division(5, 5), 0.001, "Деление неверно");
			Assert.AreEqual(2.5, calculator.division(5, 2), 0.001, "Деление неверно");
			Assert.AreEqual(-2.5, calculator.division(-5, 2), 0.001, "Деление неверно");
			Assert.AreEqual(-2.5, calculator.division(5, -2), 0.001, "Деление неверно");
		}
		[TestMethod]
		public void minusTest()
		{
			Calculator calculator = new Calculator();
			Assert.AreEqual(0, calculator.minus(5, 5), 0.001, "Вычитание неверно");
			Assert.AreEqual(-5, calculator.minus(0, 5), 0.001, "Вычитание неверно");
			Assert.AreEqual(5, calculator.minus(10, 5), 0.001, "Вычитание неверно");

		}
	}
}
