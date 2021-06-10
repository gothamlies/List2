using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<int> ert = new MyList<int>();
			ert.Add(45);
			ert.Add(55);
			ert.Add(65);
			ert.AddFront(89);
			ert.Print();
			ert.PushBack(10); //Добавление элемента в начале списка
			ert.PushFront(50);

			Console.WriteLine();
			ert.Print();
			Console.WriteLine("\nПервый элемент списка");
			Console.WriteLine(ert.Get(0));
			Console.WriteLine();

			Console.WriteLine();
			ert.Print();
			Console.WriteLine("\nПоследний элемент списка");
			Console.WriteLine(ert.Get(4));
			Console.WriteLine();

			Console.WriteLine();
			ert.Print();
			Console.WriteLine("\nСписок в обратном порядке");
			ert.PrintBackward();
			Console.ReadKey();
		}
	}
}