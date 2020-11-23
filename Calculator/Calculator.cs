using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNS
{
    public class Calculator
    {
		public Calculator() { }
		public double summa(double a, double b)
		{
			return a + b;
		}
		public double multiplication(double a, double b)
		{
			return a * b;
		}
		public double division(double a, double b)
		{
			if (b == 0) throw new DivideByZeroException();
			return a / b;
		}
		public double minus(double a, double b)
		{
			return a - b;
		}
	}
}
