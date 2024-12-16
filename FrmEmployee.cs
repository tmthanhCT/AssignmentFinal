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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void LoadEmployees()
        {
            string query = "SELECT EmployeeID, EmployeeName, PhoneNumber, Address FROM Employee";

            lvEmployee.Items.Clear();

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["EmployeeID"].ToString());
                            item.SubItems.Add(reader["EmployeeName"].ToString());
                            item.SubItems.Add(reader["PhoneNumber"].ToString());
                            item.SubItems.Add(reader["Address"].ToString());
                            lvEmployee.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while data loading" + ex.Message, "Error");
                }
            }
        }

        private void AddEmployee()
        {
            string employeeID = txtEmployeeID.Text.Trim();
            string employeeName = txtEmployeeName.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(employeeName) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter complete information!", "Notification");
                return;
            }

            string query = "INSERT INTO Employee (EmployeeName, PhoneNumber, Address) VALUES (@EmployeeName, @PhoneNumber, @Address)";
            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);
                        command.Parameters.AddWithValue("@EmployeeName", employeeName);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Address", address);
                        command.ExecuteNonQuery();

                        LoadEmployees();
                        MessageBox.Show("Add Employee succsessfully", "Notification");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while employee adding " + ex.Message, "Error");
                }
            }
        }

        private void UpdateEmployee()
        {
            if (lvEmployee.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an employee to update!", "Notification");
                return;
            }

            string employeeID = lvEmployee.SelectedItems[0].SubItems[0].Text;
            string employeeName = txtEmployeeName.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(employeeName) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter complete information!", "Notification");
                return;
            }

            string query = "UPDATE Employee SET EmployeeName = @EmployeeName, PhoneNumber = @PhoneNumber, Address = @Address WHERE EmployeeID = @EmployeeID";
            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Assign values ​​to parameters
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);
                        command.Parameters.AddWithValue("@EmployeeName", employeeName);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Address", address);
                        command.ExecuteNonQuery();

                        LoadEmployees();
                        MessageBox.Show("Employee success update!", "Notification");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while updating employee: " + ex.Message, "Error");
                }
            }
        }

        private void DeleteEmployee()
        {
            if (lvEmployee.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an employee to delete!", "Notification");
                return;
            }

            string employeeID = lvEmployee.SelectedItems[0].SubItems[0].Text;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this employee?", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            string query = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";
            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Assign values ​​to parameters
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);
                        command.ExecuteNonQuery();

                        LoadEmployees();
                        MessageBox.Show("Employee deleted successfully!", "Notification");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting employee: " + ex.Message, "Error");
                }
            }
        }

        private void SearchEmployee()
        {
            string searchValue = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter search information!", "Notification");
                return;
            }
            // SQL search statement
            string query = "SELECT EmployeeID, EmployeeName, PhoneNumber, Address FROM Employee " +
                           "WHERE EmployeeName LIKE @SearchValue OR PhoneNumber LIKE @SearchValue";

            lvEmployee.Items.Clear();

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["EmployeeID"].ToString());
                            item.SubItems.Add(reader["EmployeeName"].ToString());
                            item.SubItems.Add(reader["PhoneNumber"].ToString());
                            item.SubItems.Add(reader["Address"].ToString());
                            lvEmployee.Items.Add(item);
                        }
                    }

                    if (lvEmployee.Items.Count == 0)
                    {
                        MessageBox.Show("No matching data found!", "Notification");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while searching: " + ex.Message, "Lỗi");
                }
            }
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            // Call the load function on the event
            LoadEmployees();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Call the add event function
            AddEmployee();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Call the update event function
            UpdateEmployee();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Call the Delete event function
            DeleteEmployee();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Call the search event function
            SearchEmployee();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadEmployees();
            txtSearch.Clear();
        }

        private void lvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display data from listview to textbox
            if (lvEmployee.SelectedItems.Count > 0)
            {
                ListViewItem item = lvEmployee.SelectedItems[0];
                txtEmployeeID.Text = item.SubItems[0].Text;
                txtEmployeeName.Text = item.SubItems[1].Text;
                txtPhoneNumber.Text = item.SubItems[2].Text;
                txtAddress.Text = item.SubItems[3].Text;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome fromHome = new FrmHome();
            fromHome.Show();
            this.Hide();
        }
    }
}
