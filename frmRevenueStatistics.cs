using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AssignmentFinal.FrmLogin;

namespace AssignmentFinal
{
    public partial class frmRevenueStatistics : Form
    {
        public frmRevenueStatistics()
        {
            InitializeComponent();
        }

        private void LoadRevenueReport()
        {
            string query = @"
        SELECT 
            b.BillID,
            b.BillDate,
            SUM(bd.Quantity) AS TotalQuantity,
            AVG(bd.UnitPrice) AS AverageUnitPrice,
            SUM(bd.Quantity * bd.UnitPrice) AS TotalRevenue
        FROM Bill b
        JOIN BillDetails bd ON b.BillID = bd.BillID
        GROUP BY b.BillID, b.BillDate
        ORDER BY b.BillDate DESC";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            lvViewStatistics.Items.Clear(); // Xóa dữ liệu cũ trong ListView

                            while (reader.Read())
                            {
                                // Định dạng các giá trị trước khi hiển thị
                                string billID = reader["BillID"].ToString();
                                string billDate = Convert.ToDateTime(reader["BillDate"]).ToString("yyyy-MM-dd");
                                string totalQuantity = Convert.ToInt32(reader["TotalQuantity"]).ToString("N0"); // Số nguyên có dấu phân cách
                                string averageUnitPrice = Convert.ToDecimal(reader["AverageUnitPrice"]).ToString("N2"); // 2 chữ số thập phân
                                string totalRevenue = Convert.ToDecimal(reader["TotalRevenue"]).ToString("N2"); // 2 chữ số thập phân

                                // Tạo ListViewItem
                                ListViewItem item = new ListViewItem(billID);
                                item.SubItems.Add(billDate);
                                item.SubItems.Add(totalQuantity);
                                item.SubItems.Add(averageUnitPrice);
                                item.SubItems.Add(totalRevenue);

                                // Thêm vào ListView
                                lvViewStatistics.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading revenue report data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void SearchBillByDate(DateTime selectedDate)
        {
            lvViewStatistics.Items.Clear();

            string query = "SELECT * FROM Bill WHERE CONVERT(DATE, BillDate) = @SelectedDate";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SelectedDate", selectedDate.ToString("yyyy-MM-dd"));

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["BillID"].ToString());
                    item.SubItems.Add(reader["CustomerID"].ToString());
                    item.SubItems.Add(reader["EmployeeID"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["BillDate"]).ToString("yyyy-MM-dd"));
                    lvViewStatistics.Items.Add(item);
                }
            }
        }

        private void frmRevenueStatistics_Load(object sender, EventArgs e)
        {
            LoadRevenueReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpDateTime.Value;

            SearchBillByDate(selectedDate);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            frmHome.Show();
            this.Hide();
        }
    }
}
