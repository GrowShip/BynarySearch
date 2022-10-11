using System;

namespace BynarySearch
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(FindLeftBorder(new long[] {2, 4, 4, 6}, 1));
			Console.WriteLine(FindLeftBorder(new long[] {2, 4, 4, 6}, 2));
			Console.WriteLine(FindLeftBorder(new long[] {2, 4, 4, 6}, 3));
			Console.WriteLine(FindLeftBorder(new long[] {2, 4, 4, 6}, 4));
			Console.WriteLine(FindLeftBorder(new long[] {2, 4, 4, 6}, 5));
			Console.WriteLine(FindLeftBorder(new long[] {2, 4, 4, 6}, 6));
			Console.WriteLine(FindLeftBorder(new long[] {2, 4, 4, 6}, 7));
			Console.WriteLine(FindLeftBorder(new long[] {}, -1));
			
			
		}
		private static int FindLeftBorder(long[] arr, long value)
		{
			return BinSearchLeftBorder(arr, value, -1, arr.Length);
		}
		public static int BinSearchLeftBorder(long[] array, long value, int left, int right)
		{
			if (left+1 == array.Length  || array[left+1] >= value) return left;
			var m = (left + right) / 2;
			if (array[m] < value)
				return BinSearchLeftBorder(array, value, m, right);
			return BinSearchLeftBorder(array, value, left, m);
		}
	}
	
}
