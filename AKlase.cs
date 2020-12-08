using System;
using System.Collections.Generic;
using System.Text;

namespace MedziagosKartojimas
{
	public class AKlase : BaseClass
	{
		char[] balses = {'a','e','i','o','u','y' };
		public AKlase(string name) : base(name)
		{
			vidinisName = name;
		}

		string vidinisName { get; set; }

		public override int NameKodas(int a)
		{
			char[]array = vidinisName.ToCharArray();
			int laikinas=0, suma=0;
			bool flag;
			foreach (var ch in array)
			{
				flag = Int32.TryParse(Encoding.ASCII.GetBytes(ch.ToString()).ToString(), out laikinas);
				if (flag) suma = suma + laikinas * a;
			}
			return suma;
		}


		public override string NameMetodas()
		{
			StringBuilder naujasZodis = new StringBuilder();
			foreach (var ch in vidinisName)
			{
				if (Arbalse(ch)) naujasZodis.Append(Encoding.ASCII.GetBytes(ch.ToString()));
				else naujasZodis.Append(ch);

			}
			return naujasZodis.ToString();
		}

		public bool Arbalse(char ch)
		{
			bool arBalse = false;
			foreach (var balse in balses)
			{
				if (ch == balse)
				{ arBalse = true; };

			}
			return arBalse;
		}
	}
}
