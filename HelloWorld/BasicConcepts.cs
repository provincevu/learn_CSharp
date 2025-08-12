using System;
using System.Collections.Generic; // Added for List

namespace HelloWorld
{
    public class BasicConcepts
    {
        // 1. Variables và Data Types
        public static void VariablesExample()
        {
            Console.WriteLine("=== Variables và Data Types ===");
            
            // Integer types
            int number = 42;
            long bigNumber = 1234567890L;
            
            // Floating point types
            float price = 19.99f;
            double pi = 3.14159265359;
            decimal money = 100.50m;
            
            // Text types
            string name = "C# Learner";
            char grade = 'A';
            
            // Boolean type
            bool isLearning = true;
            
            // Display values
            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Big Number: {bigNumber}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Pi: {pi}");
            Console.WriteLine($"Money: {money}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Is Learning: {isLearning}");
            Console.WriteLine();
        }
        
        // 2. Control Structures
        public static void ControlStructuresExample()
        {
            Console.WriteLine("=== Control Structures ===");
            
            int age = 18;
            
            // If-else statement
            if (age >= 18)
            {
                Console.WriteLine("Bạn đã trưởng thành!");
            }
            else
            {
                Console.WriteLine("Bạn chưa trưởng thành.");
            }
            
            // Switch statement
            int dayOfWeek = 3;
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Thứ Hai");
                    break;
                case 2:
                    Console.WriteLine("Thứ Ba");
                    break;
                case 3:
                    Console.WriteLine("Thứ Tư");
                    break;
                default:
                    Console.WriteLine("Ngày khác");
                    break;
            }
            Console.WriteLine();
        }
        
        // 3. Loops
        public static void LoopsExample()
        {
            Console.WriteLine("=== Loops ===");
            
            // For loop
            Console.WriteLine("For loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            
            // While loop
            Console.WriteLine("While loop:");
            int j = 1;
            while (j <= 3)
            {
                Console.Write($"{j} ");
                j++;
            }
            Console.WriteLine();
            
            // Foreach loop
            Console.WriteLine("Foreach loop:");
            string[] fruits = { "Apple", "Banana", "Orange" };
            foreach (string fruit in fruits)
            {
                Console.Write($"{fruit} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        
        // 4. Methods
        public static int Add(int a, int b)
        {
            return a + b;
        }
        
        public static void MethodsExample()
        {
            Console.WriteLine("=== Methods ===");
            
            int result = Add(5, 3);
            Console.WriteLine($"5 + 3 = {result}");
            
            // Method với optional parameters
            GreetPerson("Alice");
            GreetPerson("Bob", "Chào buổi sáng");
            Console.WriteLine();
        }
        
        public static void GreetPerson(string name, string greeting = "Xin chào")
        {
            Console.WriteLine($"{greeting}, {name}!");
        }
        
        // 5. Arrays và Collections
        public static void ArraysExample()
        {
            Console.WriteLine("=== Arrays và Collections ===");
            
            // Array
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array:");
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            
            // List
            List<string> colors = new List<string> { "Red", "Green", "Blue" };
            colors.Add("Yellow");
            Console.WriteLine("List:");
            foreach (string color in colors)
            {
                Console.Write($"{color} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        
        // 6. Classes và Objects
        public static void ClassesExample()
        {
            Console.WriteLine("=== Classes và Objects ===");
            
            Person person1 = new Person("John", 25);
            Person person2 = new Person("Jane", 30);
            
            person1.Introduce();
            person2.Introduce();
            
            Console.WriteLine($"John's age: {person1.Age}");
            person1.Age = 26;
            Console.WriteLine($"John's new age: {person1.Age}");
            Console.WriteLine();
        }
    }
    
    // Simple class example
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        
        public void Introduce()
        {
            Console.WriteLine($"Xin chào, tôi là {Name} và tôi {Age} tuổi.");
        }
    }
}
