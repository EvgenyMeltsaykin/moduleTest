﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator;
using System.Threading.Tasks;

namespace Calculator
{
	public class CalculatorMain
	{
		
		static void Main(string[] args)
		{
			do
			{
				Console.Clear();
				string aString, bString;
				Console.Write("Первое число: ");
				aString = Console.ReadLine();
				Console.Write("Второе число: ");
				bString = Console.ReadLine();
				double answer = double.MaxValue;
				InputClass input = new InputClass();
				if (input.wrongInput(aString, bString))
                {
					Console.WriteLine("Неверный ввод");
                }
                else
                {
                    double a = Convert.ToSingle(aString);
                    double b = Convert.ToSingle(bString);
					int code;
					printDataAndMenu(a, b);
					string codeString = Console.ReadLine();
                    try
                    {
						if (input.wrongInputVar(codeString, "int"))
						{
							Console.WriteLine("Неверный пункт меню");
							continue;
						}
						else
						{
							code = Convert.ToInt32(codeString);
							if (rightCodeMenu(code))
							{
								try
								{
									answer = doAction(code, a, b);
								}
								catch (DivideByZeroException ex)
								{
									Console.WriteLine("Ошибка. Деление на 0.");
									break;
								}
								answer = doAction(code, a, b);
							}
							else
							{
								Console.WriteLine("Неверный пункт меню");
								continue;
							}
						}
					}catch(Exception ex)
                    {

                    }
					
					
				}
				if (rightAnswer(answer))
				{
					Console.WriteLine();
					Console.WriteLine("Ответ");
					Console.WriteLine(answer);
				}
				Console.WriteLine();
				Console.WriteLine("Для продолжения нажмите любую клавишу. Для выходa нажмите escape");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);
			
		}

        public static bool rightAnswer(double answer)
        {
            if (answer != double.MaxValue)
            {
				return true;
            }
			return false;
        }

		public static bool rightCodeMenu(int code)
        {
			if (code < 1 || code > 4) return false;
			return true;
        }
		public static double doAction(int key, double a, double b)
		{
			Calc calculator = new Calc();
			double answer = 0;
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
			}
			return answer;
		}

		public static void printDataAndMenu(double a, double b)
		{
			Console.Clear();
			Console.WriteLine("Первое число: {0}", a);
			Console.WriteLine("Второе число: {0}", b);
			Console.WriteLine("Выберите действие");
			Console.WriteLine("1. Сумма");
			Console.WriteLine("2. Разность");
			Console.WriteLine("3. Умножение");
			Console.WriteLine("4. Деление");
		}
	}
}
