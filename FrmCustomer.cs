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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer()
        {
            // Get data from TextBox
            string customerID = txtCusID.Text.Trim();
            string customerName = txtCusName.Text.Trim();
            string phoneNumber = txtPhone.Text.Trim();
            string gender = txtGender.Text.Trim();
            string city = txtCity.Text.Trim();
            string country = txtCountry.Text.Trim();

            // Check if data is not entered enough
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(phoneNumber) ||
                string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(country))
            {
                MessageBox.Show("Please enter complete information!", "Notification");
                return;
            }

            // SQL statement to add new customer
            string query = "INSERT INTO Customers (CustomerName, PhoneNumber, Gender, City, Country) " +
                           "VALUES (@CustomerName, @PhoneNumber, @Gender, @City, @Country)" +
                           "";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Assign values ​​to parameters
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@City", city);
                        command.Parameters.AddWithValue("@Country", country);

                        // Execute the new command
                        command.ExecuteNonQuery();
                        // After successfully adding, call the LoadCustomers function again to display new data on the ListView
                        LoadDataCustomerToList();
                        MessageBox.Show("Add customer successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message, "Lỗi");
                }
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }


        public void LoadDataCustomerToList()
        {
            DatabaseConnection db = new DatabaseConnection();

            // SQL statement to get all information from Customers table
            string query = "SELECT CustomerID, CustomerName, PhoneNumber, Gender, City, Country FROM Customers" +
                " ORDER BY CustomerID DESC";

            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    // Open connection
                    connection.Open();

                    // Create SqlCommand to execute query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Use SqlDataReader to read data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Delete old items in ListView
                            lvViewCus.Items.Clear();

                            // Read each line and add to ListView
                            while (reader.Read())
                            {
                                // Create a new item from the readable line
                                ListViewItem item = new ListViewItem(reader["CustomerID"].ToString());
                                item.SubItems.Add(reader["CustomerName"].ToString());
                                item.SubItems.Add(reader["PhoneNumber"].ToString());
                                item.SubItems.Add(reader["Gender"].ToString());
                                item.SubItems.Add(reader["City"].ToString());
                                item.SubItems.Add(reader["Country"].ToString());

                                // Add item to ListView
                                lvViewCus.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadDataCustomerToList();
        }

        private void lvViewCus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvViewCus.SelectedItems.Count > 0)
            {
                ListViewItem item = lvViewCus.SelectedItems[0];
                txtCusID.Text = item.SubItems[0].Text;
                txtCusName.Text = item.SubItems[1].Text;
                txtPhone.Text = item.SubItems[2].Text;
                txtGender.Text = item.SubItems[3].Text;
                txtCity.Text = item.SubItems[4].Text;
                txtCountry.Text = item.SubItems[5].Text;
            }
        }
        private void DeleteCustomer()
        {
            if (lvViewCus.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete!");
                return;
            }

            // Get CustomerID from selected customer
            string customerID = lvViewCus.SelectedItems[0].SubItems[0].Text;

            // SQL statement to delete customer
            string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Assign value to parameter
                        command.Parameters.AddWithValue("@CustomerID", customerID);

                        // Execute the command
                        command.ExecuteNonQuery();

                        // Remove from ListView
                        lvViewCus.SelectedItems[0].Remove();
                        LoadDataCustomerToList();

                        MessageBox.Show("Customer deleted successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting customer: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Call the delete function again
            DeleteCustomer();
        }

        private void EditCustomer()
        {
            if (lvViewCus.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a customer to edit!");
                return;
            }

            // Get data from TextBoxes
            string customerID = txtCusID.Text;
            string customerName = txtCusName.Text;
            string phoneNumber = txtPhone.Text;
            string gender = txtGender.Text;
            string city = txtCity.Text;
            string country = txtCountry.Text;

            // SQL statement to update data
            string query = "UPDATE Customers SET CustomerName = @CustomerName, PhoneNumber = @PhoneNumber, " +
                           "Gender = @Gender, City = @City, Country = @Country WHERE CustomerID = @CustomerID";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Assign values ​​to parameters
                        command.Parameters.AddWithValue("@CustomerID", customerID);
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@City", city);
                        command.Parameters.AddWithValue("@Country", country);

                        // Execute the command
                        command.ExecuteNonQuery();

                        // Update ListView
                        ListViewItem item = lvViewCus.SelectedItems[0];
                        item.SubItems[1].Text = customerName;
                        item.SubItems[2].Text = phoneNumber;
                        item.SubItems[3].Text = gender;
                        item.SubItems[4].Text = city;
                        item.SubItems[5].Text = country;

                        LoadDataCustomerToList();
                        MessageBox.Show("Customer update successful!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when editing customer: " + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditCustomer();
        }

        private void SearchCustomer(string keyword)
        {
            // SQL search statement
            string query = "SELECT CustomerID, CustomerName, PhoneNumber, Gender, City, Country " +
                           "FROM Customers " +
                           "WHERE CustomerName LIKE @Keyword OR CustomerID LIKE @Keyword";

            // Delete old data in ListView
            lvViewCus.Items.Clear();

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Assign value to parameter @Keyword
                        command.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            // Get data from each column
                            string customerID = reader["CustomerID"].ToString();
                            string customerName = reader["CustomerName"].ToString();
                            string phoneNumber = reader["PhoneNumber"].ToString();
                            string gender = reader["Gender"].ToString();
                            string city = reader["City"].ToString();
                            string country = reader["Country"].ToString();

                            // Add data to ListView
                            ListViewItem item = new ListViewItem(customerID);
                            item.SubItems.Add(customerName);
                            item.SubItems.Add(phoneNumber);
                            item.SubItems.Add(gender);
                            item.SubItems.Add(city);
                            item.SubItems.Add(country);

                            lvViewCus.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while searching: " + ex.Message, "Error");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter search keywords!", "Notification");
                return;
            }

            // Call the Search function
            SearchCustomer(keyword);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDataCustomerToList();
            txtSearch.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome fromhome = new FrmHome();
            fromhome.Show();
            this.Hide();
        }
    }
}
