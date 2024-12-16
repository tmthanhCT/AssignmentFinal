using System;
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
    public partial class frmBIll : Form
    {
        public frmBIll()
        {
            InitializeComponent();
        }
        public void LoadBillData()
        {
            lvBill.Items.Clear();

            // Query string to get data
            string query = "SELECT BillID, CustomerID, EmployeeID, BillDate FROM Bill";

            // Connect to database
            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Read data and add to ListView
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["BillID"].ToString());
                        item.SubItems.Add(reader["CustomerID"].ToString());
                        item.SubItems.Add(reader["EmployeeID"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["BillDate"]).ToString("yyyy-MM-dd"));

                        lvBill.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void AddBill()
        {
            string query = "INSERT INTO Bill (CustomerID, EmployeeID, BillDate) VALUES (@CustomerID, @EmployeeID, @BillDate)";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
                    cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);
                    cmd.Parameters.AddWithValue("@BillDate", dtpBillDate.Value);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        LoadBillData(); // Refresh ListView
                        MessageBox.Show("Invoice added successfully!");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding invoice: " + ex.Message);
                }
            }
        }


        private void UpdateBill(int billID)
        {
            if (lvBill.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an invoice to update!");
                return;
            }

            string query = "UPDATE Bill SET CustomerID = @CustomerID, EmployeeID = @EmployeeID, BillDate = @BillDate WHERE BillID = @BillID";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
                    cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);
                    cmd.Parameters.AddWithValue("@BillDate", dtpBillDate.Value);
                    cmd.Parameters.AddWithValue("@BillID", lvBill.SelectedItems[0].Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        LoadBillData(); // Refresh ListView
                        MessageBox.Show("Invoice updated successfully!");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating invoice: " + ex.Message);
                }
            }
        }


        private void DeleteBill()
        {
            if (lvBill.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an invoice to delete!");
                return;
            }

            string query = "DELETE FROM Bill WHERE BillID = @BillID";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BillID", lvBill.SelectedItems[0].Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        LoadBillData(); // Refresh ListView
                        MessageBox.Show("Invoice deleted successfully!");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when deleting invoice: " + ex.Message);
                }
            }
        }

        private void SearchBill(string searchKeyword)
        {
            // Delete old data in ListView
            lvBill.Items.Clear();

            // Query string to search for data
            string query = "SELECT BillID, CustomerID, EmployeeID, BillDate FROM Bill WHERE BillID LIKE @search OR CustomerID LIKE @search OR EmployeeID LIKE @search OR BillDate LIKE @search";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchKeyword + "%");

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Đọc dữ liệu và thêm vào ListView
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["BillID"].ToString());
                        item.SubItems.Add(reader["CustomerID"].ToString());
                        item.SubItems.Add(reader["EmployeeID"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["BillDate"]).ToString("yyyy-MM-dd"));

                        lvBill.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when searching for invoice: " + ex.Message);
                } 
            }
        }


        private void ResetSearch()
        {
            // Clear the value in the search box
            txtSearch.Clear();

            // Reload all data into ListView
            LoadBillData();
        }



        private void frmBIll_Load(object sender, EventArgs e)
        {
            LoadBillData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBill();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvBill.SelectedItems.Count > 0)
            {
                try
                {
                    int billID = int.Parse(lvBill.SelectedItems[0].SubItems[0].Text); // Get BillID from ListView
                    UpdateBill(billID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating invoice: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an invoice to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBill();
        }

        private void lvBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBill.SelectedItems.Count > 0)
            {
                ListViewItem item = lvBill.SelectedItems[0];
                txtBillID.Text = item.SubItems[0].Text;
                txtCustomerID.Text = item.SubItems[1].Text; // CustomerID
                txtEmployeeID.Text = item.SubItems[2].Text; // EmployeeID
                dtpBillDate.Value = Convert.ToDateTime(item.SubItems[3].Text); // BillDate
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetSearch();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim(); // Get search keyword from TextBox
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                SearchBill(searchKeyword); // Call the search function
            }
            else
            {
                MessageBox.Show("Please enter search keywords.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHome fromHome = new FrmHome();
            fromHome.Show();
            this.Hide();
        }

    }
}
