﻿namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool kq = checkLogin(txtTenDangNhap.Text, txtMatKhau.Text);

            if(kq)
            {
                MessageBox.Show("Thành công");
            }
        }

        bool checkLogin(string userName, string passWord) {
            //read db
            return true;
        }

        /*
         Đâu biết lần đi một lỡ làng
        Dưới trời đau khổ chết yêu đương
         */




        /*
         Người xa xăm quá tôi buồn quá
        Trong một ngày vui pháo nhuộm đường
         */

        /*
         Ai đâu trở lại mùa thu trước
        Nhặt lấy cho tôi những lá vàng
         */



        /*
         Dang luc long toi muon tam yen
        bong ai mang lai canh hoa tim
        cho toi ep not dong du le
        ro xuong thanh tho khoc chut duyen
         * */

        /*
         Thuở ấy lòng tôi thơ thới quá
        Hồn thơ nguyên vẹn một trời hương
        Nhưng nhà nghệ sỹ từ đâu lại
        Êm ái trao tôi một vết thương
          */
        /*
         Them cau tho
         Them cau van 
         */

    }
}