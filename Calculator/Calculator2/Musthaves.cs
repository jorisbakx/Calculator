using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
	class Musthaves: CalculatorMusthaves
	{
		public int Diff(int getal1, int getal2)
		{
			int getal3 = getal1 - getal2;
			return getal3;
		}

		public int Product(int getal1, int getal2)
		{
			int getal3 = getal1 * getal2;
			return getal3;
		}

		public int Quotient(int getal1, int getal2)
		{
			int getal3 = getal1 / getal2;
			return getal3;
		}

		public int Sum(int getal1, int getal2)
		{
			int getal3 = getal1 + getal2;
			return getal3;
		}
	}
}
