namespace G221LBTSalaryPL
{
    partial class Fr03XLRBTVNSPL
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
            this.gbBL = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dGVBL = new System.Windows.Forms.DataGridView();
            this.maBLDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNSPLDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKLDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongHSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuBLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bangLuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g221LBTSalasryPLBL = new G221LBTSalaryPL.G221LBTSalasryPLBL();
            this.btnHuyAllBL = new System.Windows.Forms.Button();
            this.btnHuyBL = new System.Windows.Forms.Button();
            this.gbBCC = new System.Windows.Forms.GroupBox();
            this.btnbackBCC = new System.Windows.Forms.Button();
            this.btnHuyAllBCC = new System.Windows.Forms.Button();
            this.btnHuyBCC = new System.Windows.Forms.Button();
            this.dGVBCC = new System.Windows.Forms.DataGridView();
            this.maNSPLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGLVChuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGLamViecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuBCCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maBLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bangChamCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g221LBTSasaryPLBCC = new G221LBTSalaryPL.G221LBTSasaryPLBCC();
            this.btnDongRBTV = new System.Windows.Forms.Button();
            this.btnThoatCT = new System.Windows.Forms.Button();
            this.lbtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bangChamCongTableAdapter = new G221LBTSalaryPL.G221LBTSasaryPLBCCTableAdapters.BangChamCongTableAdapter();
            this.bangLuongTableAdapter = new G221LBTSalaryPL.G221LBTSalasryPLBLTableAdapters.BangLuongTableAdapter();
            this.gbBL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g221LBTSalasryPLBL)).BeginInit();
            this.gbBCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangChamCongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g221LBTSasaryPLBCC)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBL
            // 
            this.gbBL.Controls.Add(this.button3);
            this.gbBL.Controls.Add(this.dGVBL);
            this.gbBL.Controls.Add(this.btnHuyAllBL);
            this.gbBL.Controls.Add(this.btnHuyBL);
            this.gbBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBL.Location = new System.Drawing.Point(5, 265);
            this.gbBL.Name = "gbBL";
            this.gbBL.Size = new System.Drawing.Size(1133, 200);
            this.gbBL.TabIndex = 14;
            this.gbBL.TabStop = false;
            this.gbBL.Text = "CẦN XỬ LÝ BẢNG CHẤM CÔNG CỦA NHÂN SỰ: MÃ:......TÊN:..... ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(877, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Quay lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dGVBL
            // 
            this.dGVBL.AutoGenerateColumns = false;
            this.dGVBL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maBLDataGridViewTextBoxColumn1,
            this.maNSPLDataGridViewTextBoxColumn1,
            this.maKLDataGridViewTextBoxColumn1,
            this.mucLuongDataGridViewTextBoxColumn,
            this.tongHSDataGridViewTextBoxColumn,
            this.ghiChuBLDataGridViewTextBoxColumn});
            this.dGVBL.DataSource = this.bangLuongBindingSource;
            this.dGVBL.Location = new System.Drawing.Point(20, 21);
            this.dGVBL.Name = "dGVBL";
            this.dGVBL.RowHeadersWidth = 51;
            this.dGVBL.RowTemplate.Height = 24;
            this.dGVBL.Size = new System.Drawing.Size(851, 171);
            this.dGVBL.TabIndex = 5;
            // 
            // maBLDataGridViewTextBoxColumn1
            // 
            this.maBLDataGridViewTextBoxColumn1.DataPropertyName = "MaBL";
            this.maBLDataGridViewTextBoxColumn1.HeaderText = "Mã BL";
            this.maBLDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.maBLDataGridViewTextBoxColumn1.Name = "maBLDataGridViewTextBoxColumn1";
            this.maBLDataGridViewTextBoxColumn1.Width = 125;
            // 
            // maNSPLDataGridViewTextBoxColumn1
            // 
            this.maNSPLDataGridViewTextBoxColumn1.DataPropertyName = "MaNSPL";
            this.maNSPLDataGridViewTextBoxColumn1.HeaderText = "Mã NS";
            this.maNSPLDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.maNSPLDataGridViewTextBoxColumn1.Name = "maNSPLDataGridViewTextBoxColumn1";
            this.maNSPLDataGridViewTextBoxColumn1.Width = 125;
            // 
            // maKLDataGridViewTextBoxColumn1
            // 
            this.maKLDataGridViewTextBoxColumn1.DataPropertyName = "MaKL";
            this.maKLDataGridViewTextBoxColumn1.HeaderText = "Mã KL";
            this.maKLDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.maKLDataGridViewTextBoxColumn1.Name = "maKLDataGridViewTextBoxColumn1";
            this.maKLDataGridViewTextBoxColumn1.Width = 125;
            // 
            // mucLuongDataGridViewTextBoxColumn
            // 
            this.mucLuongDataGridViewTextBoxColumn.DataPropertyName = "MucLuong";
            this.mucLuongDataGridViewTextBoxColumn.HeaderText = "Mức lương";
            this.mucLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mucLuongDataGridViewTextBoxColumn.Name = "mucLuongDataGridViewTextBoxColumn";
            this.mucLuongDataGridViewTextBoxColumn.Width = 125;
            // 
            // tongHSDataGridViewTextBoxColumn
            // 
            this.tongHSDataGridViewTextBoxColumn.DataPropertyName = "TongHS";
            this.tongHSDataGridViewTextBoxColumn.HeaderText = "Tổng HS";
            this.tongHSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tongHSDataGridViewTextBoxColumn.Name = "tongHSDataGridViewTextBoxColumn";
            this.tongHSDataGridViewTextBoxColumn.Width = 125;
            // 
            // ghiChuBLDataGridViewTextBoxColumn
            // 
            this.ghiChuBLDataGridViewTextBoxColumn.DataPropertyName = "GhiChuBL";
            this.ghiChuBLDataGridViewTextBoxColumn.HeaderText = "Ghi chú";
            this.ghiChuBLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiChuBLDataGridViewTextBoxColumn.Name = "ghiChuBLDataGridViewTextBoxColumn";
            this.ghiChuBLDataGridViewTextBoxColumn.Width = 125;
            // 
            // bangLuongBindingSource
            // 
            this.bangLuongBindingSource.DataMember = "BangLuong";
            this.bangLuongBindingSource.DataSource = this.g221LBTSalasryPLBL;
            // 
            // g221LBTSalasryPLBL
            // 
            this.g221LBTSalasryPLBL.DataSetName = "G221LBTSalasryPLBL";
            this.g221LBTSalasryPLBL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHuyAllBL
            // 
            this.btnHuyAllBL.Location = new System.Drawing.Point(877, 96);
            this.btnHuyAllBL.Name = "btnHuyAllBL";
            this.btnHuyAllBL.Size = new System.Drawing.Size(234, 37);
            this.btnHuyAllBL.TabIndex = 7;
            this.btnHuyAllBL.Text = "Hủy tất cả lương";
            this.btnHuyAllBL.UseVisualStyleBackColor = true;
            this.btnHuyAllBL.Click += new System.EventHandler(this.btnHuyAllBL_Click);
            // 
            // btnHuyBL
            // 
            this.btnHuyBL.Location = new System.Drawing.Point(877, 38);
            this.btnHuyBL.Name = "btnHuyBL";
            this.btnHuyBL.Size = new System.Drawing.Size(234, 37);
            this.btnHuyBL.TabIndex = 6;
            this.btnHuyBL.Text = "Hủy Bảng Lương";
            this.btnHuyBL.UseVisualStyleBackColor = true;
            this.btnHuyBL.Click += new System.EventHandler(this.btnHuyBL_Click);
            // 
            // gbBCC
            // 
            this.gbBCC.Controls.Add(this.btnbackBCC);
            this.gbBCC.Controls.Add(this.btnHuyAllBCC);
            this.gbBCC.Controls.Add(this.btnHuyBCC);
            this.gbBCC.Controls.Add(this.dGVBCC);
            this.gbBCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBCC.Location = new System.Drawing.Point(5, 48);
            this.gbBCC.Name = "gbBCC";
            this.gbBCC.Size = new System.Drawing.Size(1133, 211);
            this.gbBCC.TabIndex = 17;
            this.gbBCC.TabStop = false;
            this.gbBCC.Text = "CẦN XỬ LÝ BẢNG CHẤM CÔNG CỦA NHÂN SỰ: MÃ:......TÊN:.....";
            // 
            // btnbackBCC
            // 
            this.btnbackBCC.Location = new System.Drawing.Point(883, 159);
            this.btnbackBCC.Name = "btnbackBCC";
            this.btnbackBCC.Size = new System.Drawing.Size(234, 37);
            this.btnbackBCC.TabIndex = 4;
            this.btnbackBCC.Text = "Quay lại";
            this.btnbackBCC.UseVisualStyleBackColor = true;
            this.btnbackBCC.Click += new System.EventHandler(this.btnbackBCC_Click);
            // 
            // btnHuyAllBCC
            // 
            this.btnHuyAllBCC.Location = new System.Drawing.Point(883, 105);
            this.btnHuyAllBCC.Name = "btnHuyAllBCC";
            this.btnHuyAllBCC.Size = new System.Drawing.Size(234, 37);
            this.btnHuyAllBCC.TabIndex = 2;
            this.btnHuyAllBCC.Text = "Hủy tất cả chấm công";
            this.btnHuyAllBCC.UseVisualStyleBackColor = true;
            this.btnHuyAllBCC.Click += new System.EventHandler(this.btnHuyAllBCC_Click);
            // 
            // btnHuyBCC
            // 
            this.btnHuyBCC.Location = new System.Drawing.Point(883, 49);
            this.btnHuyBCC.Name = "btnHuyBCC";
            this.btnHuyBCC.Size = new System.Drawing.Size(234, 37);
            this.btnHuyBCC.TabIndex = 2;
            this.btnHuyBCC.Text = "Hủy 1 Bảng chấm công";
            this.btnHuyBCC.UseVisualStyleBackColor = true;
            this.btnHuyBCC.Click += new System.EventHandler(this.btnHuyBCC_Click);
            // 
            // dGVBCC
            // 
            this.dGVBCC.AutoGenerateColumns = false;
            this.dGVBCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNSPLDataGridViewTextBoxColumn,
            this.maKLDataGridViewTextBoxColumn,
            this.tGLVChuanDataGridViewTextBoxColumn,
            this.tGLamViecDataGridViewTextBoxColumn,
            this.ghiChuBCCDataGridViewTextBoxColumn,
            this.maBLDataGridViewTextBoxColumn});
            this.dGVBCC.DataSource = this.bangChamCongBindingSource;
            this.dGVBCC.Location = new System.Drawing.Point(26, 32);
            this.dGVBCC.Name = "dGVBCC";
            this.dGVBCC.RowHeadersWidth = 51;
            this.dGVBCC.RowTemplate.Height = 24;
            this.dGVBCC.Size = new System.Drawing.Size(851, 171);
            this.dGVBCC.TabIndex = 1;
            // 
            // maNSPLDataGridViewTextBoxColumn
            // 
            this.maNSPLDataGridViewTextBoxColumn.DataPropertyName = "MaNSPL";
            this.maNSPLDataGridViewTextBoxColumn.HeaderText = "Mã NS";
            this.maNSPLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNSPLDataGridViewTextBoxColumn.Name = "maNSPLDataGridViewTextBoxColumn";
            this.maNSPLDataGridViewTextBoxColumn.Width = 125;
            // 
            // maKLDataGridViewTextBoxColumn
            // 
            this.maKLDataGridViewTextBoxColumn.DataPropertyName = "MaKL";
            this.maKLDataGridViewTextBoxColumn.HeaderText = "Mã KL";
            this.maKLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKLDataGridViewTextBoxColumn.Name = "maKLDataGridViewTextBoxColumn";
            this.maKLDataGridViewTextBoxColumn.Width = 125;
            // 
            // tGLVChuanDataGridViewTextBoxColumn
            // 
            this.tGLVChuanDataGridViewTextBoxColumn.DataPropertyName = "TGLVChuan";
            this.tGLVChuanDataGridViewTextBoxColumn.HeaderText = "TGLV Chuẩn";
            this.tGLVChuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tGLVChuanDataGridViewTextBoxColumn.Name = "tGLVChuanDataGridViewTextBoxColumn";
            this.tGLVChuanDataGridViewTextBoxColumn.Width = 125;
            // 
            // tGLamViecDataGridViewTextBoxColumn
            // 
            this.tGLamViecDataGridViewTextBoxColumn.DataPropertyName = "TGLamViec";
            this.tGLamViecDataGridViewTextBoxColumn.HeaderText = "TG Làm Việc";
            this.tGLamViecDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tGLamViecDataGridViewTextBoxColumn.Name = "tGLamViecDataGridViewTextBoxColumn";
            this.tGLamViecDataGridViewTextBoxColumn.Width = 125;
            // 
            // ghiChuBCCDataGridViewTextBoxColumn
            // 
            this.ghiChuBCCDataGridViewTextBoxColumn.DataPropertyName = "GhiChuBCC";
            this.ghiChuBCCDataGridViewTextBoxColumn.HeaderText = "Ghi Chú";
            this.ghiChuBCCDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ghiChuBCCDataGridViewTextBoxColumn.Name = "ghiChuBCCDataGridViewTextBoxColumn";
            this.ghiChuBCCDataGridViewTextBoxColumn.Width = 125;
            // 
            // maBLDataGridViewTextBoxColumn
            // 
            this.maBLDataGridViewTextBoxColumn.DataPropertyName = "MaBL";
            this.maBLDataGridViewTextBoxColumn.HeaderText = "Mã BL";
            this.maBLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maBLDataGridViewTextBoxColumn.Name = "maBLDataGridViewTextBoxColumn";
            this.maBLDataGridViewTextBoxColumn.Width = 125;
            // 
            // bangChamCongBindingSource
            // 
            this.bangChamCongBindingSource.DataMember = "BangChamCong";
            this.bangChamCongBindingSource.DataSource = this.g221LBTSasaryPLBCC;
            // 
            // g221LBTSasaryPLBCC
            // 
            this.g221LBTSasaryPLBCC.DataSetName = "G221LBTSasaryPLBCC";
            this.g221LBTSasaryPLBCC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDongRBTV
            // 
            this.btnDongRBTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongRBTV.Location = new System.Drawing.Point(665, 485);
            this.btnDongRBTV.Name = "btnDongRBTV";
            this.btnDongRBTV.Size = new System.Drawing.Size(234, 37);
            this.btnDongRBTV.TabIndex = 16;
            this.btnDongRBTV.Text = "Đóng màn hình này";
            this.btnDongRBTV.UseVisualStyleBackColor = true;
            this.btnDongRBTV.Click += new System.EventHandler(this.btnDongRBTV_Click);
            // 
            // btnThoatCT
            // 
            this.btnThoatCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatCT.Location = new System.Drawing.Point(80, 485);
            this.btnThoatCT.Name = "btnThoatCT";
            this.btnThoatCT.Size = new System.Drawing.Size(234, 37);
            this.btnThoatCT.TabIndex = 15;
            this.btnThoatCT.Text = "Thoát chương ";
            this.btnThoatCT.UseVisualStyleBackColor = true;
            this.btnThoatCT.Click += new System.EventHandler(this.btnThoatCT_Click);
            // 
            // lbtitle
            // 
            this.lbtitle.AutoSize = true;
            this.lbtitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lbtitle.ForeColor = System.Drawing.Color.Blue;
            this.lbtitle.Location = new System.Drawing.Point(-179, -41);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(999, 25);
            this.lbtitle.TabIndex = 18;
            this.lbtitle.Text = "21 LBT XỬ LÝ RBTV DL  KHI (GIẢI QUYẾT THÔI VIỆC) XÓA NHÂN SỰ PHÚC LONG: Mã:...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(999, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "21 LBT XỬ LÝ RBTV DL  KHI (GIẢI QUYẾT THÔI VIỆC) XÓA NHÂN SỰ PHÚC LONG: Mã:...";
            // 
            // bangChamCongTableAdapter
            // 
            this.bangChamCongTableAdapter.ClearBeforeFill = true;
            // 
            // bangLuongTableAdapter
            // 
            this.bangLuongTableAdapter.ClearBeforeFill = true;
            // 
            // Fr03XLRBTVNSPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbBL);
            this.Controls.Add(this.gbBCC);
            this.Controls.Add(this.btnDongRBTV);
            this.Controls.Add(this.btnThoatCT);
            this.Controls.Add(this.lbtitle);
            this.Name = "Fr03XLRBTVNSPL";
            this.Text = "21 LBT XỬ LÝ RÀNG BUỘC TOÀN VẸN DỮ LIỆU  KHI (GIẢI QUYẾT THÔI VIỆC) XÓA NHÂN SỰ P" +
    "HÚC LONG ";
            this.Load += new System.EventHandler(this.Fr03XLRBTVNSPL_Load);
            this.gbBL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangLuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g221LBTSalasryPLBL)).EndInit();
            this.gbBCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangChamCongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g221LBTSasaryPLBCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBL;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnHuyAllBL;
        private System.Windows.Forms.Button btnHuyBL;
        private System.Windows.Forms.GroupBox gbBCC;
        private System.Windows.Forms.Button btnbackBCC;
        private System.Windows.Forms.Button btnHuyBCC;
        private System.Windows.Forms.DataGridView dGVBCC;
       private System.Windows.Forms.Button btnDongRBTV;
        private System.Windows.Forms.Button btnThoatCT;
        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuyAllBCC;
        private System.Windows.Forms.DataGridView dGVBL;
        private G221LBTSasaryPLBCC g221LBTSasaryPLBCC;
        private System.Windows.Forms.BindingSource bangChamCongBindingSource;
        private G221LBTSasaryPLBCCTableAdapters.BangChamCongTableAdapter bangChamCongTableAdapter;
        private G221LBTSalasryPLBL g221LBTSalasryPLBL;
        private System.Windows.Forms.BindingSource bangLuongBindingSource;
        private G221LBTSalasryPLBLTableAdapters.BangLuongTableAdapter bangLuongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBLDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNSPLDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKLDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongHSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuBLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNSPLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGLVChuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGLamViecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuBCCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maBLDataGridViewTextBoxColumn;
    }
}