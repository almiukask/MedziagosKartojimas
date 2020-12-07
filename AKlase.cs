﻿using System;
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

		public string vidinisName { get; set; }

		public override int NameKodas(int a)
		{
			
			throw new NotImplementedException();
		}


		public override string NameMetodas()
		{
			char[]array = vidinisName.ToCharArray();
			StringBuilder naujasZodis = new StringBuilder();
			foreach (var ch in vidinisName)
			{
				foreach (var balse in balses)
				{
					if (ch == balse) naujasZodis.Append(Encoding.ASCII.GetBytes(ch.ToString()));
					else naujasZodis.Append(ch);
				}
			}
			return naujasZodis.ToString();
		}
	}
}
