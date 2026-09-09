using System;
using System.Text;

namespace EmployeeHierarchy
{
    // 1. Lớp cha Person
    public class Person
    {
        // Thuộc tính Id sử dụng 'init' để chỉ cho phép gán lúc khởi tạo
        public string Id { get; init; }
        public string FullName { get; set; }
        public int BirthYear { get; set; }

        // Constructor khởi tạo 3 tham số
        public Person(string id, string fullName, int birthYear)
        {
            Id = id;
            FullName = fullName;
            BirthYear = birthYear;
        }

        // Phương thức tính tuổi
        public int GetAge(int currentYear)
        {
            return currentYear - BirthYear;
        }
    }

    // 2. Lớp con Employee kế thừa từ Person
    public class Employee : Person
    {
        public decimal BaseSalary { get; set; }

        // Sử dụng từ khóa 'base' để truyền tham số lên Constructor của lớp cha (Person)
        public Employee(string id, string fullName, int birthYear, decimal baseSalary)
            : base(id, fullName, birthYear)
        {
            BaseSalary = baseSalary;
        }

        // Phương thức ảo (virtual) cho phép lớp con ghi đè
        public virtual decimal CalculateIncome()
        {
            return BaseSalary;
        }
    }

    // 3. Lớp con Manager kế thừa từ Employee và đánh dấu sealed
    // Từ khóa 'sealed' ngăn chặn các lớp khác kế thừa từ lớp Manager này.
    public sealed class Manager : Employee
    {
        public decimal ResponsibilityAllowance { get; set; }

        // Gọi constructor của lớp cha (Employee) thông qua 'base'
        public Manager(string id, string fullName, int birthYear, decimal baseSalary, decimal allowance)
            : base(id, fullName, birthYear, baseSalary)
        {
            ResponsibilityAllowance = allowance;
        }

        // Ghi đè phương thức tính thu nhập của Employee
        public override decimal CalculateIncome()
        {
            return BaseSalary + ResponsibilityAllowance;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Hỗ trợ in tiếng Việt có dấu
            Console.OutputEncoding = Encoding.UTF8;

            int currentYear = DateTime.Now.Year;

            // Khởi tạo đối tượng Employee
            Employee emp = new Employee(
                id: "EMP001",
                fullName: "Nguyễn Văn A",
                birthYear: 1995,
                baseSalary: 15_000_000m
            );

            // Khởi tạo đối tượng Manager
            Manager mgr = new Manager(
                id: "MGR001",
                fullName: "Trần Thị A",
                birthYear: 1985,
                baseSalary: 25_000_000m,
                allowance: 10_000_000m
            );

            Console.WriteLine("=== PHIẾU LƯƠNG NHÂN VIÊN ===");
            PrintPaySlip(emp, currentYear);

            Console.WriteLine("\n=== PHIẾU LƯƠNG QUẢN LÝ ===");
            PrintPaySlip(mgr, currentYear);
        }

        // Phương thức hỗ trợ in phiếu lương chung cho mọi nhân viên (thể hiện tính đa hình)
        static void PrintPaySlip(Employee employee, int currentYear)
        {
            Console.WriteLine($"Mã NV        : {employee.Id}");
            Console.WriteLine($"Họ và Tên    : {employee.FullName}");
            Console.WriteLine($"Tuổi         : {employee.GetAge(currentYear)} (Sinh năm {employee.BirthYear})");
            Console.WriteLine($"Lương cơ bản : {employee.BaseSalary:N0} VNĐ");

            // Nhờ tính đa hình (Polymorphism), phương thức CalculateIncome() 
            // sẽ tự động gọi đúng phiên bản của Employee hoặc Manager lúc runtime.
            Console.WriteLine($"Thu nhập thực: {employee.CalculateIncome():N0} VNĐ");
        }
    }
}