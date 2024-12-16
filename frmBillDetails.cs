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
    public partial class frmBillDetails : Form
    {
        public frmBillDetails()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome fromHome = new FrmHome();
            fromHome.Show();
            this.Hide();
        }

        private void frmBillDetails_Load(object sender, EventArgs e)
        {
            LoadBillDetails();
        }

        private void LoadBillDetails()
        {
            string query = "SELECT BillDetailsID, BillID, FruitID, Quantity, UnitPrice, SubTotal FROM BillDetails";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Delete old data in ListView
                    lvViewBillDetails.Items.Clear();

                    // Read data from database and add to ListView
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["BillDetailsID"].ToString());
                        item.SubItems.Add(reader["BillID"].ToString());
                        item.SubItems.Add(reader["FruitID"].ToString());
                        item.SubItems.Add(reader["Quantity"].ToString());
                        item.SubItems.Add(reader["UnitPrice"].ToString());
                        item.SubItems.Add(reader["SubTotal"].ToString()); // Display SubTotal

                        lvViewBillDetails.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading invoice detail data: " + ex.Message);
                }
            }
        }


        private void AddBillDetail(int billID, int fruitID, int quantity, decimal unitPrice)
        {
            string query = "INSERT INTO BillDetails (BillID, FruitID, Quantity, UnitPrice) " +
                "VALUES (@BillID, @FruitID, @Quantity, @UnitPrice)";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BillID", billID);
                    cmd.Parameters.AddWithValue("@FruitID", fruitID);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Invoice details added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding invoice details:" + ex.Message);
                }
            }
        }

        private void UpdateBillDetail(int billDetailsID, int billID, int fruitID, int quantity, decimal unitPrice)
        {
            string query = "UPDATE BillDetails SET BillID = @BillID, FruitID = @FruitID, Quantity = @Quantity, UnitPrice = @UnitPrice WHERE BillDetailsID = @BillDetailsID";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BillDetailsID", billDetailsID);
                    cmd.Parameters.AddWithValue("@BillID", billID);
                    cmd.Parameters.AddWithValue("@FruitID", fruitID);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Invoice details updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating invoice details: " + ex.Message);
                }
            }
        }

        private void DeleteBillDetail(int billDetailsID)
        {
            string query = "DELETE FROM BillDetails WHERE BillDetailsID = @BillDetailsID";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BillDetailsID", billDetailsID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Invoice details deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when deleting invoice details: " + ex.Message);
                }
            }
        }

        private void SearchBillDetails(string searchKeyword)
        {
            // Delete old data in ListView
            lvViewBillDetails.Items.Clear();

            // Query string to search for data
            string query = "SELECT BillDetailsID, BillID, FruitID, Quantity, UnitPrice FROM BillDetails WHERE BillID LIKE @search OR FruitID LIKE @search OR Quantity LIKE @search";

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchKeyword + "%");

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Read data and add to ListView
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["BillDetailsID"].ToString());
                        item.SubItems.Add(reader["BillID"].ToString());
                        item.SubItems.Add(reader["FruitID"].ToString());
                        item.SubItems.Add(reader["Quantity"].ToString());
                        item.SubItems.Add(reader["UnitPrice"].ToString());

                        lvViewBillDetails.Items.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching for invoice details: " + ex.Message);
                }
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Suppose you have TextBoxes or ComboBoxes to enter values
            int billID = int.Parse(txtBillID.Text);
            int fruitID = int.Parse(txtFruitID.Text);
            int quantity = int.Parse(txtQuantity.Text);
            decimal unitPrice = decimal.Parse(txtUnitPrice.Text);

            AddBillDetail(billID, fruitID, quantity, unitPrice);
            LoadBillDetails(); // Reload data into ListView
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Suppose you have TextBoxes or ComboBoxes to enter values
            int billDetailsID = int.Parse(txtBillDetailsID.Text);
            int billID = int.Parse(txtBillID.Text);
            int fruitID = int.Parse(txtFruitID.Text);
            int quantity = int.Parse(txtQuantity.Text);
            decimal unitPrice = decimal.Parse(txtUnitPrice.Text);

            UpdateBillDetail(billDetailsID, billID, fruitID, quantity, unitPrice);
            LoadBillDetails(); // Reload data into ListView
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get BillDetailsID from selected user
            int billDetailsID = int.Parse(txtBillDetailsID.Text);

            DeleteBillDetail(billDetailsID);
            LoadBillDetails(); // Reload data into ListView
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchKeyword))
            {
                SearchBillDetails(searchKeyword); // Call the search function
            }
            else
            {
                MessageBox.Show("Please enter search keywords.");
            }
        }

        private void lvViewBillDetails_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lvViewBillDetails.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvViewBillDetails.SelectedItems[0]; // Get the selected row

                // Display data on TextBoxes
                txtBillDetailsID.Text = selectedItem.SubItems[0].Text; // BillDetailsID
                txtBillID.Text = selectedItem.SubItems[1].Text;        // BillID
                txtFruitID.Text = selectedItem.SubItems[2].Text;       // FruitID
                txtQuantity.Text = selectedItem.SubItems[3].Text;      // Quantity
                txtUnitPrice.Text = selectedItem.SubItems[4].Text;     // UnitPrice
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            // Check if there is a valid IDShoes and Quantity
            if (!string.IsNullOrEmpty(txtFruitID.Text) && int.TryParse(txtQuantity.Text, out int quantity) && quantity > 0)
            {
                // Get price from SHOES table
                string pricesQuery = "SELECT UnitPrice FROM BillDetails WHERE FruitID = @FruitID";
                DatabaseConnection db = new DatabaseConnection();

                using (SqlConnection conn = new DatabaseConnection().GetConnection())
                {
                    SqlCommand command = new SqlCommand(pricesQuery, conn);
                    command.Parameters.AddWithValue("@FruitID", txtFruitID.Text);

                    try
                    {
                        conn.Open();
                        object result = command.ExecuteScalar(); // Returns the price of the product

                        if (result != null)
                        {
                            decimal prices = Convert.ToDecimal(result); // Product price from SHOES table
                            decimal totalPrices = prices * quantity; // Calculate total price

                            // Hiển thị TotalPrices vào TextBox
                            txtUnitPrice.Text = totalPrices.ToString("0.00");
                        }
                        else
                        {
                            MessageBox.Show("No Fruit found with this ID.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                // If the quantity is not entered correctly or there is no IDShoes
                txtFruitID.Clear();
            }
        }
    }
}
