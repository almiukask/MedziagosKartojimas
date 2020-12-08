using System;
using System.Collections.Generic;
using System.Text;

namespace MedziagosKartojimas
{
	public class Customer
	{
		public Customer()
		{
		}

		public Customer(string name, string bank, double balance)
		{
			Name = name;
			Bank = bank;
			Balance = balance;
		}

		public string Name { get; set; }
		public string Bank { get; set; }
		public double Balance { get; set; }
	}
}
