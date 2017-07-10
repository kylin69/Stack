using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
	public class Stack<T>
	{
		private int _top = -1;
		private T[] _array;

		public Stack(int size)
		{
			if(size < 1)
			{
				throw new Exception();
			}
			_array = new T[size];
		}

		public void Push(T item)
		{
			if(_top < _array.Length - 1)
			{
				_top++;
				_array[_top] = item;
			}
			else
			{

			}
		}

		public T Pop()
		{
			if(_top > -1)
			{				
				return _array[_top--];
			}
			else
			{
				return default(T);
			}
		}
	}
}
