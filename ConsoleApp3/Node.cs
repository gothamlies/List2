using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Node<T>
	{
		public T value;
		public Node<T> next;
		public Node<T> prev;
		public int index;
		public Node<T> head;

		public void SetIndex(int index)
		{
			this.index = index;
		}
		public static int Count = 0;
		public Node(T value)
		{
			this.value = value;
		}

		public Node()
		{

		}
	}
}