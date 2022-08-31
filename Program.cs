using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniMaxPlus
{
	class Result
	{
		public static void miniMaxSum(List<int> arr)
		{
			var sum = new List<int>();

			foreach (var item in arr)
			{
				sum.Add(arr.Sum() - item);
			}

			Console.WriteLine($"Minimum Sum: {sum.Min()} - Maximum Sum: {sum.Max()}");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{

			List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

			Result.miniMaxSum(arr);

			Console.ReadKey();
		}
	}
}
