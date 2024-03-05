namespace WinFormsApp1
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
    }
}