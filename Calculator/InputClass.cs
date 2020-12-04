using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public class InputClass
	{


		public bool wrongInputVar(string variable, string type)
		{
			switch (type)
			{
				case "int":
					int a;
					bool isNumeric = int.TryParse(variable, out a);
					return !isNumeric;
				case "double":
					double b;
					isNumeric = double.TryParse(variable, out b);
					return !isNumeric;
				default:
					throw new Exception();

			}
		}
		public bool wrongInput(string aString, string bString)
		{
			bool wrongA = wrongInputVar(aString, "double");
			bool wrongB = wrongInputVar(bString, "double");
			if (wrongA || wrongB) return true;
			return false;
		}
	}
}
