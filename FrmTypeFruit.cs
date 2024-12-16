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
    public partial class FrmTypeFruit : Form
    {
        public FrmTypeFruit()
        {
            InitializeComponent();
        }

        private void LoadTypeFruits()
        {
            // SQL statement to get data from TypeFruit table
            string query = "SELECT FruitTypeID, CategoryName, Description FROM FruitType";

            // Delete old items in ListView before adding new data
            lvViewTypeFruit.Items.Clear();

            // Use DatabaseConnection class to connect
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
                            // Get data from TypeFruit table
                            string fruitTypeID = reader["FruitTypeID"].ToString();
                            string categoryName = reader["CategoryName"].ToString();
                            string description = reader["Description"].ToString();

                            // Create a new row in the ListView
                            ListViewItem item = new ListViewItem(fruitTypeID);
                            item.SubItems.Add(categoryName);
                            item.SubItems.Add(description);

                            // Add row to ListView
                            lvViewTypeFruit.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error");
                }
            }
        }

        private void AddTypeFruit()
        {
            string fruitTypeID = txtFruitTypeID.Text.Trim();
            string categoryName = txtTypeName.Text.Trim();
            string description = txtDescription.Text.Trim();

            // Check input data
            if (string.IsNullOrEmpty(categoryName) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please enter complete information!", "Notification");
                return;
            }

            // Add data to database
            string query = "INSERT INTO FruitType (CategoryName, Description) VALUES (@CategoryName, @Description)";
            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FruitType", fruitTypeID);
                        command.Parameters.AddWithValue("@CategoryName", categoryName);
                        command.Parameters.AddWithValue("@Description", description);
                        command.ExecuteNonQuery();

                        // Update ListView
                        LoadTypeFruits();
                        MessageBox.Show("Add fruit successfully!", "Notification");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding fruit type: " + ex.Message, "Error");
                }
            }
        }

        private void UpdateTypeFruit()
        {
            if (lvViewTypeFruit.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a fruit to update!", "Notification");
                return;
            }

            // Get FruitTypeID from ListView
            string fruitTypeID = lvViewTypeFruit.SelectedItems[0].SubItems[0].Text;
            string categoryName = txtTypeName.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(categoryName) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please enter complete information!", "Notification");
                return;
            }

            // Update data in database
            string query = "UPDATE FruitType SET CategoryName = @CategoryName, Description = @Description WHERE FruitTypeID = @FruitTypeID";
            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FruitTypeID", fruitTypeID);
                        command.Parameters.AddWithValue("@CategoryName", categoryName);
                        command.Parameters.AddWithValue("@Description", description);
                        command.ExecuteNonQuery();

                        // Update ListView
                        LoadTypeFruits();
                        MessageBox.Show("Fruit type updated successfully!", "Notification");


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while updating fruit type: " + ex.Message, "Error");
                }
            }
        }

        private void DeleteTypeFruit()
        {
            if (lvViewTypeFruit.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a fruit to delete!", "Notification");
                return;
            }

            // Lấy FruitTypeID từ ListView
            string fruitTypeID = lvViewTypeFruit.SelectedItems[0].SubItems[0].Text;

            // Xác nhận trước khi xóa
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this fruit?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            // Xóa dữ liệu trong database
            string query = "DELETE FROM FruitType WHERE FruitTypeID = @FruitTypeID";
            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FruitTypeID", fruitTypeID);
                        command.ExecuteNonQuery();

                        // Update ListView
                        LoadTypeFruits();
                        MessageBox.Show("Fruit deleted successfully!", "Notification");


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting fruit type: " + ex.Message, "Error");
                }
            }
        }

        private void SearchFruitType()
        {
            string searchValue = txtSearch.Text.Trim(); // TextBox used to enter search value
            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter search information!", "Notification");
                return;
            }

            string query = "SELECT FruitTypeID, CategoryName, Description FROM FruitType " +
                           "WHERE FruitTypeID LIKE @SearchValue OR CategoryName LIKE @SearchValue";

            lvViewTypeFruit.Items.Clear(); // Delete old data on ListView

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Search with wildcard (%)
                        command.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["FruitTypeID"].ToString());
                            item.SubItems.Add(reader["CategoryName"].ToString());
                            item.SubItems.Add(reader["Description"].ToString());
                            lvViewTypeFruit.Items.Add(item);
                        }
                    }

                    if (lvViewTypeFruit.Items.Count == 0)
                    {
                        MessageBox.Show("No matching data found!", "Notification");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while searching: " + ex.Message, "Error");
                }
            }
        }




        private void FrmTypeFruit_Load(object sender, EventArgs e)
        {
            LoadTypeFruits();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTypeFruit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateTypeFruit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteTypeFruit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchFruitType();
        }

        private void lvViewTypeFruit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvViewTypeFruit.SelectedItems.Count > 0)
            {
                ListViewItem item = lvViewTypeFruit.SelectedItems[0];
                txtFruitTypeID.Text = item.SubItems[0].Text;
                txtTypeName.Text = item.SubItems[1].Text;
                txtDescription.Text = item.SubItems[2].Text;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            frmHome.Show();
            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
