using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AssignmentFinal.FrmLogin;

namespace AssignmentFinal
{
    public partial class FrmFruitManage : Form
    {
        public FrmFruitManage()
        {
            InitializeComponent();
        }

        private void UpdateStockRemaining()
        {
            string query = @"
        UPDATE Fruit
        SET StockRemaining = 
            CASE 
                WHEN StockRemaining >= Billdetails.Quantity 
                THEN StockRemaining - Billdetails.Quantity
                ELSE StockRemaining
            END
        FROM Fruit 
        INNER JOIN BillDetails Billdetails
            ON Fruit.FruitID = Billdetails.FruitID;
    ";

            // Tạo kết nối đến database
            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Stock remaining updated successfully!", "Notification");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating StockRemaining: " + ex.Message, "Error");
                }
            }
        }

        private void LoadFruitDataToListView()
        {
            string query = "SELECT FruitID, FruitName, SupplierID, FruitTypeID, UnitPrice, StockRemaining FROM Fruit";

            // Kết nối đến database
            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        lvFruit.Items.Clear(); // Xóa dữ liệu cũ trong ListView

                        while (reader.Read())
                        {
                            // Tạo một dòng mới trong ListView
                            ListViewItem item = new ListViewItem(reader["FruitID"].ToString());
                            item.SubItems.Add(reader["FruitName"].ToString());
                            item.SubItems.Add(reader["SupplierID"].ToString());
                            item.SubItems.Add(reader["FruitTypeID"].ToString());
                            item.SubItems.Add(Convert.ToDecimal(reader["UnitPrice"]).ToString("C2")); // Định dạng tiền tệ
                            item.SubItems.Add(reader["StockRemaining"].ToString());

                            // Thêm dòng vào ListView
                            lvFruit.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading fruit data: " + ex.Message, "Error");
                }
            }
        }

        private void AddFruit()
        {
            // Get data from TextBoxes
            string fruitID = txtFruitName.Text.Trim();
            string fruitName = txtFruitName.Text.Trim();
            string supplierID = txtSupplierID.Text.Trim();
            string typeFruitID = txtFruitTypeID.Text.Trim();
            string unitPrice = txtUnitPrice.Text.Trim();
            string unitsOnOrder = txtUnitsOnOrder.Text.Trim();

            // Check required fields
            if (string.IsNullOrEmpty(fruitName) || string.IsNullOrEmpty(supplierID) || string.IsNullOrEmpty(typeFruitID))
            {
                MessageBox.Show("Please fill in all required information!", "Notification");
                return;
            }

            // SQL statement to add data
            string query = "INSERT INTO Fruit (FruitName, SupplierID, FruitTypeID, UnitPrice, StockRemaining) " +
                           "VALUES (@FruitName, @SupplierID, @FruitTypeID, @UnitPrice, @StockRemaining)";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Assign values ​​to parameters
                        command.Parameters.AddWithValue("@FruitID", fruitID);
                        command.Parameters.AddWithValue("@FruitName", fruitName);
                        command.Parameters.AddWithValue("@SupplierID", supplierID);
                        command.Parameters.AddWithValue("@FruitTypeID", typeFruitID);
                        command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        command.Parameters.AddWithValue("@StockRemaining", unitsOnOrder);


                        // Create a ListViewItem with multiple sub-items
                        // representing data for a fruit record
                        ListViewItem item = new ListViewItem(fruitID);
                        item.SubItems.Add(fruitName);
                        item.SubItems.Add(supplierID);
                        item.SubItems.Add(typeFruitID);
                        item.SubItems.Add(unitPrice);
                        item.SubItems.Add(unitsOnOrder);



                        // Execute the command
                        command.ExecuteNonQuery();
                        MessageBox.Show("Added fruit successfully!", "Notification");

                        LoadFruitDataToListView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding fruit: " + ex.Message, "Error");
                }
            }
        }

        private void UpdateFruit(string fruitID, string fruitName, decimal unitPrice, int unitsOnOrder)
        {
            if (lvFruit.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select the fruit to update!", "Notification");
                return;
            }

            // SQL statement to update data
            string query = @"
            UPDATE Fruit
            SET 
                FruitName = @FruitName,
                UnitPrice = @UnitPrice,
                StockRemaining = @StockRemaining
            WHERE 
                FruitID = @FruitID";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Assign values ​​to parameters
                        command.Parameters.AddWithValue("@FruitID", fruitID);
                        command.Parameters.AddWithValue("@FruitName", fruitName);
                        command.Parameters.AddWithValue("@UnitPrice", unitPrice);
                        command.Parameters.AddWithValue("@StockRemaining", unitsOnOrder);

                        // Execute command
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Reload data into ListView

                            LoadFruitDataToListView();
                            MessageBox.Show("Fruit record updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified FruitID.");
                        }



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while updating fruit: " + ex.Message, "Error");
                }
            }
        }

        private void DeleteFruit()
        {
            if (lvFruit.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select the fruit to delete!", "Notification");
                return;
            }

            // Get information from ListView
            string selectedFruitID = lvFruit.SelectedItems[0].Text;

            // SQL statement to delete data
            string query = "DELETE FROM Fruit WHERE FruitID = @FruitID";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Assign value to parameter
                        command.Parameters.AddWithValue("@FruitID", selectedFruitID);

                        // Execute command
                        command.ExecuteNonQuery();
                        MessageBox.Show("Fruit deleted successfully!", "Notification");

                        // Reload data into ListView
                        LoadFruitDataToListView();
                    }
                }
                catch (SqlException ex)
                {
                    // Check if the error is due to a foreign key constraint
                    if (ex.Number == 547) // SQL Server error number 547 indicates a foreign key constraint violation
                    {
                        MessageBox.Show(
                            "Cannot delete this fruit because it is referenced in other tables (e.g., Supplier or FruitType). " +
                            "Please update or delete the related data first.",
                            "Foreign Key Constraint",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        // Optional: Redirect to the related form (e.g., BillDetails or Supplier management)
                        frmBillDetails frmBillDetails = new frmBillDetails(); // Replace with your form class
                        this.Hide();
                        frmBillDetails.Show();
                    }
                    else
                    {
                        // Handle other SQL errors
                        MessageBox.Show(
                            "SQL Error while deleting fruit: " + ex.Message,
                            "SQL Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Handle non-SQL errors
                    MessageBox.Show(
                        "Error while deleting fruit: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    // Ensure the connection is always closed
                    connection.Close();
                }


            }
        }

        private void SearchFruits(string keyword)
        {
            // SQL search statement
            string query = "SELECT FruitID, FruitName, SupplierID, FruitTypeID, UnitPrice, UnitsOnOrder " +
                           "FROM Fruit " +
                           "WHERE FruitName LIKE @Keyword OR FruitID LIKE @Keyword";

            // Delete old data in ListView
            lvFruit.Items.Clear();

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
                            string fruitID = reader["FruitID"].ToString();
                            string fruitName = reader["FruitName"].ToString();
                            string supplierID = reader["SupplierID"].ToString();
                            string typeFruitID = reader["FruitTypeID"].ToString();
                            string unitPrice = reader["UnitPrice"].ToString();
                            string unitsOnOrder = reader["UnitsOnOrder"].ToString();

                            // Add data to ListView
                            ListViewItem item = new ListViewItem(fruitID);
                            item.SubItems.Add(fruitName);
                            item.SubItems.Add(supplierID);
                            item.SubItems.Add(typeFruitID);
                            item.SubItems.Add(unitPrice);
                            item.SubItems.Add(unitsOnOrder);

                            lvFruit.Items.Add(item);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while searching: " + ex.Message, "Error");
                }
            }
        }


        private void FrmFruitManage_Load(object sender, EventArgs e)
        {
            LoadFruitDataToListView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddFruit();
        }

        private void lvFruit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFruit.SelectedItems.Count > 0)
            {
                ListViewItem item = lvFruit.SelectedItems[0];
                txtFruitID.Text = item.SubItems[0].Text;
                txtFruitName.Text = item.SubItems[1].Text;
                txtSupplierID.Text = item.SubItems[2].Text;
                txtFruitTypeID.Text = item.SubItems[3].Text;
                txtUnitPrice.Text = item.SubItems[4].Text;
                txtUnitsOnOrder.Text = item.SubItems[5].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteFruit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter search keywords!", "Notification");
                return;
            }

            // Call funciton Search
            SearchFruits(keyword);
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            LoadFruitDataToListView();
            txtSearch.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            frmHome.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Example of calling the UpdateFruit method
            string fruitID = txtFruitID.Text; // Get FruitID from a TextBox
            string fruitName = txtFruitName.Text;    // Get FruitName from a TextBox
            decimal unitPrice = decimal.Parse(txtUnitPrice.Text); // Get UnitPrice from a TextBox
            int unitsOnOrder = int.Parse(txtUnitsOnOrder.Text);   // Get UnitsOnOrder from a TextBox

            // Call the update method
            UpdateFruit(fruitID, fruitName, unitPrice, unitsOnOrder);
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            UpdateStockRemaining();
            LoadFruitDataToListView();
        }
    }
}
