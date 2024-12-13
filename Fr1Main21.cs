using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace G221LBTSalaryPL
{
    public partial class Fr1Main21 : Form
    {
        public Fr1Main21()
        {
            InitializeComponent();
        }
        private void Fr1Main21_Load(object sender, EventArgs e)
        {
            lbday.Text=System.DateTime.Now.ToShortDateString();
        }
        /// <summary>
        /// THOÁT CHƯƠNG TRÌNH 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult  Chon = MessageBox.Show("Bạn có muốn thoát không? (Yes/No)","Xác nhận thoát", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if ( Chon==DialogResult.Yes)
            {
                Application.Exit();
;            }
        }
        /// <summary>
        /// NHẢY ĐỒNG HỒ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbtime.Text = System.DateTime.Now.ToLongTimeString();
        }
        /// <summary>
        /// GỌI FORM QUẢN LÝ DANH MỤC NHÂN SỰ PHÚC LONG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dANHMỤCNHÂNSỰToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr02QLDMNSPL fr = new Fr02QLDMNSPL(); // Tạo đối tượng form
            fr.Enabled = true;                   // Đảm bảo form được kích hoạt
            fr.ShowDialog();                     // Hiển thị form dưới dạng modal
        }

    }//PUBLIC PARTIAL CLASS FR1MAIN21: FORM
}//NAMESPACE G221LBTSALARYPL
