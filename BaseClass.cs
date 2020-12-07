using System;
using System.Collections.Generic;
using System.Text;

namespace MedziagosKartojimas
{
	abstract public class BaseClass
	{
		public BaseClass(string name)
		{
			Name = name;
		}

		public readonly string Name;
		public abstract string NameMetodas();
		public abstract int NameKodas(int a);

	}
}
