using System;
using System.Collections.Generic;

namespace OrderProcessingSystem
{
    // =========================================================================
    // 1. ĐA HÌNH TẠI THỜI ĐIỂM BIÊN DỊCH (COMPILE-TIME / METHOD OVERLOADING)
    // =========================================================================
    public class DiscountCalculator
    {
        // Phiên bản 1: Giảm mặc định 5% cho tổng đơn hàng
        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount * 0.95m;
        }

        // Phiên bản 2: Giảm theo phần trăm tùy biến (0 - 100)
        public decimal ApplyDiscount(decimal totalAmount, double percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                Console.WriteLine("Phần trăm giảm giá không hợp lệ. Giữ nguyên giá.");
                return totalAmount;
            }

            decimal discountFactor = (decimal)(percentage / 100.0);
            return totalAmount - (totalAmount * discountFactor);
        }

        // Phiên bản 3: Áp dụng mã giảm tiền mặt nếu đạt giá trị đơn hàng tối thiểu
        public decimal ApplyDiscount(decimal totalAmount, decimal fixedVoucher, decimal minimumOrder)
        {
            if (totalAmount >= minimumOrder)
            {
                // Đảm bảo sau khi trừ voucher thì giá trị không bị âm
                decimal finalAmount = totalAmount - fixedVoucher;
                return finalAmount > 0 ? finalAmount : 0;
            }
            return totalAmount; // Không đủ điều kiện áp dụng voucher
        }
    }

    // =========================================================================
    // 2. ĐA HÌNH TẠI THỜI ĐIỂM THỰC THI (RUNTIME / METHOD OVERRIDING)
    // =========================================================================

    // Lớp cha
    public class DeliveryService
    {
        public string OrderId { get; set; }
        public double DistanceKm { get; set; }

        // Từ khóa virtual cho phép các lớp con ghi đè phương thức này
        public virtual decimal CalculateShippingFee()
        {
            return (decimal)DistanceKm * 5000m;
        }
    }

    // Lớp con 1: Giao siêu tốc
    public class ExpressDelivery : DeliveryService
    {
        // Ghi đè (override) công thức tính phí của lớp cha
        public override decimal CalculateShippingFee()
        {
            decimal baseFee = base.CalculateShippingFee(); // Gọi hàm của lớp cha
            return (baseFee * 1.5m) + 20000m;
        }
    }

    // Lớp con 2: Giao tiết kiệm
    public class EcoDelivery : DeliveryService
    {
        // Ghi đè (override) công thức tính phí của lớp cha
        public override decimal CalculateShippingFee()
        {
            decimal baseFee = base.CalculateShippingFee();

            // Nếu quãng đường > 10km, giảm 10%
            if (DistanceKm > 10)
            {
                return baseFee * 0.9m;
            }
            return baseFee;
        }
    }

    // =========================================================================
    // 3. KỊCH BẢN KIỂM THỬ (MAIN)
    // =========================================================================
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Hỗ trợ in tiếng Việt

            // --- TEST OVERLOADING ---
            Console.WriteLine("=== 1. KIỂM THỬ ĐA HÌNH LÚC BIÊN DỊCH (OVERLOADING) ===");
            var calculator = new DiscountCalculator();
            decimal orderTotal = 1000000m; // 1.000.000 VNĐ

            Console.WriteLine($"Giá trị đơn hàng gốc: {orderTotal:N0} VNĐ");
            Console.WriteLine($"- Áp dụng giảm mặc định (5%): {calculator.ApplyDiscount(orderTotal):N0} VNĐ");
            Console.WriteLine($"- Áp dụng giảm tùy biến (20%): {calculator.ApplyDiscount(orderTotal, 20):N0} VNĐ");
            Console.WriteLine($"- Áp dụng voucher 150k (Đơn tối thiểu 500k): {calculator.ApplyDiscount(orderTotal, 150000m, 500000m):N0} VNĐ");

            Console.WriteLine("\n----------------------------------------------------\n");

            // --- TEST OVERRIDING ---
            Console.WriteLine("=== 2. KIỂM THỬ ĐA HÌNH LÚC THỰC THI (OVERRIDING) ===");

            // Tạo danh sách kiểu lớp cha nhưng chứa các đối tượng lớp con khác nhau
            List<DeliveryService> deliveries = new List<DeliveryService>
            {
                new DeliveryService { OrderId = "ORD_001_GiaoThuong", DistanceKm = 12 },
                new ExpressDelivery { OrderId = "ORD_002_SieuToc", DistanceKm = 12 },
                new EcoDelivery { OrderId = "ORD_003_TietKiem_Xa", DistanceKm = 12 },  // > 10km, được giảm 10%
                new EcoDelivery { OrderId = "ORD_004_TietKiem_Gan", DistanceKm = 5 }    // <= 10km, không được giảm
            };

            // Duyệt danh sách và tính phí. 
            // C# sẽ tự động quyết định gọi phương thức CalculateShippingFee() của lớp nào dựa vào kiểu đối tượng thực tế lúc Runtime.
            foreach (var delivery in deliveries)
            {
                Console.WriteLine($"Mã đơn: {delivery.OrderId} | Quãng đường: {delivery.DistanceKm} km");
                Console.WriteLine($"=> Phương thức vận chuyển: {delivery.GetType().Name}");
                Console.WriteLine($"=> Phí vận chuyển: {delivery.CalculateShippingFee():N0} VNĐ\n");
            }

            Console.ReadLine();
        }
    }
}