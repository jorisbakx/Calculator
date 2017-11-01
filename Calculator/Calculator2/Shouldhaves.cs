using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
	class Shouldhaves : CalculatorShouldhaves;
	{
		public int Max(int getal1, int getal2)
		{
			if ( getal1 > getal2)
				return getal1;
			else return getal2;
			
		}

		public int Min(int getal1, int getal2)
		{
			if (getal1 < getal2)
				return getal1;
			else return getal2;
		}

		public int Rest(int getal1, int getal2)
		{
			throw new NotImplementedException();
		}
	}
}
