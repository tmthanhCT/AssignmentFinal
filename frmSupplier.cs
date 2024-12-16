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
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoadSupplier()
        {
            DatabaseConnection db = new DatabaseConnection();
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Supplier";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    lvSupplier.Items.Clear(); // Delete old data in ListView if any

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["SupplierID"].ToString());
                        item.SubItems.Add(reader["CompanyName"].ToString());
                        item.SubItems.Add(reader["Address"].ToString());
                        item.SubItems.Add(reader["PhoneNumber"].ToString());
                        item.SubItems.Add(reader["City"].ToString());
                        lvSupplier.Items.Add(item);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading supplier data: " + ex.Message);
            }
        }

        private void AddSupplier()
        {
            DatabaseConnection db = new DatabaseConnection();
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Supplier (CompanyName, Address, PhoneNumber, City) VALUES (@CompanyName, @Address, @PhoneNumber, @City)";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@City", txtCity.Text);

                    cmd.ExecuteNonQuery();

                    LoadSupplier(); // Refresh the list
                    MessageBox.Show("Supplier added successfully!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding supplier: " + ex.Message);
            }
        }


        private void UpdateSupplier(int supplierID)
        {
            DatabaseConnection db = new DatabaseConnection();
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Supplier SET CompanyName = @CompanyName, Address = @Address, PhoneNumber = @PhoneNumber, City = @City WHERE SupplierID = @SupplierID";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@City", txtCity.Text);
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);

                    cmd.ExecuteNonQuery();

                    LoadSupplier(); // Reload the list
                    MessageBox.Show("Supplier information updated successfully!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating provider: " + ex.Message);
            }
        }

        private void DeleteSupplier(int supplierID)
        {
            DatabaseConnection db = new DatabaseConnection();
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Supplier WHERE SupplierID = @SupplierID";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);

                    cmd.ExecuteNonQuery();
                    LoadSupplier(); // Reload the list
                    MessageBox.Show("Supplier deleted successfully!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting supplier: " + ex.Message);
            }
        }

        private void ResetSupplier()
        {
            LoadSupplier(); // Call back the LoadSupplier function written earlier
            txtSearch.Text = ""; // Clear search box content
        }


        private void SearchSupplier(string keyword)
        {
            DatabaseConnection db = new DatabaseConnection();
            try
            {
                using (SqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Supplier WHERE CompanyName LIKE @Keyword OR City LIKE @Keyword";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    SqlDataReader reader = cmd.ExecuteReader();
                    lvSupplier.Items.Clear(); // Xóa dữ liệu cũ trong ListView

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["SupplierID"].ToString());
                        item.SubItems.Add(reader["CompanyName"].ToString());
                        item.SubItems.Add(reader["Address"].ToString());
                        item.SubItems.Add(reader["PhoneNumber"].ToString());
                        item.SubItems.Add(reader["City"].ToString());
                        lvSupplier.Items.Add(item);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching for supplier: " + ex.Message);
            }
        }




        private void frmSupplier_Load(object sender, EventArgs e)
        {
            LoadSupplier();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddSupplier();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvSupplier.SelectedItems.Count > 0)
            {
                int supplierID = int.Parse(lvSupplier.SelectedItems[0].SubItems[0].Text);
                UpdateSupplier(supplierID);
            }
            else
            {
                MessageBox.Show("Please select a provider to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvSupplier.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this provider?",
                                                      "Confirm deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int supplierID = int.Parse(lvSupplier.SelectedItems[0].SubItems[0].Text); // Lấy SupplierID
                    DeleteSupplier(supplierID);
                }
            }
            else
            {
                MessageBox.Show("Please select a provider to delete.");
            }
        }

        private void lvSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSupplier.SelectedItems.Count > 0)
            {
                ListViewItem item = lvSupplier.SelectedItems[0];
                txtSupplierID.Text = item.SubItems[0].Text; // SupplierID
                txtCompanyName.Text = item.SubItems[1].Text; // CompanyName
                txtAddress.Text = item.SubItems[2].Text; // Address
                txtPhoneNumber.Text = item.SubItems[3].Text; // PhoneNumber
                txtCity.Text = item.SubItems[4].Text; // City
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                SearchSupplier(keyword);
            }
            else
            {
                MessageBox.Show("Please enter keywords to search.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetSupplier();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            frmHome.Show();
            this.Hide();
        }
    }
}
