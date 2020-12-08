using System;
using System.Collections.Generic;
using System.Text;

namespace MedziagosKartojimas
{
	public class BKlase : AKlase, IZodisKitaip
	{
		string vidinisName;

		public BKlase()
		{
		}

		public BKlase(string name):base(name)
		{
			name = vidinisName;
		}

		public override int NameKodas(int a)
		{
			char[] array = vidinisName.ToCharArray();
			int laikinas = 0, sandauga = 1;
			bool flag;
			foreach (var ch in array)
			{
				flag = Int32.TryParse(Encoding.ASCII.GetBytes(ch.ToString()).ToString(), out laikinas);
				if (flag) sandauga = sandauga * laikinas * a;
			}
			return sandauga;
		}

		public string ZodisBeBalsiu()
		{
			StringBuilder naujasZodis = new StringBuilder();
			foreach (var ch in vidinisName)
			{
				if (!Arbalse(ch)) naujasZodis.Append(ch);

			}
			return naujasZodis.ToString();
		}

		public string ZodisBePriebalsiu()
		{
			StringBuilder naujasZodis = new StringBuilder();
			foreach (var ch in vidinisName)
			{
				if (Arbalse(ch)) naujasZodis.Append(ch);
			}
			return naujasZodis.ToString();
		}

		public string ZodisSuPakeistomisBalsemis(char symbol)
		{
			StringBuilder naujasZodis = new StringBuilder();
			foreach (var ch in vidinisName)
			{
				if (Arbalse(ch)) naujasZodis.Append(symbol);
				else naujasZodis.Append(ch);
			}
			return naujasZodis.ToString();
		}

		public string ZodisSuPakeistomisPriebalsemis(int number)
		{
			StringBuilder naujasZodis = new StringBuilder();
			foreach (var ch in vidinisName)
			{
				if (!Arbalse(ch)) naujasZodis.Append(number);
				else naujasZodis.Append(ch);
			}
			return naujasZodis.ToString();
		}
	}
}
