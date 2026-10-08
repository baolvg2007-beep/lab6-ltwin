namespace ProductManager
{
    partial class FrmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSortByPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSortByQuantity = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tslblSearch = new System.Windows.Forms.ToolStripLabel();
            this.tstxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbProductInfo = new System.Windows.Forms.GroupBox();
            this.btnBoAnh = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.chkConKinhDoanh = new System.Windows.Forms.CheckBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.gbProductList = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiContextEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContextDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContextDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            this.gbProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuManage,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExport,
            this.toolStripSeparator1,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(49, 27);
            this.menuFile.Text = "&File";
            // 
            // menuExport
            // 
            this.menuExport.Name = "menuExport";
            this.menuExport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuExport.Size = new System.Drawing.Size(255, 28);
            this.menuExport.Text = "Xuất file .txt...";
            this.menuExport.Click += new System.EventHandler(this.menuExport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(252, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuExit.Size = new System.Drawing.Size(255, 28);
            this.menuExit.Text = "Thoát";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuManage
            // 
            this.menuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuEdit,
            this.menuSave,
            this.menuDelete,
            this.menuRefresh,
            this.toolStripSeparator2,
            this.menuSortByPrice,
            this.menuSortByQuantity});
            this.menuManage.Name = "menuManage";
            this.menuManage.Size = new System.Drawing.Size(83, 27);
            this.menuManage.Text = "&Quản lý";
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuAdd.Size = new System.Drawing.Size(279, 28);
            this.menuAdd.Text = "Thêm sản phẩm";
            this.menuAdd.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.menuEdit.Size = new System.Drawing.Size(279, 28);
            this.menuEdit.Text = "Sửa sản phẩm";
            this.menuEdit.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSave.Size = new System.Drawing.Size(279, 28);
            this.menuSave.Text = "Lưu sản phẩm";
            this.menuSave.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuDelete.Size = new System.Drawing.Size(279, 28);
            this.menuDelete.Text = "Xóa sản phẩm";
            this.menuDelete.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuRefresh.Size = new System.Drawing.Size(279, 28);
            this.menuRefresh.Text = "Làm mới";
            this.menuRefresh.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(276, 6);
            // 
            // menuSortByPrice
            // 
            this.menuSortByPrice.Name = "menuSortByPrice";
            this.menuSortByPrice.Size = new System.Drawing.Size(279, 28);
            this.menuSortByPrice.Text = "Sắp xếp theo Đơn giá";
            this.menuSortByPrice.Click += new System.EventHandler(this.menuSortByPrice_Click);
            // 
            // menuSortByQuantity
            // 
            this.menuSortByQuantity.Name = "menuSortByQuantity";
            this.menuSortByQuantity.Size = new System.Drawing.Size(279, 28);
            this.menuSortByQuantity.Text = "Sắp xếp theo Số lượng";
            this.menuSortByQuantity.Click += new System.EventHandler(this.menuSortByQuantity_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(87, 27);
            this.menuHelp.Text = "&Trợ giúp";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuAbout.Size = new System.Drawing.Size(195, 28);
            this.menuAbout.Text = "Giới thiệu";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbSave,
            this.tsbDelete,
            this.tsbRefresh,
            this.toolStripSeparator3,
            this.tslblSearch,
            this.tstxtSearch,
            this.tsbSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 30);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(57, 27);
            this.tsbAdd.Text = "Thêm";
            this.tsbAdd.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(42, 27);
            this.tsbEdit.Text = "Sửa";
            this.tsbEdit.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(42, 27);
            this.tsbSave.Text = "Lưu";
            this.tsbSave.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(43, 27);
            this.tsbDelete.Text = "Xóa";
            this.tsbDelete.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(80, 27);
            this.tsbRefresh.Text = "Làm mới";
            this.tsbRefresh.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // tslblSearch
            // 
            this.tslblSearch.Name = "tslblSearch";
            this.tslblSearch.Size = new System.Drawing.Size(83, 27);
            this.tslblSearch.Text = "Tìm kiếm:";
            // 
            // tstxtSearch
            // 
            this.tstxtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstxtSearch.Name = "tstxtSearch";
            this.tstxtSearch.Size = new System.Drawing.Size(180, 30);
            this.tstxtSearch.ToolTipText = "Nhập mã hoặc tên sản phẩm để tìm kiếm";
            this.tstxtSearch.TextChanged += new System.EventHandler(this.tstxtSearch_TextChanged);
            // 
            // tsbSearch
            // 
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(42, 27);
            this.tsbSearch.Text = "Tìm";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblCount,
            this.lblTotalValue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 33);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(613, 27);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "Sẵn sàng";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCount
            // 
            this.lblCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(180, 27);
            this.lblCount.Text = "Số lượng sản phẩm: 0";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblTotalValue.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(176, 27);
            this.lblTotalValue.Text = "Tổng tồn kho: 0 VNĐ";
            // 
            // gbProductInfo
            // 
            this.gbProductInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProductInfo.Controls.Add(this.btnBoAnh);
            this.gbProductInfo.Controls.Add(this.btnChonAnh);
            this.gbProductInfo.Controls.Add(this.picProduct);
            this.gbProductInfo.Controls.Add(this.btnLamMoi);
            this.gbProductInfo.Controls.Add(this.btnXoa);
            this.gbProductInfo.Controls.Add(this.btnLuu);
            this.gbProductInfo.Controls.Add(this.btnSua);
            this.gbProductInfo.Controls.Add(this.btnThem);
            this.gbProductInfo.Controls.Add(this.chkConKinhDoanh);
            this.gbProductInfo.Controls.Add(this.dtpNgayNhap);
            this.gbProductInfo.Controls.Add(this.numSoLuong);
            this.gbProductInfo.Controls.Add(this.numDonGia);
            this.gbProductInfo.Controls.Add(this.cboLoaiSP);
            this.gbProductInfo.Controls.Add(this.txtTenSP);
            this.gbProductInfo.Controls.Add(this.txtMaSP);
            this.gbProductInfo.Controls.Add(this.lblSoLuong);
            this.gbProductInfo.Controls.Add(this.lblDonGia);
            this.gbProductInfo.Controls.Add(this.lblNgayNhap);
            this.gbProductInfo.Controls.Add(this.lblLoaiSP);
            this.gbProductInfo.Controls.Add(this.lblTenSP);
            this.gbProductInfo.Controls.Add(this.lblMaSP);
            this.gbProductInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductInfo.Location = new System.Drawing.Point(12, 53);
            this.gbProductInfo.Name = "gbProductInfo";
            this.gbProductInfo.Size = new System.Drawing.Size(960, 235);
            this.gbProductInfo.TabIndex = 3;
            this.gbProductInfo.TabStop = false;
            this.gbProductInfo.Text = "Thông tin sản phẩm";
            // 
            // btnBoAnh
            // 
            this.btnBoAnh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoAnh.Location = new System.Drawing.Point(860, 180);
            this.btnBoAnh.Name = "btnBoAnh";
            this.btnBoAnh.Size = new System.Drawing.Size(75, 28);
            this.btnBoAnh.TabIndex = 17;
            this.btnBoAnh.Text = "Bỏ ảnh";
            this.btnBoAnh.UseVisualStyleBackColor = true;
            this.btnBoAnh.Click += new System.EventHandler(this.btnBoAnh_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonAnh.Location = new System.Drawing.Point(775, 180);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(79, 28);
            this.btnChonAnh.TabIndex = 16;
            this.btnChonAnh.Text = "Chọn ảnh...";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // picProduct
            // 
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Location = new System.Drawing.Point(775, 28);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(160, 145);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 15;
            this.picProduct.TabStop = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(445, 178);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 32);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(340, 178);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 32);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(235, 178);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 32);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(130, 178);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 32);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(25, 178);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 32);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // chkConKinhDoanh
            // 
            this.chkConKinhDoanh.AutoSize = true;
            this.chkConKinhDoanh.Checked = true;
            this.chkConKinhDoanh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConKinhDoanh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConKinhDoanh.Location = new System.Drawing.Point(510, 115);
            this.chkConKinhDoanh.Name = "chkConKinhDoanh";
            this.chkConKinhDoanh.Size = new System.Drawing.Size(154, 27);
            this.chkConKinhDoanh.TabIndex = 10;
            this.chkConKinhDoanh.Text = "Còn kinh doanh";
            this.chkConKinhDoanh.UseVisualStyleBackColor = true;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(125, 130);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(220, 29);
            this.dtpNgayNhap.TabIndex = 7;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLuong.Location = new System.Drawing.Point(510, 70);
            this.numSoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(220, 29);
            this.numSoLuong.TabIndex = 9;
            // 
            // numDonGia
            // 
            this.numDonGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDonGia.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDonGia.Location = new System.Drawing.Point(510, 28);
            this.numDonGia.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(220, 29);
            this.numDonGia.TabIndex = 8;
            this.numDonGia.ThousandsSeparator = true;
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(125, 95);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(220, 29);
            this.cboLoaiSP.TabIndex = 6;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(125, 60);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(220, 29);
            this.txtTenSP.TabIndex = 5;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(125, 25);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(220, 29);
            this.txtMaSP.TabIndex = 4;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(400, 72);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(82, 23);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(400, 30);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(74, 23);
            this.lblDonGia.TabIndex = 4;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhap.Location = new System.Drawing.Point(20, 134);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(98, 23);
            this.lblNgayNhap.TabIndex = 3;
            this.lblNgayNhap.Text = "Ngày nhập:";
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiSP.Location = new System.Drawing.Point(20, 98);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(125, 23);
            this.lblLoaiSP.TabIndex = 2;
            this.lblLoaiSP.Text = "Loại sản phẩm:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(20, 63);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(120, 23);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên sản phẩm:";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.Location = new System.Drawing.Point(20, 28);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(118, 23);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã sản phẩm:";
            // 
            // gbProductList
            // 
            this.gbProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProductList.Controls.Add(this.dgvProducts);
            this.gbProductList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductList.Location = new System.Drawing.Point(12, 294);
            this.gbProductList.Name = "gbProductList";
            this.gbProductList.Size = new System.Drawing.Size(960, 335);
            this.gbProductList.TabIndex = 4;
            this.gbProductList.TabStop = false;
            this.gbProductList.Text = "Danh sách sản phẩm";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.Location = new System.Drawing.Point(3, 25);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(954, 307);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            this.dgvProducts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvProducts_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiContextEdit,
            this.tsmiContextDelete,
            this.tsmiContextDetails});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 88);
            // 
            // tsmiContextEdit
            // 
            this.tsmiContextEdit.Name = "tsmiContextEdit";
            this.tsmiContextEdit.Size = new System.Drawing.Size(171, 28);
            this.tsmiContextEdit.Text = "Sửa";
            this.tsmiContextEdit.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // tsmiContextDelete
            // 
            this.tsmiContextDelete.Name = "tsmiContextDelete";
            this.tsmiContextDelete.Size = new System.Drawing.Size(171, 28);
            this.tsmiContextDelete.Text = "Xóa";
            this.tsmiContextDelete.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tsmiContextDetails
            // 
            this.tsmiContextDetails.Name = "tsmiContextDetails";
            this.tsmiContextDetails.Size = new System.Drawing.Size(171, 28);
            this.tsmiContextDetails.Text = "Xem chi tiết";
            this.tsmiContextDetails.Click += new System.EventHandler(this.tsmiContextDetails_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.gbProductList);
            this.Controls.Add(this.gbProductInfo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbProductInfo.ResumeLayout(false);
            this.gbProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            this.gbProductList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuManage;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripMenuItem menuRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuSortByPrice;
        private System.Windows.Forms.ToolStripMenuItem menuSortByQuantity;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tslblSearch;
        private System.Windows.Forms.ToolStripTextBox tstxtSearch;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblCount;
        private System.Windows.Forms.ToolStripStatusLabel lblTotalValue;
        private System.Windows.Forms.GroupBox gbProductInfo;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.CheckBox chkConKinhDoanh;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnBoAnh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox gbProductList;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiContextEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiContextDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiContextDetails;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
