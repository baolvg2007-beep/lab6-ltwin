using System;
using System.ComponentModel;

namespace ProductManager
{
    public class Product
    {
        [DisplayName("Mã SP")]
        public string MaSP { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string TenSP { get; set; }

        [DisplayName("Loại sản phẩm")]
        public string LoaiSP { get; set; }

        [DisplayName("Đơn giá (VNĐ)")]
        public decimal DonGia { get; set; }

        [DisplayName("Số lượng")]
        public int SoLuong { get; set; }

        [DisplayName("Ngày nhập")]
        public DateTime NgayNhap { get; set; }

        [DisplayName("Còn kinh doanh")]
        public bool ConKinhDoanh { get; set; }

        [DisplayName("Đường dẫn ảnh")]
        public string DuongDanAnh { get; set; }

        [DisplayName("Thành tiền (VNĐ)")]
        public decimal ThanhTien => DonGia * SoLuong;

        [DisplayName("Trạng thái")]
        public string TrangThaiText => ConKinhDoanh ? "Còn kinh doanh" : "Ngừng kinh doanh";

        public Product()
        {
            MaSP = string.Empty;
            TenSP = string.Empty;
            LoaiSP = string.Empty;
            NgayNhap = DateTime.Now;
            ConKinhDoanh = true;
            DuongDanAnh = string.Empty;
        }

        public Product(string maSP, string tenSP, string loaiSP, decimal donGia, int soLuong, DateTime ngayNhap, bool conKinhDoanh, string duongDanAnh = "")
        {
            MaSP = maSP;
            TenSP = tenSP;
            LoaiSP = loaiSP;
            DonGia = donGia;
            SoLuong = soLuong;
            NgayNhap = ngayNhap;
            ConKinhDoanh = conKinhDoanh;
            DuongDanAnh = duongDanAnh ?? string.Empty;
        }
    }
}
