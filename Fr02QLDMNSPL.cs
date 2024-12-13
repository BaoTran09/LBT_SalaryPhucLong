using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G221LBTSalaryPL
{
    public partial class Fr02QLDMNSPL : Form
    {
        //KHAI BÁO CÁC THAM SỐ TOÀN CỤC 
        //static string name = "", pass = "";
        string apppath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath)) + "\\Media\\"; //BIẾN TOÀN CỤC LƯU ĐƯỜNG DẪN ĐẾN THƯ MỤC LƯU APP BÀI LÀM NÀY:
                                                                                                                                  //string apppath = "C:\\Users\\trann\\Downloads\\G221LBTSalaryPL\\Media\\";
        public Fr02QLDMNSPL()
        {
            InitializeComponent();
        }
        //THỦ TỤC ĐƯỢC TỰ ĐỘNG CHẠY KHI FORM QUẢN LÝ NHÂN SỰ MỞ LÊN
        private void Fr02QLDMNSPL_Load(object sender, EventArgs e)
        {
            
            this.dMTrinhDoTableAdapter.Fill(this.g221LBTSalarysPLDMTD.DMTrinhDo);
            this.dMChucVuTableAdapter.Fill(this.g221LBTSalaPLDMCV.DMChucVu);
            this.dMChuyenMonTableAdapter.Fill(this.G221LBTSalasPLDMCM.DMChuyenMon);
            this.dMDonViTableAdapter.Fill(this.g221LBTSaPLsDMDV.DMDonVi);
            comboBoxDV_SelectedIndexChanged(sender, e);

        }///private void Fr02QLDMNSPL_Load(object sender, EventArgs e)

        //TỰ ĐỘNG TẢI LẠI DANH SÁCH NHÂN SỰ KHI CHỌN LẠI ĐƠN VỊ 
        private void comboBoxDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.dMNSPLTableAdapter.Fill(this.g221LBTSalasDMNSPL.DMNSPL, comboBoxDV.SelectedValue.ToString());
            }
            catch (Exception) { }

        }//comboBoxDV_SelectedIndexChanged
            /// <summary>
            /// CHỌN HÌNH MẪU CHO NHÂN SỰ
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            static string imagechoose = "";//Biến toàn cục Lưu tên file hình mà NSD đã chọn (Thêm/Sửa) đối với PictureBox
        private void ChonHinh(object sender, EventArgs e)
        {
          
                DialogResult ch = openFileDialogHinh.ShowDialog();//Mở hộp thoại cho phép NSD chọn hình cho nhân sự
                if (ch == DialogResult.OK)//NSD đồng ý với hình đã chọn
                {
                    //1. Lưu tên file của hình vừa copy nêu trên vào biến toàn cục để sau này (Thêm/Sửa) sẽ cập nhật vào 2 thuộc tính hinh trong Table DMNSPL của DB
                    imagechoose = System.IO.Path.GetFileName(openFileDialogHinh.FileName);//chỉ lấy tên file ko lấy đường dẫn

                    //2. Copy hình vừa chọn vào thư mục hình Media của App (để sau này Copy App đi nơi khác thư mục hình sẽ tự đi theo)
                    try
                    {
                        System.IO.File.Copy(openFileDialogHinh.FileName, apppath + imagechoose, true);
                    }
                    catch (System.Exception ex) { MessageBox.Show("Có lỗi sao chép hình vào thư mục của App" + ex.Message); }
                }
            }//private void ChonHinh(object sender, EventArgs e)


        /// <summary>
        /// THÊM (TUYỂN DỤNG) NHÂN SỰ MỚI {TRÊN DATAGRIDVIEW} VÀO DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
         
                //B1: ĐÓNG _ MỞ : ĐƯỢC PHÉP HAY KHÔNG ĐƯỢC THAY ĐỔI CÁC TEXTBOX THÔNG TIN NHÂN SỰ / GROUP BOX CHI TIET...
                txtMaNS.Enabled = !txtMaNS.Enabled;
                txtTenNS.Enabled = !txtTenNS.Enabled;
                txtSDT.Enabled = !txtSDT.Enabled;
                txtDiaChi.Enabled = !txtDiaChi.Enabled;
                checkBoxNu.Enabled = !checkBoxNu.Enabled;
                dtNgaySinh.Enabled = !dtNgaySinh.Enabled;
                dtNgayLam.Enabled = !dtNgayLam.Checked;
                comboBoxCM.Enabled = !comboBoxCM.Enabled;
                comboBoxCV.Enabled = !comboBoxCV.Enabled;
                comboBoxTD.Enabled = !comboBoxTD.Enabled;
                //khóa các nút lệnh khác (ngoại trừ được Đóng form)
                btnSua.Enabled = !btnSua.Enabled;
                btnXoa.Enabled = !btnXoa.Enabled;
                btnThoat.Enabled = !btnThoat.Enabled;

                if (btnThem.Text == "THÊM: Tuyển dụng")//CHUẨN BỊ THÊM NS
                {//MỞ CHẾ ĐỘ CHO NSD CHỌN HÌNH CHO SP MỚI
                    picBHinh.ImageLocation = apppath + "ImageChoose.png"; //hiện hình ảnh thông báo NSD chọn hình
                    picBHinh.Click += new EventHandler(ChonHinh); // cho phép NSD click vào PictureBox để chọn hình (Gán Event Click vào PictureBox Hình)
                //XÓA CÁC Ô TEXTBOX TRONG CHI TIẾT Ơ BÊN PHẢI ĐỂ CHUẨN BỊ CHO NSD NHẬP THÔNG TIN NS MỚI
                txtMaNS.Text = "";
                txtTenNS.Text = "";
                txtSDT.Text = "";
                txtDiaChi.Text = "";
                btnThem.Text = "Lưu (Thêm)";
                    //đổi nhãn Thêm => Lưu (sau khi NSD đã nhập đủ các thông tin NS mới)
                }
                else //THÊM NS MỚI VÀO DATABASE VÀ HIỆN LÊN DATAGRIDVIEW
                {//1. THÊM NS MỚI VÀO DB 
                    try
                    {//nếu NSD ko chọn hình thì biến toàn cục imagechoose = "" và có nghĩa là NS mới chưa có hình ảnh & ComboBox...ValueMenber = mspb
                    dMNSPLTableAdapter.Insert(txtMaNS.Text.Trim(), txtTenNS.Text, checkBoxNu.Checked ,dtNgaySinh.Text, dtNgayLam.Text, txtSDT.Text, apppath + imagechoose, comboBoxCM.SelectedValue.ToString(), comboBoxTD.SelectedValue.ToString(), comboBoxDV.SelectedValue.ToString(), comboBoxCV.SelectedValue.ToString(), txtDiaChi.Text);
                        MessageBox.Show("ĐÃ THÊM XONG");
                    }
                    catch (System.Exception ex) { MessageBox.Show("CÓ LỖI KHI THÊM NHÂN SỰ MỚI " + ex.Message); }

                    //2. TẢI LẠI DL SAU KHI THÊM NS MỚI TỪ DB LÊN DATAGRIDWIEW ĐỂ NSD BIẾT KQ [COPY code TỪ form_load OR Combobox_selectIndexChanhe]
                    comboBoxDV_SelectedIndexChanged(sender, e);

                    //3. THAY ĐỔI TRANG THÁI THÊM NS MỚI
                    //pictureBoxHinh.Click -= pictureBoxHinh_Click;//KHÔNG CHO NSD click vào PictureBoX hình (Xóa Event Click của PictureBox Hình)
                    picBHinh.ImageLocation = ""; //GỠ BỎ hình ảnh thông báo chọn hình
                    btnThem.Text = "THÊM: Tuyển dụng";//đổi nhãn trả lại Lưu => Thêm (thêm thêm mới NS khác)
                }
            }//private void btnThem_Click(object sender, EventArgs e)
            
            /// <summary>
            /// SỬA THÔNG TIN NHÂN SỰ TẠI VỊ TRÍ CHỌN TRÊN DATAGRIDVIEW
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
          
                //B1: ĐÓNG _ MỞ : ĐƯỢC PHÉP HAY KHÔNG ĐƯỢC THAY ĐỔI CÁC TEXTBOX THÔNG TIN NHÂN SỰ / GROUP BOX CHI TIET... 
            //txtMaNS.Enabled = !txtMaNS.Enabled;KHÔNG SỬA PK
            txtTenNS.Enabled = !txtTenNS.Enabled;
            txtSDT.Enabled = !txtSDT.Enabled;
            txtDiaChi.Enabled = !txtDiaChi.Enabled;
            checkBoxNu.Enabled = !checkBoxNu.Enabled;
            dtNgaySinh.Enabled = !dtNgaySinh.Enabled;
            dtNgayLam.Enabled = !dtNgayLam.Checked;
            comboBoxCM.Enabled = !comboBoxCM.Enabled;
            comboBoxCV.Enabled = !comboBoxCV.Enabled;
            comboBoxTD.Enabled = !comboBoxTD.Enabled;
            //khóa các nút lệnh khác (ngoại trừ được Đóng form)
            btnSua.Enabled = !btnSua.Enabled;
            btnXoa.Enabled = !btnXoa.Enabled;
            btnThoat.Enabled = !btnThoat.Enabled;
            if (btnSua.Text == "Sửa: thông tin nhân sự")//Bắt đầu sửa
                {//MỞ CHẾ ĐỘ CHO NSD CHỌN HÌNH MỚI CHO SP
                    picBHinh.ImageLocation = apppath + "ImageChoose.png"; //hiện hình ảnh thông báo NSD chọn hình
                picBHinh.Click += new EventHandler(ChonHinh); // cho phép NSD click vào PictureBox để chọn hình (Gán Event Click vào PictureBox Hình)
                                                                        //B2: HƯỚNG DẪN CÁCH SỬA
                    MessageBox.Show("Quý vị SỬA trong các ô Text bên phải, CHỌN LẠI HÌNH BẰNG CÁCH CLICK VÀO HÌNH ĐỂ CHỌN HÌNH MỚI THAY THẾ");
                    btnSua.Text = "Lưu (Sửa)";
                }
                else //LƯU SAU KHI SỬA XONG
                {//KIỂM TRA NSD CÓ THAY ĐỔI HÌNH HAY KHÔNG: NẾU CHỌN HÌNH MỚI THÌ THAY; NẾU KHÔNG THÌ GIỮ LẠI HÌNH CŨ
                    if (imagechoose == "") imagechoose = picBHinh.ImageLocation;
                    //NSD KHÔNG THAY ĐỔI HÌNH (NÊN giữa lại hình cũ)
                    try
                    { //B3: lưu DB
                    dMNSPLTableAdapter.Update(txtTenNS.Text, checkBoxNu.Checked, dtNgaySinh.Text, dtNgayLam.Text, txtSDT.Text, apppath + imagechoose, comboBoxCM.SelectedValue.ToString(), comboBoxTD.SelectedValue.ToString(), comboBoxCV.SelectedValue.ToString(), txtDiaChi.Text, txtMaNS.Text.Trim());
                    MessageBox.Show("Đã sửa xong !");
                    }
                    catch (System.Exception ex) { MessageBox.Show("Có lỗi sửa chữa thông tin sản phẩm " + ex.Message); }
                    //B4: ĐỔI NHÃN 
                    btnSua.Text = "SỬA: Điều chỉnh thông tin NS";
                // pictureBoxHinh.Click -= pictureBoxHinh_Click;//KHÔNG CHO NSD click vào PictureBoX hình (Xóa Event Click của PictureBox Hình)
                picBHinh.ImageLocation = ""; //GỠ BỎ hình ảnh thông báo chọn hình

                    //B5: Tải BD lên DataGridView sau khi sửa
                    comboBoxDV_SelectedIndexChanged(sender, e);
                }

            }//private void btnSua_Click(object sender, EventArgs e)
               
            /// XÓA NS TẠI VỊ TRÍ CHỌN / DATTAGRIDVIEW
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
           
         //B1: Hỏi xác nhận 
                DialogResult ch = MessageBox.Show("Xác nhận giải quyết thôi việc [xóa] nhân sự có mã " + txtMaNS.Text.Trim() + " (Y / N) ? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //B2: XÓA
                if (ch == DialogResult.Yes)
                {
                    try
                    {
                    dMNSPLTableAdapter.Delete(txtMaNS.Text.Trim());
                        MessageBox.Show("Xóa thành công !");
                    }
                    catch (System.Exception ex) { MessageBox.Show("Có lỗi Giải quyết thôi việc [XÓA] nhân sự" + ex.Message );
                    Fr03XLRBTVNSPL fr = new Fr03XLRBTVNSPL (txtMaNS.Text.Trim(), txtTenNS.Text);
                    //Gọi form Xl RBTV DL : truyền ms và tên MH cần xóa sang Fr RBTV
                    fr.ShowDialog(); //Mở form XL RBTV lên
                    }
                }
                //B3: Tải BD lên DataGridView sau khi xóa
                 comboBoxDV_SelectedIndexChanged(sender, e);

            }//private void btnXoa_Click(object sender, EventArgs e)


        //THOÁT CHƯƠNG TRÌNH
        private void btnThoat_Click(object sender, EventArgs e)
        {
          
                DialogResult ch = MessageBox.Show("Bạn có muốn thoát không? (Yes/No)", "Xác nhận thoát",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ch == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            //ĐÓNG MÀN HÌNH, VỀ LẠI MÀN HÌNH CHÍNH
        private void btnDong_Click(object sender, EventArgs e)
        {

                DialogResult ch = MessageBox.Show("Bạn có muốn đóng màn hình không? (Yes/No)", "Xác nhận đóng",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ch == DialogResult.Yes)
                {
                    this.Close();
                }
        }

        
    }//// public partial class Fr02QLDMNSPL : Form
}///namespace G221LBTSalaryPL

