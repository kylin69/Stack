using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<string> stack = new Stack<string>(4);
			stack.Push("test1");
			stack.Push("test2");
			Console.WriteLine(stack.Pop());	
			stack.Push("test3");
			Console.WriteLine(stack.Pop());
			stack.Push("test4");
			stack.Push("test5");			
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
		}
	}
}
