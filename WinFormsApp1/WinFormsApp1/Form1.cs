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
            if (txtTenDangNhap.Text == "Admin" && txtMatKhau.Text == "Admin") {
                
                MessageBox.Show("Dang nhap thanh cong");
            }
        }
    }
}