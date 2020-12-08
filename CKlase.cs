using System;
using System.Collections.Generic;
using System.Text;

namespace MedziagosKartojimas
{
	public class CKlase : BKlase
	{
		string vidinisName;

		public CKlase()
		{

		}

		public CKlase(int skaicius)
		{
			Skaicius = skaicius;
		}

		public CKlase(int skaicius, string zodis) : this(skaicius)
		{
			Zodis = zodis;
		}

		public CKlase(int skaicius, string zodis, double doubleSkaicius, AKlase aObjekstas) : this(skaicius, zodis)
		{
			DoubleSkaicius = doubleSkaicius;
			AObjekstas = aObjekstas;
		}

		public int Skaicius { get; set; }
		public string Zodis { get; set; }
		public double DoubleSkaicius { get; set; }

		public AKlase AObjekstas { get; set; }
	}
}
