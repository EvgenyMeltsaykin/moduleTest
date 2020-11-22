using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNS
{
	public class Calculator
	{
		public Calculator(){}
		public double summa(double a, double b)
		{
			return a + b;
		}
		public double multiplication (double a , double b)
		{
			return a * b;
		}
		public double division(double a, double b)
		{
			try
			{
				if (b == 0)
				{
					throw new DivideByZeroException();
				}
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine("Делить на ноль нельзя");
			}
			return a / b;
		}
		public double minus(double a, double b)
		{
			return a - b;
		}
		static void Main(string[] args)
		{
			double a, b;
			Console.Write("Первое число: ");
			a = Convert.ToSingle(Console.ReadLine());
			Console.Write("Второе число: ");
			b = Convert.ToSingle(Console.ReadLine());
			printMenu();
			int code;
			double answer  = Double.MaxValue;
			do
			{
				code = Convert.ToInt32(Console.ReadLine());
				answer = doAction(code,a,b);
				if (checkError(answer))
				{
					Console.WriteLine("Неверный пункт меню");
				}
			} while (answer == Double.MaxValue);
			Console.WriteLine("Ответ");
			Console.WriteLine(answer);
			Console.ReadKey();
		}

		private static bool checkError(double answer)
		{
			return answer == Double.MaxValue;
		}

		private static double doAction(int key, double a, double b)
		{
			Calculator calculator = new Calculator();
			double answer = Double.MaxValue;
			switch (key)
			{
				case 1:
					answer = calculator.summa(a, b);
					break;
				case 2:
					answer = calculator.minus(a, b);
					break;
				case 3:
					answer = calculator.multiplication(a, b);
					break;
				case 4:
					answer = calculator.division(a, b);
					break;
				default:
					return answer;
			}
			return answer;
		}

		private static void printMenu()
		{
			Console.WriteLine("Выберите действие");
			Console.WriteLine("1. Сумма");
			Console.WriteLine("2. Разность");
			Console.WriteLine("3. Умножение");
			Console.WriteLine("4. Деление");
		}
	}
}
