using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Задачник_по_cshp
{
	internal class Double
	{
		static void Main(string[] args)
		{
			double a = Convert.ToDouble(Console.ReadLine());
			a = Math.Round(a, 2);
			Console.WriteLine($"число  с точностью до сотых {a}");

		}
	}
}
