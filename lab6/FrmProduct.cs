using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class FrmProduct : Form
    {
        private BindingList<Product> _products;
        private BindingSource _bindingSource;
        private string _currentImagePath = string.Empty;

        /// <summary>
        /// Stores the original MaSP of the product currently being edited.
        /// Null if not in edit mode.
        /// </summary>
        private string _originalMaSP = null;

        public FrmProduct()
        {
            InitializeComponent();
            _products = new BindingList<Product>();
            _bindingSource = new BindingSource();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            InitComboBoxData();
            InitSampleData();
            SetupDataGridView();
            ClearInput();
            SetInputControlsState(false); // Khóa các thành phần lúc ban đầu
            UpdateStatus("Sẵn sàng. Các ô nhập liệu đang được khóa.");
        }

        #region Initialization

        private void InitComboBoxData()
        {
            cboLoaiSP.Items.Clear();
            cboLoaiSP.Items.Add("Điện tử");
            cboLoaiSP.Items.Add("Văn phòng");
            cboLoaiSP.Items.Add("Gia dụng");
            cboLoaiSP.Items.Add("Thời trang");
        }

        private void InitSampleData()
        {
            _products.Add(new Product("SP01", "Laptop Dell XPS 13", "Điện tử", 28500000m, 10, DateTime.Now.AddDays(-10), true));
            _products.Add(new Product("SP02", "Bàn phím cơ Logitech", "Điện tử", 2200000m, 25, DateTime.Now.AddDays(-5), true));
            _products.Add(new Product("SP03", "Nồi cơm điện Cuckoo", "Gia dụng", 3500000m, 15, DateTime.Now.AddDays(-15), true));
            _products.Add(new Product("SP04", "Áo sơ mi Nam Premium", "Thời trang", 450000m, 50, DateTime.Now.AddDays(-2), true));
        }

        private void SetupDataGridView()
        {
            _bindingSource.DataSource = _products;
            dgvProducts.DataSource = _bindingSource;

            // Configure column formatting and headers
            if (dgvProducts.Columns["MaSP"] != null)
                dgvProducts.Columns["MaSP"].HeaderText = "Mã SP";

            if (dgvProducts.Columns["TenSP"] != null)
                dgvProducts.Columns["TenSP"].HeaderText = "Tên sản phẩm";

            if (dgvProducts.Columns["LoaiSP"] != null)
                dgvProducts.Columns["LoaiSP"].HeaderText = "Loại SP";

            if (dgvProducts.Columns["DonGia"] != null)
            {
                dgvProducts.Columns["DonGia"].HeaderText = "Đơn giá (VNĐ)";
                dgvProducts.Columns["DonGia"].DefaultCellStyle.Format = "N0";
                dgvProducts.Columns["DonGia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvProducts.Columns["SoLuong"] != null)
            {
                dgvProducts.Columns["SoLuong"].HeaderText = "Số lượng";
                dgvProducts.Columns["SoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvProducts.Columns["ThanhTien"] != null)
            {
                dgvProducts.Columns["ThanhTien"].HeaderText = "Thành tiền (VNĐ)";
                dgvProducts.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
                dgvProducts.Columns["ThanhTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvProducts.Columns["NgayNhap"] != null)
            {
                dgvProducts.Columns["NgayNhap"].HeaderText = "Ngày nhập";
                dgvProducts.Columns["NgayNhap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvProducts.Columns["NgayNhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvProducts.Columns["TrangThaiText"] != null)
            {
                dgvProducts.Columns["TrangThaiText"].HeaderText = "Trạng thái";
                dgvProducts.Columns["TrangThaiText"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Hide raw boolean & image path columns for cleaner display
            if (dgvProducts.Columns["ConKinhDoanh"] != null)
                dgvProducts.Columns["ConKinhDoanh"].Visible = false;

            if (dgvProducts.Columns["DuongDanAnh"] != null)
                dgvProducts.Columns["DuongDanAnh"].Visible = false;

            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.MultiSelect = false;
            dgvProducts.AllowUserToAddRows = false;
        }

        #endregion

        #region Helper Methods (Requirement 6)

        /// <summary>
        /// Khóa hoặc Mở khóa các ô nhập liệu và nút Lưu
        /// </summary>
        private void SetInputControlsState(bool enabled)
        {
            txtMaSP.Enabled = enabled;
            txtTenSP.Enabled = enabled;
            cboLoaiSP.Enabled = enabled;
            numDonGia.Enabled = enabled;
            numSoLuong.Enabled = enabled;
            dtpNgayNhap.Enabled = enabled;
            chkConKinhDoanh.Enabled = enabled;
            btnChonAnh.Enabled = enabled;
            btnBoAnh.Enabled = enabled;
            btnLuu.Enabled = enabled;
            tsbSave.Enabled = enabled;
            menuSave.Enabled = enabled;
        }

        private bool ValidateInput(bool isEditMode)
        {
            errorProvider1.Clear();
            bool isValid = true;

            // 1. Validate MaSP
            string maSP = txtMaSP.Text.Trim();
            if (string.IsNullOrWhiteSpace(maSP))
            {
                errorProvider1.SetError(txtMaSP, "Mã sản phẩm không được để trống!");
                isValid = false;
            }
            else
            {
                if (!isEditMode || string.IsNullOrEmpty(_originalMaSP))
                {
                    // Adding new product: check duplicate across all products
                    if (_products.Any(p => p.MaSP.Equals(maSP, StringComparison.OrdinalIgnoreCase)))
                    {
                        errorProvider1.SetError(txtMaSP, "Mã sản phẩm đã tồn tại trong hệ thống!");
                        isValid = false;
                    }
                }
                else
                {
                    // Editing existing product: if MaSP changed, check duplicate with OTHER products
                    if (!maSP.Equals(_originalMaSP, StringComparison.OrdinalIgnoreCase))
                    {
                        bool existsInOthers = _products.Any(p =>
                            !p.MaSP.Equals(_originalMaSP, StringComparison.OrdinalIgnoreCase) &&
                            p.MaSP.Equals(maSP, StringComparison.OrdinalIgnoreCase));

                        if (existsInOthers)
                        {
                            errorProvider1.SetError(txtMaSP, $"Mã sản phẩm '{maSP}' đã trùng với sản phẩm khác!");
                            isValid = false;
                        }
                    }
                }
            }

            // 2. Validate TenSP
            if (string.IsNullOrWhiteSpace(txtTenSP.Text.Trim()))
            {
                errorProvider1.SetError(txtTenSP, "Tên sản phẩm không được để trống!");
                isValid = false;
            }

            // 3. Validate LoaiSP
            if (cboLoaiSP.SelectedIndex == -1 && string.IsNullOrWhiteSpace(cboLoaiSP.Text))
            {
                errorProvider1.SetError(cboLoaiSP, "Vui lòng chọn loại sản phẩm!");
                isValid = false;
            }

            // 4. Validate DonGia
            if (numDonGia.Value <= 0)
            {
                errorProvider1.SetError(numDonGia, "Đơn giá phải lớn hơn 0!");
                isValid = false;
            }

            // 5. Validate SoLuong
            if (numSoLuong.Value < 0)
            {
                errorProvider1.SetError(numSoLuong, "Số lượng không được là số âm!");
                isValid = false;
            }

            // 6. Validate NgayNhap
            if (dtpNgayNhap.Value.Date > DateTime.Now.Date)
            {
                errorProvider1.SetError(dtpNgayNhap, "Ngày nhập không được lớn hơn ngày hiện tại!");
                isValid = false;
            }

            return isValid;
        }

        private void ClearInput()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            cboLoaiSP.SelectedIndex = -1;
            numDonGia.Value = 0;
            numSoLuong.Value = 0;
            dtpNgayNhap.Value = DateTime.Now;
            chkConKinhDoanh.Checked = true;
            
            if (picProduct.Image != null)
            {
                picProduct.Image.Dispose();
                picProduct.Image = null;
            }
            _currentImagePath = string.Empty;
            _originalMaSP = null; // Clear edit mode tracking

            errorProvider1.Clear();
            dgvProducts.ClearSelection();
            SetInputControlsState(false); // Khóa lại nhập liệu
        }

        private void LoadProductToForm(Product p)
        {
            if (p == null) return;

            errorProvider1.Clear();
            txtMaSP.Text = p.MaSP;
            txtTenSP.Text = p.TenSP;

            if (cboLoaiSP.Items.Contains(p.LoaiSP))
                cboLoaiSP.SelectedItem = p.LoaiSP;
            else
                cboLoaiSP.Text = p.LoaiSP;

            numDonGia.Value = Math.Min(numDonGia.Maximum, Math.Max(numDonGia.Minimum, p.DonGia));
            numSoLuong.Value = Math.Min(numSoLuong.Maximum, Math.Max(numSoLuong.Minimum, p.SoLuong));
            dtpNgayNhap.Value = p.NgayNhap <= dtpNgayNhap.MaxDate ? p.NgayNhap : DateTime.Now;
            chkConKinhDoanh.Checked = p.ConKinhDoanh;

            _currentImagePath = p.DuongDanAnh;
            DisplayProductImage(_currentImagePath);
        }

        private void DisplayProductImage(string imagePath)
        {
            if (picProduct.Image != null)
            {
                picProduct.Image.Dispose();
                picProduct.Image = null;
            }

            if (!string.IsNullOrWhiteSpace(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        picProduct.Image = Image.FromStream(stream);
                    }
                }
                catch
                {
                    picProduct.Image = null;
                }
            }
        }

        private void UpdateStatus(string message = "Sẵn sàng")
        {
            lblStatus.Text = message;
            int count = _products.Count;
            decimal totalVal = _products.Sum(p => p.DonGia * p.SoLuong);

            lblCount.Text = $"Số lượng SP: {count}";
            lblTotalValue.Text = $"Tổng tồn kho: {totalVal:N0} VNĐ";
        }

        private Product GetSelectedProduct()
        {
            if (dgvProducts.CurrentRow != null && dgvProducts.CurrentRow.DataBoundItem is Product p)
            {
                return p;
            }
            return null;
        }

        #endregion

        #region CRUD Actions & Save Button

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearInput();
            SetInputControlsState(true); // Mở khóa cho phép nhập sản phẩm mới
            txtMaSP.Focus();
            UpdateStatus("Đã mở khóa các ô nhập liệu. Vui lòng nhập thông tin sản phẩm mới và nhấn 'Lưu'.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Product selectedProd = GetSelectedProduct();
            if (selectedProd == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm từ danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đưa dữ liệu lên Form và MỞ KHÓA cho phép chỉnh sửa
            LoadProductToForm(selectedProd);
            _originalMaSP = selectedProd.MaSP;

            SetInputControlsState(true); // Mở khóa các thành phần sản phẩm (Mã, Tên, Giá...)
            txtMaSP.Focus();
            txtMaSP.SelectAll();

            UpdateStatus($"Đã mở khóa. Bạn đang chỉnh sửa sản phẩm [{_originalMaSP}]. Hãy thay đổi thông tin và nhấn 'Lưu'.");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!btnLuu.Enabled)
            {
                MessageBox.Show("Vui lòng nhấn 'Thêm' hoặc 'Sửa' trước khi Lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool isEditMode = !string.IsNullOrEmpty(_originalMaSP);

            if (!ValidateInput(isEditMode))
            {
                MessageBox.Show("Dữ liệu chưa hợp lệ! Vui lòng kiểm tra lại các trường bị báo lỗi.",
                    "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newMaSP = txtMaSP.Text.Trim();

            if (isEditMode)
            {
                // Tìm sản phẩm ban đầu theo _originalMaSP để cập nhật
                Product target = _products.FirstOrDefault(p => p.MaSP.Equals(_originalMaSP, StringComparison.OrdinalIgnoreCase));
                if (target != null)
                {
                    target.MaSP = newMaSP; // Cập nhật Mã SP
                    target.TenSP = txtTenSP.Text.Trim();
                    target.LoaiSP = cboLoaiSP.Text.Trim();
                    target.DonGia = numDonGia.Value;
                    target.SoLuong = (int)numSoLuong.Value;
                    target.NgayNhap = dtpNgayNhap.Value;
                    target.ConKinhDoanh = chkConKinhDoanh.Checked;
                    target.DuongDanAnh = _currentImagePath;

                    _bindingSource.ResetBindings(false);
                    ClearInput();
                    SetInputControlsState(false); // Khóa lại các ô nhập liệu sau khi Lưu xong

                    UpdateStatus($"Đã xác nhận và lưu chỉnh sửa sản phẩm [{newMaSP}] thành công!");
                    MessageBox.Show($"Xác nhận lưu thay đổi cho sản phẩm \"{target.TenSP}\" (Mã SP: {newMaSP}) thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Thêm sản phẩm mới
                Product newProd = new Product
                {
                    MaSP = newMaSP,
                    TenSP = txtTenSP.Text.Trim(),
                    LoaiSP = cboLoaiSP.Text.Trim(),
                    DonGia = numDonGia.Value,
                    SoLuong = (int)numSoLuong.Value,
                    NgayNhap = dtpNgayNhap.Value,
                    ConKinhDoanh = chkConKinhDoanh.Checked,
                    DuongDanAnh = _currentImagePath
                };

                _products.Add(newProd);
                ClearInput();
                SetInputControlsState(false); // Khóa lại các ô nhập liệu sau khi Lưu xong

                UpdateStatus($"Đã xác nhận và lưu sản phẩm mới [{newProd.MaSP}] thành công!");
                MessageBox.Show($"Thêm mới và lưu sản phẩm \"{newProd.TenSP}\" (Mã SP: {newProd.MaSP}) thành công!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Product selectedProd = GetSelectedProduct();
            if (selectedProd == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dlgResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sản phẩm \"{selectedProd.TenSP}\" (Mã: {selectedProd.MaSP}) không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dlgResult == DialogResult.Yes)
            {
                string deletedMa = selectedProd.MaSP;
                _products.Remove(selectedProd);
                ClearInput();
                SetInputControlsState(false);
                UpdateStatus($"Đã xóa sản phẩm [{deletedMa}] thành công!");
                MessageBox.Show($"Xóa sản phẩm [{deletedMa}] thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInput();
            SetInputControlsState(false); // Khóa các ô nhập
            tstxtSearch.Clear();
            _bindingSource.DataSource = _products;
            UpdateStatus("Đã làm mới form và khóa các ô nhập liệu.");
        }

        #endregion

        #region Image Handling

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Chọn ảnh sản phẩm";
            openFileDialog1.Filter = "File ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tất cả các file (*.*)|*.*";
            openFileDialog1.FileName = string.Empty;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _currentImagePath = openFileDialog1.FileName;
                DisplayProductImage(_currentImagePath);
            }
        }

        private void btnBoAnh_Click(object sender, EventArgs e)
        {
            if (picProduct.Image != null)
            {
                picProduct.Image.Dispose();
                picProduct.Image = null;
            }
            _currentImagePath = string.Empty;
        }

        #endregion

        #region DataGridView Events

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Product p = GetSelectedProduct();
                if (p != null)
                {
                    LoadProductToForm(p);
                    // Nếu chưa nhấn "Sửa" hoặc "Thêm", vẫn giữ các ô nhập khóa lại
                    if (string.IsNullOrEmpty(_originalMaSP) || _originalMaSP != p.MaSP)
                    {
                        SetInputControlsState(false);
                    }
                }
            }
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Product p = GetSelectedProduct();
                if (p != null)
                {
                    LoadProductToForm(p);
                    ShowProductDetails(p);
                }
            }
        }

        private void dgvProducts_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgvProducts.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dgvProducts.ClearSelection();
                    dgvProducts.Rows[hit.RowIndex].Selected = true;
                    dgvProducts.CurrentCell = dgvProducts.Rows[hit.RowIndex].Cells[Math.Max(0, hit.ColumnIndex)];

                    Product p = GetSelectedProduct();
                    if (p != null)
                    {
                        LoadProductToForm(p);
                        if (string.IsNullOrEmpty(_originalMaSP) || _originalMaSP != p.MaSP)
                        {
                            SetInputControlsState(false);
                        }
                    }
                }
            }
        }

        private void tsmiContextDetails_Click(object sender, EventArgs e)
        {
            Product p = GetSelectedProduct();
            if (p != null)
            {
                ShowProductDetails(p);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowProductDetails(Product p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"--- CHI TIẾT SẢN PHẨM ---");
            sb.AppendLine($"Mã sản phẩm: {p.MaSP}");
            sb.AppendLine($"Tên sản phẩm: {p.TenSP}");
            sb.AppendLine($"Loại sản phẩm: {p.LoaiSP}");
            sb.AppendLine($"Đơn giá: {p.DonGia:N0} VNĐ");
            sb.AppendLine($"Số lượng: {p.SoLuong}");
            sb.AppendLine($"Thành tiền: {p.ThanhTien:N0} VNĐ");
            sb.AppendLine($"Ngày nhập: {p.NgayNhap:dd/MM/yyyy}");
            sb.AppendLine($"Trạng thái: {(p.ConKinhDoanh ? "Còn kinh doanh" : "Ngừng kinh doanh")}");
            sb.AppendLine($"Đường dẫn ảnh: {(string.IsNullOrEmpty(p.DuongDanAnh) ? "(Chưa có ảnh)" : p.DuongDanAnh)}");

            MessageBox.Show(sb.ToString(), $"Chi tiết sản phẩm - {p.MaSP}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Search & Sorting

        private void PerformSearch()
        {
            string keyword = tstxtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                _bindingSource.DataSource = _products;
                UpdateStatus($"Hiển thị toàn bộ {_products.Count} sản phẩm.");
            }
            else
            {
                var filtered = _products.Where(p =>
                    p.MaSP.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.TenSP.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    p.LoaiSP.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0
                ).ToList();

                _bindingSource.DataSource = new BindingList<Product>(filtered);
                UpdateStatus($"Tìm thấy {filtered.Count} sản phẩm phù hợp từ khóa \"{keyword}\".");
            }
        }

        private void tsbSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void tstxtSearch_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void menuSortByPrice_Click(object sender, EventArgs e)
        {
            var sorted = _products.OrderBy(p => p.DonGia).ToList();
            _products.Clear();
            foreach (var p in sorted)
            {
                _products.Add(p);
            }
            _bindingSource.ResetBindings(false);
            UpdateStatus("Đã sắp xếp danh sách sản phẩm theo Đơn giá (Tăng dần).");
        }

        private void menuSortByQuantity_Click(object sender, EventArgs e)
        {
            var sorted = _products.OrderByDescending(p => p.SoLuong).ToList();
            _products.Clear();
            foreach (var p in sorted)
            {
                _products.Add(p);
            }
            _bindingSource.ResetBindings(false);
            UpdateStatus("Đã sắp xếp danh sách sản phẩm theo Số lượng (Giảm dần).");
        }

        #endregion

        #region File Export & Application Events

        private void menuExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Xuất danh sách sản phẩm";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            saveFileDialog1.FileName = $"DanhSachSanPham_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("==========================================================================================");
                    sb.AppendLine("                             DANH SÁCH QUẢN LÝ SẢN PHẨM");
                    sb.AppendLine($"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                    sb.AppendLine("==========================================================================================");
                    sb.AppendLine(string.Format("{0,-8} | {1,-30} | {2,-15} | {3,12} | {4,8} | {5,15}",
                        "Mã SP", "Tên sản phẩm", "Loại SP", "Đơn giá", "Số lượng", "Thành tiền"));
                    sb.AppendLine("------------------------------------------------------------------------------------------");

                    foreach (var p in _products)
                    {
                        sb.AppendLine(string.Format("{0,-8} | {1,-30} | {2,-15} | {3,12:N0} | {4,8} | {5,15:N0}",
                            p.MaSP, p.TenSP, p.LoaiSP, p.DonGia, p.SoLuong, p.ThanhTien));
                    }

                    sb.AppendLine("==========================================================================================");
                    sb.AppendLine($"Tổng số sản phẩm: {_products.Count}");
                    sb.AppendLine($"Tổng giá trị tồn kho: {_products.Sum(p => p.ThanhTien):N0} VNĐ");

                    File.WriteAllText(saveFileDialog1.FileName, sb.ToString(), Encoding.UTF8);
                    UpdateStatus($"Đã xuất danh sách ra file thành công: {Path.GetFileName(saveFileDialog1.FileName)}");
                    MessageBox.Show("Xuất file danh sách sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Ứng dụng Quản lý Sản phẩm (ProductManager)\n" +
                "Môn học: COMP1019 - Lập trình trên Windows\n" +
                "Bài thực hành: LAB 06 - Windows Forms Nâng cao và DataGridView\n\n" +
                "Các tính năng:\n" +
                "- Khóa các ô nhập liệu ban đầu, chỉ mở khi bấm 'Thêm' hoặc 'Sửa'\n" +
                "- Xác nhận và khóa lại ô nhập khi bấm nút 'Lưu'\n" +
                "- Thêm, sửa (cho phép chỉnh sửa Mã SP), lưu, xóa, tìm kiếm và làm mới dữ liệu sản phẩm\n" +
                "- Kiểm tra dữ liệu nhập bằng ErrorProvider\n" +
                "- Tích hợp MenuStrip, ToolStrip, StatusStrip, ContextMenuStrip\n" +
                "- Quản lý hình ảnh sản phẩm với OpenFileDialog\n" +
                "- Thống kê tồn kho & Xuất danh sách sản phẩm ra file .txt",
                "Giới thiệu ProductManager",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
