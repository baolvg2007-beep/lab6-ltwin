# ProductManager - Quản Lý Sản Phẩm (LAB 06)

Ứng dụng Windows Forms quản lý danh sách sản phẩm của cửa hàng.
Môn học: **COMP1019 - Lập trình trên Windows**

---

## 1. Giới thiệu & Cấu trúc Project

Project được thiết kế đầy đủ các yêu cầu theo file hướng dẫn **LAB 06 - Windows Forms Nâng cao và DataGridView**.

### Cấu trúc file nguồn chính:
- **`Product.cs`**: Class lưu trữ thông tin sản phẩm với các thuộc tính (`MaSP`, `TenSP`, `LoaiSP`, `DonGia`, `SoLuong`, `NgayNhap`, `ConKinhDoanh`, `DuongDanAnh`) cùng các thuộc tính bổ trợ tính toán (`ThanhTien`, `TrangThaiText`).
- **`FrmProduct.cs` / `FrmProduct.Designer.cs`**: Form chính (`FrmProduct`), tiêu đề "Quản lý sản phẩm".
- **`Program.cs`**: Điểm khởi chạy ứng dụng (`Application.Run(new FrmProduct())`).

---

## 2. Quy trình Khóa/Mở khóa & Thao tác Giao diện

1. **Khóa thành phần ban đầu (ReadOnly / Disabled)**:
   - Khi ứng dụng mới mở hoặc sau khi nhấn **Làm mới**, toàn bộ các ô nhập liệu (`txtMaSP`, `txtTenSP`, `cboLoaiSP`, `numDonGia`, `numSoLuong`, `dtpNgayNhap`, `chkConKinhDoanh`, nút chọn ảnh và nút **Lưu**) đều bị **khóa** (`Enabled = false`).
   - Người dùng có thể click xem dữ liệu trên DataGridView nhưng không thể tự ý sửa đổi khi chưa chọn nút chức năng.
2. **Mở khóa khi ấn "Thêm" hoặc "Sửa"**:
   - Khi nhấn nút **Sửa** (hoặc double-click dòng): Dữ liệu sản phẩm được nạp lên form và **tất cả các thành phần (kể cả Mã SP) được mở khóa** để chỉnh sửa.
   - Khi nhấn nút **Thêm**: Xóa trắng thông tin trên form và **mở khóa** để nhập sản phẩm mới.
3. **Xác nhận & Khóa lại khi ấn "Lưu"**:
   - Khi nhấn nút **Lưu** (`btnLuu` / Ctrl+S): Hệ thống kiểm tra tính hợp lệ dữ liệu, ghi nhận các sửa đổi/thêm mới vào danh sách và tự động **khóa lại các ô nhập liệu**.
4. **Phông chữ nút "Lưu"**: Nút **Lưu** sử dụng kiểu chữ chuẩn Regular đồng bộ hoàn toàn với các nút Thêm, Sửa, Xóa, Làm mới.

---

## 3. Hướng dẫn biên dịch & Chạy ứng dụng

1. Mở terminal hoặc PowerShell tại thư mục dự án (`lab6`).
2. Chạy lệnh build:
   ```cmd
   dotnet build WindowsFormsApp2.csproj
   ```
3. Khởi chạy file ứng dụng đã biên dịch:
   ```cmd
   .\bin\Debug\ProductManager.exe
   ```
