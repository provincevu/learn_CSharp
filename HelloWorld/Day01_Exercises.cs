using System;

namespace HelloWorld
{
    public class Day01_Exercises
    {
        public static void RunExercises()
        {
            Console.WriteLine("=== BÀI TẬP NGÀY 1: BIẾN VÀ KIỂU DỮ LIỆU ===");
            
            // BÀI TẬP 1: Khai báo biến thông tin cá nhân
            // TODO: Khai báo các biến sau:
            // - Tên của bạn (string)
            string name = "Vũ Văn Tỉnh";
            // - Tuổi của bạn (int)
            int age = 21;
            // - Chiều cao (double, đơn vị mét)
            double height = 1.83;
            // - Cân nặng (double, đơn vị kg)
            double weight = 80.3;
            // - Thành phố sinh sống (string)
            string city = "Hanoi";
            // - Số điện thoại (string)
            string phone = "012345678";
            // In ra thông tin này theo format đẹp
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Weight: {weight}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine($"Phone: {phone}");

            Console.WriteLine("-------------------------------");
            // BÀI TẬP 2: Tính toán cơ bản
            // TODO: Cho bán kính hình tròn = 7.5
            double r = 7.5;
            // Tính và in ra:
            // - Chu vi hình tròn (C = 2 * π * r)
            // - Diện tích hình tròn (S = π * r²)
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            // Làm tròn kết quả đến 2 chữ số thập phân
            Console.WriteLine($"chu vi: {perimeter:F2}");
            Console.WriteLine($"dien tich: {area:F2}");


            Console.WriteLine("-------------------------------");



            // BÀI TẬP 3: Chuyển đổi đơn vị
            // TODO: Cho nhiệt độ = 32 độ Celsius
            double Censius = 32;
            // Chuyển đổi sang:
            // - Fahrenheit (F = C * 9/5 + 32)
            double F_temp = Censius * 9 / 5 + 32;
            // - Kelvin (K = C + 273.15)
            double K_temp = Censius + 273.15;
            // In kết quả với 1 chữ số thập phân
            Console.WriteLine($"do C: {Censius:F1}");
            Console.WriteLine($"do F: {F_temp:F1}");
            Console.WriteLine($"do K: {K_temp:F1}");

            Console.WriteLine("-------------------------------");

            // BÀI TẬP 4: Sử dụng var và dynamic
            // TODO: 
            // - Tạo biến var chứa số 42
            var numb = 42;
            // - Tạo biến dynamic chứa chuỗi "Hello"
            dynamic hel = "hello";
            // - In ra kiểu dữ liệu của cả hai biến (sử dụng GetType())
            Console.WriteLine(numb.GetType());
            Console.WriteLine(hel.GetType());

            Console.WriteLine("-------------------------------");


            // BÀI TẬP 5: Nullable types
            // TODO:
            // - Tạo biến int? có thể null
            int? nint;
            // - Gán giá trị null cho biến đó
            nint = null;
            // - Sử dụng null-coalescing operator (??) để gán giá trị mặc định là 0
            var int0 = nint ?? 0;
            // - In ra kết quả
            Console.WriteLine($"biến int null: {nint}");
            Console.WriteLine($"null-coalescing operator: {int0}");


            Console.WriteLine("\n=== HẾT BÀI TẬP NGÀY 1 ===");
        }
    }
}
