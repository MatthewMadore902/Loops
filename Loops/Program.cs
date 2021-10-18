using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Before Loops");
			//Display number 1 - 10 

			Console.WriteLine(1);
			Console.WriteLine(2);
			Console.WriteLine(3);
			Console.WriteLine(4);
			Console.WriteLine(5);
			Console.WriteLine(6);
			Console.WriteLine(7);
			Console.WriteLine(8);
			Console.WriteLine(9);
			Console.WriteLine(10);


			Console.WriteLine("Another way Before Loops");

			//Display number 1 - 10
			int count;
			count = 1;

			Console.WriteLine(count); count = count + 1;
			Console.WriteLine(count); count = count + 1;
			Console.WriteLine(count); count = count + 1;
			Console.WriteLine(count); count = count + 1;
			Console.WriteLine(count); count = count + 1;
			Console.WriteLine(count); count = count + 1;
			Console.WriteLine(count); count = count + 1; 
			Console.WriteLine(count); count = count + 1;
			Console.WriteLine(count); count = count + 1;
			Console.WriteLine(count); count = count + 1;
			Console.WriteLine(count); count = count + 1;
			Console.WriteLine(count); count = count + 1;
			Console.WriteLine(count); count = count + 1;
			Console.WriteLine(count); count = count + 1;
			Console.WriteLine(count); count = count + 1;
			Console.WriteLine(count); count = count + 1;

			Console.WriteLine("Loops");
			Console.WriteLine();

			// for loops components:
			// 1) declaration/initialization of loop variables
			// 2) stop condition
			// 3) increment loop variable
			// ++ means +1

			int 
			for (int i = 1; i <= 10; i = i + 1)
			{
				Console.WriteLine(i);

			}
			Console.ReadKey(true);
		}
	}
}
