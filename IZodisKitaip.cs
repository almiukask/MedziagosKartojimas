using System;
using System.Collections.Generic;
using System.Text;

namespace MedziagosKartojimas
{
	public interface IZodisKitaip
	{
		public string ZodisBeBalsiu();
		public string ZodisBePriebalsiu();
		public string ZodisSuPakeistomisBalsemis(char symbol);
		public string ZodisSuPakeistomisPriebalsemis(int index);
	}
}
