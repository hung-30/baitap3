using System;
using System.Text;

namespace BankAccountManagement
{
    public class BankAccount
    {
        // Trường dữ liệu tĩnh cấp phát số tài khoản tự động
        private static long _nextAccountNumber = 1000000001;

        // Backing fields
        private string _accountHolder = string.Empty;
        private decimal _balance;

        // Thuộc tính Số tài khoản (chỉ gán 1 lần khi khởi tạo)
        public long AccountNumber { get; init; }

        // Thuộc tính Chủ tài khoản với kiểm tra tính hợp lệ
        public string AccountHolder
        {
            get => _accountHolder;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tên chủ tài khoản không được để trống hoặc null.");
                }
                _accountHolder = value;
            }
        }

        // Thuộc tính Số dư (chỉ cho phép đọc từ bên ngoài)
        public decimal Balance
        {
            get => _balance;
        }

        // Constructor
        public BankAccount(string accountHolder, decimal initialBalance)
        {
            if (initialBalance < 50_000m)
            {
                throw new ArgumentException("Số dư khởi tạo tối thiểu phải từ 50,000 VNĐ.");
            }

            AccountNumber = _nextAccountNumber++;
            AccountHolder = accountHolder;
            _balance = initialBalance;
        }

        // Phương thức Nạp tiền
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Số tiền nạp phải lớn hơn 0.");
            }

            _balance += amount;
            Console.WriteLine($"[Giao dịch] Nạp thành công {amount:N0} VNĐ vào tài khoản {AccountNumber}.");
        }

        // Phương thức Rút tiền
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("[Thất bại] Số tiền rút phải lớn hơn 0.");
                return false;
            }

            const decimal MINIMUM_BALANCE = 50_000m;
            if (_balance - amount < MINIMUM_BALANCE)
            {
                Console.WriteLine($"[Thất bại] Số dư còn lại sau khi rút không được dưới {MINIMUM_BALANCE:N0} VNĐ. (Số dư hiện tại: {_balance:N0} VNĐ, Yêu cầu rút: {amount:N0} VNĐ)");
                return false;
            }

            _balance -= amount;
            Console.WriteLine($"[Giao dịch] Rút thành công {amount:N0} VNĐ từ tài khoản {AccountNumber}.");
            return true;
        }

        // Hiển thị thông tin tài khoản
        public void DisplayInfo()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Số tài khoản : {AccountNumber}");
            Console.WriteLine($"Chủ tài khoản: {AccountHolder}");
            Console.WriteLine($"Số dư        : {Balance:N0} VNĐ");
            Console.WriteLine("----------------------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("=== KHỞI TẠO TÀI KHOẢN ===");

            BankAccount acc1 = null!;
            BankAccount acc2 = null!;

            // 1. Khởi tạo 2 tài khoản hợp lệ
            try
            {
                acc1 = new BankAccount("Nguyễn Văn A", 100_000m);
                acc2 = new BankAccount("Trần Thị B", 500_000m);
                Console.WriteLine("-> Tạo thành công 2 tài khoản hợp lệ.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Lỗi tạo tài khoản: {ex.Message}");
            }

            // 2. Khởi tạo 1 tài khoản không hợp lệ (số dư < 50,000 VNĐ) để kiểm tra bắt lỗi
            try
            {
                Console.WriteLine("\nĐang thử tạo tài khoản với số dư 20,000 VNĐ...");
                BankAccount accInvalid = new BankAccount("Lê Văn C", 20_000m);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"-> Bắt lỗi thành công: {ex.Message}");
            }

            // Hiển thị thông tin ban đầu
            Console.WriteLine("\n=== THÔNG TIN BAN ĐẦU ===");
            acc1?.DisplayInfo();
            acc2?.DisplayInfo();

            // 3. Thực hiện các thao tác nạp / rút tiền
            Console.WriteLine("=== THỰC HIỆN GIAO DỊCH ===");

            if (acc1 != null)
            {
                // Nạp tiền hợp lệ
                try
                {
                    acc1.Deposit(200_000m); // Số dư tăng lên 300,000
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Lỗi: {ex.Message}");
                }

                // Rút tiền hợp lệ
                acc1.Withdraw(150_000m); // Số dư còn 150,000

                // Rút tiền vi phạm hạn mức tối thiểu (còn lại < 50,000 VNĐ)
                acc1.Withdraw(120_000m); // Cần giữ lại 50,000 -> Chỉ được rút tối đa 100,000 -> Bị từ chối
            }

            // Hiển thị thông tin sau giao dịch
            Console.WriteLine("\n=== THÔNG TIN SAU GIAO DỊCH ===");
            acc1?.DisplayInfo();
            acc2?.DisplayInfo();
        }
    }
}