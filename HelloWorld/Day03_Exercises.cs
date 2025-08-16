/*
Ngày 3 – Mảng & List Nhập mảng 5 số nguyên, in ra số lớn nhất và nhỏ nhất. 
Tạo List<int> chứa 10 số ngẫu nhiên (1–100), in ra các số > 50. 
Dùng LINQ để lấy các số chẵn từ List<int> trên.
*/

using System;

namespace Day3
{
	public class Day3Exercise
	{
		public static void RunExcercise(){

			// Bài 1: Mảng & List Nhập mảng 5 số nguyên, in ra số lớn nhất và nhỏ nhất. 
			int[] numbers = new int[5];
			for(int i=0; i<numbers.Length; i++){
				Console.WriteLine($"Nhập phần tử thứ {i+1} của mảng:");
				numbers[i] = Convert.ToInt32(Console.ReadLine());
			}
			
			Console.Write("Mảng bạn vừa nhập vào: ");
			Console.WriteLine(string.Join(" ", numbers));

			// in ra số lớn nhất và nhỏ nhất
			Console.WriteLine($"số nhỏ nhất: {Min(numbers)}");
			Console.WriteLine($"số lớn nhất: {Max(numbers)}");



			// Bài 2: Tạo List<int> chứa 10 số ngẫu nhiên (1–100), in ra các số > 50. 
			List<int> list_numbers = new List<int>(10);
			Random rand = new Random();
			for(int i=0; i<10; i++)
				list_numbers.Add(rand.Next(1, 101));

			Console.Write("10 phần tử trong list: ");
			foreach(int n in list_numbers)
				Console.Write($"{n} ");

			Console.WriteLine("các số lớn hơn 50 trong list:");
			foreach(int n in list_numbers)
				if(n > 50)
					Console.Write($"{n} ");
				


			// Bài 3: Dùng LINQ để lấy các số chẵn từ List<int> trên.
			string result_b3;
			result_b3 = string.Join(", ", list_numbers.Where(n => n % 2 ==0));
			Console.Write("\n");
			Console.WriteLine("các số chia hết cho 2 trong list:");
			Console.WriteLine(result_b3);

		}
		private static int Min(int[] a){
			int min = a[0];
			foreach(int m in a){
				if (min > m)
					min = m;
			}
			return min;
		}
		private static int Max(int[] a){
			int max = a[0];
			foreach(int m in a){
				if (max < m)
					max = m;
			}
			return max;
		}
	}
}