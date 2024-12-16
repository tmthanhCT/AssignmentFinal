using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AssignmentFinal
{
    public partial class FrmLogin : Form
    {
        public class DatabaseConnection
        {
            // Chuỗi kết nối đến SQL Server
            private readonly string connectionString;

            // Constructor khởi tạo chuỗi kết nối
            public DatabaseConnection()
            {
                connectionString = @"Server=THANHNE\THANHCT;Database=FreshFruitStore;Trusted_Connection=True;";
            }

            // Hàm trả về đối tượng SqlConnection
            public SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra đăng nhập
        private bool checkLogin(string username, string password)
        {

            DatabaseConnection conn = new DatabaseConnection();
            using (SqlConnection connection = conn.GetConnection())
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Câu lệnh SQL kiểm tra thông tin đăng nhập
                    string query = "SELECT COUNT(1) FROM LoginForm WHERE USERNAME = @Username AND PASSWORDS = @Password";

                    // Sử dụng SqlCommand để thực thi truy vấn
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Tham số hóa để tránh SQL Injection
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Thực hiện truy vấn và lấy kết quả
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        // Trả về true nếu thông tin hợp lệ
                        return count == 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                    return false;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (checkLogin(username, password))
            {
                FrmHome mainForm = new FrmHome();
                mainForm.Show();


                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void chkViewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViewPass.Checked) 
            {
                txtPassword.PasswordChar = '\0'; 
            }
            else
            {
                txtPassword.PasswordChar = '*'; 
            }

        }
    }
}
