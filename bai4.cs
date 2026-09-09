using System;
using System.Text;

namespace PaymentGatewaySystem
{
    // =========================================================================
    // 1. ĐỊNH NGHĨA CÁC INTERFACES ("Can-Do" - Năng lực giao tiếp)
    // =========================================================================

    public interface IPayable
    {
        bool ProcessPayment(decimal amount);
    }

    public interface IRefundable
    {
        bool ProcessRefund(decimal amount, string reason);
    }

    // =========================================================================
    // 2. LỚP TRỪU TƯỢNG (ABSTRACT CLASS) ("Is-A" - Bản chất cốt lõi)
    // =========================================================================

    public abstract class PaymentGateway
    {
        // Sử dụng 'init' để mã giao dịch và ngày tạo chỉ được gán 1 lần lúc khởi tạo
        public string TransactionId { get; init; }
        public DateTime CreationDate { get; init; }

        // Trạng thái chỉ cho phép lớp này và các lớp con (protected) sửa đổi
        public string Status { get; protected set; }

        // Constructor bảo vệ (protected) vì lớp trừu tượng không thể khởi tạo trực tiếp
        protected PaymentGateway(string transactionId)
        {
            TransactionId = transactionId;
            CreationDate = DateTime.Now;
            Status = "Pending"; // Trạng thái mặc định ban đầu
        }

        // Phương thức trừu tượng bắt buộc các lớp con phải tự triển khai chi tiết
        public abstract void ValidateConnection();

        // Phương thức ảo có sẵn logic chung, lớp con có thể dùng lại hoặc ghi đè
        public virtual void LogTransaction(string message)
        {
            Console.WriteLine($"[LOG - {CreationDate:HH:mm:ss}] {TransactionId} | Trạng thái: {Status} | {message}");
        }
    }

    // =========================================================================
    // 3. LỚP CỤ THỂ (CONCRETE CLASS)
    // =========================================================================

    // MomoPayment "là một" PaymentGateway và "có khả năng" thanh toán, hoàn tiền
    public class MomoPayment : PaymentGateway, IPayable, IRefundable
    {
        public string PhoneNumber { get; set; }

        public MomoPayment(string transactionId, string phoneNumber)
            : base(transactionId) // Gọi constructor của lớp cha
        {
            PhoneNumber = phoneNumber;
        }

        // 3.1 Cài đặt phương thức trừu tượng của PaymentGateway
        public override void ValidateConnection()
        {
            Console.WriteLine($"[MoMo] Đang kiểm tra kết nối API MoMo cho tài khoản {PhoneNumber}...");
            LogTransaction("Kết nối API thành công.");
        }

        // 3.2 Cài đặt interface IPayable
        public bool ProcessPayment(decimal amount)
        {
            Console.WriteLine($"\n[MoMo] Đang xử lý yêu cầu thanh toán {amount:N0} VNĐ...");

            // Thay đổi trạng thái (hợp lệ vì Status có 'protected set')
            Status = "Success";

            LogTransaction($"Thanh toán thành công {amount:N0} VNĐ.");
            return true;
        }

        // 3.3 Cài đặt interface IRefundable
        public bool ProcessRefund(decimal amount, string reason)
        {
            Console.WriteLine($"\n[MoMo] Đang xử lý yêu cầu hoàn tiền {amount:N0} VNĐ...");
            Console.WriteLine($"[MoMo] Lý do hoàn tiền: {reason}");

            Status = "Refunded";

            LogTransaction($"Hoàn tiền thành công {amount:N0} VNĐ.");
            return true;
        }
    }

    // =========================================================================
    // 4. KỊCH BẢN KIỂM THỬ (MAIN)
    // =========================================================================

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("=== KHỞI TẠO CỔNG THANH TOÁN MOMO ===\n");

            // Khởi tạo đối tượng cụ thể
            MomoPayment momo = new MomoPayment("TXN-998877", "0901234567");
            momo.ValidateConnection();

            // Ép kiểu đối tượng sang interface IPayable để gọi hành vi thanh toán
            // Giúp chương trình chỉ quan tâm đến khả năng "thanh toán" mà không cần biết chi tiết lớp Momo
            IPayable payableInterface = momo;
            payableInterface.ProcessPayment(1_500_000m);

            // Ép kiểu đối tượng sang interface IRefundable để gọi hành vi hoàn tiền
            IRefundable refundableInterface = momo;
            refundableInterface.ProcessRefund(1_500_000m, "Khách hàng đổi ý, hủy đơn hàng");

            Console.ReadLine();
        }
    }
}