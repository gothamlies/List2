using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class MyList<T>
	{
		public void Add(T value)
		{
			Node<T> asd = new Node<T>();
			asd.value = value;
			if (firstElement == null)
			{
				firstElement = asd;
			}
			else
			{
				asd.prev = GetLast();
				GetLast().next = asd;
			}


		}
		Node<T> firstElement;
		Node<T> GetLast()
		{
			Node<T> last = firstElement;

			while (last.next != null)
			{
				last = last.next;
			}
			return last;
		}
		public void Print()
		{
			Node<T> last = GetFirst();
			while (last != null)
			{
				Console.WriteLine(last.value);
				last = last.next;

			}
		}
		public void AddFront(T value) //Выводит предыдущий элемент
		{
			Node<T> rtd = new Node<T>();
			rtd.value = value;

			if (firstElement == null)
			{
				firstElement = rtd;
			}
			else
			{
				rtd.next = GetFirst();
				rtd.next.prev = rtd;
			}
		}
		Node<T> GetFirst()

		{
			Node<T> last = firstElement;

			while (last.prev != null)
			{
				last = last.prev;
			}
			return last;
		}

		public T Get(int index) //Добавляем новый элемент в конец списка
		{
			Node<T> node = firstElement;
			for (int i = 0; i < index; i++)
			{
				node = node.next;
			}
			return node.value;
		}



		public void PushBack(T value) //Добавляем новый элемент в начало списка
		{
			Node<T> node = new Node<T>();
			node.value = value;
			node.next = firstElement;
			firstElement.prev = node;
			firstElement = node;
		}



		public void PushFront(T value) //Получаем последний элемент списка
		{
			Node<T> node = new Node<T>();
			node.value = value;
			node.next = firstElement;
			firstElement.prev = node;
			firstElement = node;
		}



		public void PrintForward() //Выводим значения всего списка в обратном порядке
		{
			MyList<int> list = new MyList<int>();
			list.PushBack(3);
			list.PushBack(4);
			list.PushBack(5);
			list.PushBack(8);

			list.PushFront(99);
			list.PushFront(98);
			list.PushFront(97);

			Console.WriteLine("Print forward");
			list.PrintForward();

			Console.WriteLine("\nPrint backward");
			list.PrintBackward();
		}




		public void PrintBackward()
		{
			Node<T> c = GetLast();
			while (c != null)
			{
				Console.WriteLine(c.value);
				c = c.prev;
			}
		
		}

		public void Remove(int i)
		{
			List<int> x = new List<int>();
		}

		
	}
}