namespace AssignmentFinal
{
    partial class FrmFruitManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtFruitID = new TextBox();
            txtFruitName = new TextBox();
            txtSupplierID = new TextBox();
            txtFruitTypeID = new TextBox();
            txtUnitPrice = new TextBox();
            txtUnitsOnOrder = new TextBox();
            lvFruit = new ListView();
            fruitID = new ColumnHeader();
            fruitName = new ColumnHeader();
            supplierID = new ColumnHeader();
            fruitTypeID = new ColumnHeader();
            unitPrice = new ColumnHeader();
            stockRemaining = new ColumnHeader();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnResetSearch = new Button();
            btnBack = new Button();
            btnUpdateStock = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(312, 26);
            label1.Name = "label1";
            label1.Size = new Size(290, 33);
            label1.TabIndex = 0;
            label1.Text = "Fresh Fruit Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 79);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 1;
            label2.Text = "Fruit ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 128);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 2;
            label3.Text = "Fruit Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 177);
            label4.Name = "label4";
            label4.Size = new Size(79, 19);
            label4.TabIndex = 3;
            label4.Text = "Supplier ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 226);
            label5.Name = "label5";
            label5.Size = new Size(90, 19);
            label5.TabIndex = 4;
            label5.Text = "Fruit Type ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 275);
            label6.Name = "label6";
            label6.Size = new Size(72, 19);
            label6.TabIndex = 5;
            label6.Text = "Unit Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(87, 324);
            label7.Name = "label7";
            label7.Size = new Size(107, 19);
            label7.TabIndex = 6;
            label7.Text = "Units On Order";
            // 
            // txtFruitID
            // 
            txtFruitID.Location = new Point(212, 79);
            txtFruitID.Name = "txtFruitID";
            txtFruitID.Size = new Size(267, 27);
            txtFruitID.TabIndex = 7;
            // 
            // txtFruitName
            // 
            txtFruitName.Location = new Point(212, 128);
            txtFruitName.Name = "txtFruitName";
            txtFruitName.Size = new Size(267, 27);
            txtFruitName.TabIndex = 7;
            // 
            // txtSupplierID
            // 
            txtSupplierID.Location = new Point(212, 177);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(267, 27);
            txtSupplierID.TabIndex = 8;
            // 
            // txtFruitTypeID
            // 
            txtFruitTypeID.Location = new Point(212, 226);
            txtFruitTypeID.Name = "txtFruitTypeID";
            txtFruitTypeID.Size = new Size(267, 27);
            txtFruitTypeID.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(212, 275);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(267, 27);
            txtUnitPrice.TabIndex = 10;
            // 
            // txtUnitsOnOrder
            // 
            txtUnitsOnOrder.Location = new Point(212, 316);
            txtUnitsOnOrder.Name = "txtUnitsOnOrder";
            txtUnitsOnOrder.Size = new Size(267, 27);
            txtUnitsOnOrder.TabIndex = 11;
            // 
            // lvFruit
            // 
            lvFruit.Columns.AddRange(new ColumnHeader[] { fruitID, fruitName, supplierID, fruitTypeID, unitPrice, stockRemaining });
            lvFruit.FullRowSelect = true;
            lvFruit.GridLines = true;
            lvFruit.Location = new Point(94, 369);
            lvFruit.Name = "lvFruit";
            lvFruit.Size = new Size(684, 168);
            lvFruit.TabIndex = 12;
            lvFruit.UseCompatibleStateImageBehavior = false;
            lvFruit.View = View.Details;
            lvFruit.SelectedIndexChanged += lvFruit_SelectedIndexChanged;
            // 
            // fruitID
            // 
            fruitID.Text = "Fruid ID";
            fruitID.Width = 100;
            // 
            // fruitName
            // 
            fruitName.Text = "Fruit Name";
            fruitName.Width = 150;
            // 
            // supplierID
            // 
            supplierID.Text = "SupplierID";
            supplierID.Width = 100;
            // 
            // fruitTypeID
            // 
            fruitTypeID.Text = "FruitTypeID";
            fruitTypeID.Width = 100;
            // 
            // unitPrice
            // 
            unitPrice.Text = "Unit Price";
            unitPrice.Width = 100;
            // 
            // stockRemaining
            // 
            stockRemaining.Text = "Stock Remaining";
            stockRemaining.Width = 125;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(563, 88);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(563, 128);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(563, 216);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(697, 336);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 29);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(485, 336);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(206, 27);
            txtSearch.TabIndex = 17;
            // 
            // btnResetSearch
            // 
            btnResetSearch.AutoSize = true;
            btnResetSearch.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetSearch.Location = new Point(563, 270);
            btnResetSearch.Name = "btnResetSearch";
            btnResetSearch.Size = new Size(75, 29);
            btnResetSearch.TabIndex = 18;
            btnResetSearch.Text = "Reset";
            btnResetSearch.UseVisualStyleBackColor = true;
            btnResetSearch.Click += btnResetSearch_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(797, 478);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(69, 59);
            btnBack.TabIndex = 19;
            btnBack.Text = "Back to Home";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.AutoSize = true;
            btnUpdateStock.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStock.Location = new Point(563, 177);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(111, 29);
            btnUpdateStock.TabIndex = 20;
            btnUpdateStock.Text = "Update Stock";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // FrmFruitManage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.backround;
            ClientSize = new Size(878, 549);
            Controls.Add(btnUpdateStock);
            Controls.Add(btnBack);
            Controls.Add(btnResetSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lvFruit);
            Controls.Add(txtUnitsOnOrder);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtFruitTypeID);
            Controls.Add(txtSupplierID);
            Controls.Add(txtFruitName);
            Controls.Add(txtFruitID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmFruitManage";
            Text = "Fruit Management";
            Load += FrmFruitManage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtFruitID;
        private TextBox txtFruitName;
        private TextBox txtSupplierID;
        private TextBox txtFruitTypeID;
        private TextBox txtUnitPrice;
        private TextBox txtUnitsOnOrder;
        private ListView lvFruit;
        private ColumnHeader fruitID;
        private ColumnHeader fruitName;
        private ColumnHeader supplierID;
        private ColumnHeader fruitTypeID;
        private ColumnHeader unitPrice;
        private ColumnHeader stockRemaining;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnResetSearch;
        private Button btnBack;
        private Button btnUpdateStock;
    }
}