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
    public partial class Fr03XLRBTVNSPL : Form
    {
        static string ms = "", ten = "";
       public Fr03XLRBTVNSPL(string MaNSPL, string TenNS)
        {
            InitializeComponent(); 
            ms = MaNSPL;
            ten = TenNS;

        }
        //THỦ TỤC NÀY TỰ ĐỘNG CHẠY KHI FORM ĐƯỢC MỞ LÊN
        private void Fr03XLRBTVNSPL_Load(object sender, EventArgs e)
        {            
            
            lbtitle.Text = "XỬ LÝ RBTV KHI XỬ LÝ THÔI VIỆC CÓ MÃ SỐ " + ms + " _ " + ten;
            gbBCC.Text = "CẦN XỬ LÝ CÁC BẢNG CHẤM CÔNG SAU ĐÂY CỦA NHÂN SỰ: " + ms + " _ " + ten;
            gbBL.Text = "CẦN XỬ LÝ CÁC KHOẢN NỢ CỦA NHÂN VIÊN " + ms + " _ " + ten + "TRÊN CÁC BẢNG LƯƠNG SAU";
            try
            {
             this.bangChamCongTableAdapter.Fill(this.g221LBTSasaryPLBCC.BangChamCong,ms);
            }catch (Exception) { }
            try
            {
               this.bangLuongTableAdapter.Fill(this.g221LBTSalasryPLBL.BangLuong,ms);
            
            }
            catch (Exception) { }
        }//private void Fr03XLRBTVNSPL_Load(object sender, EventArgs e)

        private void btnHuyBCC_Click(object sender, EventArgs e)
        {
            if (dGVBCC.Rows.Count > 1)// danh sach bên trái có ít nhất 1 dòng
            {
                //B1: XỬ LÝ TRƯỜNG HỢP NSD CHƯA CHỌN DÒNG NÀO TRONG DS BÊN TRÁI (ĐỂ XÓA).             
                DataGridViewRow r = null; // biến tạm lưu dòng đang chọn trong DataGridView
                try
                {
                    r = dGVBCC.SelectedRows[0];
                    //Vì thuộc tính MultiSelect = Flase nên chỉ có 1 dòng được chọn do đó SelectedRows[0]là dòng chọn đầu tiên cũng là duy nhất
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Cần phải chọn 1 dòng trong danh sách bên trái. trước khi bấm nút này");
                    goto kt;
                }

                //B2: HỎI XÁC NHẬN
                DialogResult ch = MessageBox.Show("Xóa BẢNG CHẤM CÔNG có MÃ NHÂN SỰ:" + ms + " Tại vị trí chọn trong danh sách bên trái đúng không(Y/N)?",
                                                                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//Hỏi xác nhận

                //B3: XÓA nếu NSD Yes  [Nên Try...catch...: tránh phát sinh lỗi dừng đột ngột chương trình
                if (ch == DialogResult.Yes)
                {
                    try
                    {
                        bangChamCongTableAdapter.Delete(r.Cells[0].Value.ToString().Trim(), ms);
                        MessageBox.Show("Xóa thành công!");
                    }
                    catch (System.Exception ex) { MessageBox.Show("Đã xảy ra lỗi =" + ex.Message); }
                }//if[YES]
                 //B3: TẢI DL SAU KHI XÓA LÊN DATAGRIDVIEWCTNV
                try
                {
                    this.bangChamCongTableAdapter.Fill(this.g221LBTSasaryPLBCC.BangChamCong, ms);
                }
                catch (System.Exception) { }
            }//if count > 1; có thể else = thông báo không có dòng nào nên không xóa được
        kt:;
        }

        //XÓA TẤT CẢ BẢNG CHẤM CÔNG
        private void btnHuyAllBCC_Click(object sender, EventArgs e)
        {
                if (dGVBCC.Rows.Count > 1)// danh sach bên trái có ít nhất 1 dòng
                {
                    //B1: HỎI XÁC NHẬN
                    DialogResult ch = MessageBox.Show("Xóa TẤT CẢ BẢNG CHẤM CÔNG:có MÃ NHÂN SỰ" + ms + " đúng không(Y/N)?", "Xác nhận", MessageBoxButtons.YesNo,
                                                                                                            MessageBoxIcon.Question);//Hỏi xác nhận


                    //B2: XÓA nếu NSD Yes  [Nên Try...catch...: tránh phát sinh lỗi dừng đột ngột chương trình
                    if (ch == DialogResult.Yes)
                    {
                        try
                        {
                            bangChamCongTableAdapter.DeleteQuery(ms);
                            MessageBox.Show("Xóa thành công!");
                        }
                        catch (System.Exception ex) { MessageBox.Show("Đã xảy ra lỗi =" + ex.Message); }
                    }//if(Yes)

                    //B3: TẢI DL SAU KHI XÓA LÊN DATAGRIDVIEWCTNV
                    try
                    {
                        this.bangChamCongTableAdapter.Fill(this.g221LBTSasaryPLBCC.BangChamCong, ms);
                    }
                    catch (System.Exception) { }

                }//if count > 1; có thể else = thông báo không có dòng nào nên không xóa được
        }
        ///private void btnHuyAllBCC_Click(object sender, EventArgs e)

        //HỦY 1 BẢNG LƯƠNG TẠI VỊ TRÍ CHỌN TRÊN DATAGRIDVIEW
        private void btnHuyBL_Click(object sender, EventArgs e)
        {
            if (dGVBL.Rows.Count > 1)// danh sach bên trái có ít nhất 1 dòng
            {
                //B1: XỬ LÝ TRƯỜNG HỢP NSD CHƯA CHỌN DÒNG NÀO TRONG DS BÊN TRÁI (ĐỂ XÓA).             
                DataGridViewRow r = null; // biến tạm lưu dòng đang chọn trong DataGridView
                try
                {
                    r = dGVBL.SelectedRows[0];//Vì thuộc tính MultiSelect = Flase nên chỉ có 1 dòng được chọn do đó SelectedRows[0] là dòng chọn đầu tiên cũng là duy nhất
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Cần phải chọn 1 dòng trong danh sách bên trái. trước khi bấm nút này");
                    goto kt;
                }
                //B2: HỎI XÁC NHẬN
                DialogResult ch = MessageBox.Show("Xóa BẢNG LƯƠNG của NHÂN SỰ có MÃ:" + ms +
                   " Tại vị trí chọn trong danh sách bên trái đúng không(Y/N)?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);//Hỏi xác nhận
                //B3: TẢI DL SAU KHI XÓA LÊN DATAGRIDVIEWCTNV
                try
                {
                    this.bangLuongTableAdapter.Fill(this.g221LBTSalasryPLBL.BangLuong, ms);
                }
                catch (System.Exception) { }
            }//if count > 1; có thể else = thông báo không có dòng nào nên không xóa được
        kt:;
        }
        //HỦY TOÀN BỘ CÁC BẢNG LƯƠNG TRÊN DATAGRIDVIEW
        private void btnHuyAllBL_Click(object sender, EventArgs e)
        {
            if (dGVBL.Rows.Count > 1)// danh sach bên trái có ít nhất 1 dòng
            {//B1: HỎI XÁC NHẬN
                DialogResult ch = MessageBox.Show("Xóa TẤT CẢ BẢNG LƯƠNG có MÃ NHÂN SỰ:" + ms +
                " đúng không(Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Hỏi xác nhận
                //B2: XÓA nếu NSD Yes  [Nên Try...catch...: tránh phát sinh lỗi dừng đột ngột chương trình
                if (ch == DialogResult.Yes)
                {
                    try
                    {
                        bangLuongTableAdapter.DeleteQuery(ms);
                        MessageBox.Show("Xóa thành công !");
                    }
                    catch (System.Exception ex) { MessageBox.Show("Đã phát hiện ra lỗi lỗi =" + ex.Message); }
                }//if(Yes)
                 //B3: TẢI DL SAU KHI XÓA LÊN DATAGRIDVIEWCTNV
                try
                {
                    this.bangLuongTableAdapter.Fill(this.g221LBTSalasryPLBL.BangLuong, ms);
                }
                catch (System.Exception) { }
            }//if count > 1; có thể else = thông báo không có dòng nào nên không xóa được
            else//if count > 1
            {
                MessageBox.Show("Không có BẢNG LƯƠNG nào để xóa");
            }
        }//private void btnHuyAllBL_Click(object sender, EventArgs e)

        //QUAY LẠI MÀN HÌNH DMNS Ở GROUPBOX: gbBCC
        private void btnbackBCC_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn quay lại không? (Yes/No)", "Đã quay lại",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //QUAY LẠI MÀN HÌNH DMNS Ở GROUPBOX: gbBL
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn quay lại không? (Yes/No)", "Đã quay lại",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //ĐÓNG MÀN HÌNH
        private void btnDongRBTV_Click(object sender, EventArgs e)
        {

            DialogResult ch = MessageBox.Show("Bạn có muốn đóng màn hình không? (Yes/No)", "Xác nhận đóng",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //THOÁT CHƯƠNG TRÌNH
        private void btnThoatCT_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Bạn có muốn thoát không? (Yes/No)", "Xác nhận thoát",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
    }

}



