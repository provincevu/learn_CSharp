using System;

/*
### **Bài 1:**  
Nhập vào tên, tuổi từ bàn phím, kiểm tra tuổi >= 18 thì in "Đủ tuổi", ngược lại "Chưa đủ tuổi".

### **Bài 2:**  
Nhập số nguyên N, in ra các số chẵn từ 1 đến N.

### **Bài 3:**  
Nhập 1 số N, kiểm tra xem N có phải số nguyên tố không.

*/

namespace HelloWorld
{
    public class Day02_Exercises
    {
        public static void RunExcercise(){
            Console.WriteLine("Bài tập ngày 2: Cấu trúc điều kiện, vòng lặp, nhập xuất");

            // Bài 1
            Console.WriteLine("Bài 1: \n ---------------------------------------------------------------------");
            string name; int age;
            Console.WriteLine("nhập tên:");
            name = Console.ReadLine();
            Console.WriteLine("Nhập tuổi:");
            age = Convert.ToInt32(Console.ReadLine());
            string result_ex1 = (age < 18) ? "Chưa đủ tuổi" : "Đủ tuổi";

            Console.WriteLine($"tên của bạn là: {name}");
            Console.WriteLine(result_ex1);



            // Bài 2
            Console.WriteLine("Bài 2: \n ---------------------------------------------------------------------");
            int N;
            Console.WriteLine("nhập số nguyên N:");
            N = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= N; i++)
                if (i%2 == 0) Console.Write($"{i} ");

            Console.WriteLine("\n");
            


            // Bài 3
            Console.WriteLine("Bài 3: \n ---------------------------------------------------------------------");
            bool result_ex3 = true;
            if (N % 2 == 0)
                result_ex3 = false;
            else{
                for(int i = 3; i <= Math.Sqrt(N); i+=2){
                    if (N % i == 0){
                        result_ex3 = false;
                        break;
                    }
                }
            }

            if (!result_ex3) 
                Console.WriteLine("N không phải là số nguyên tố");
            else 
                Console.WriteLine("N là số nguyên tố");
        }
    }
}