namespace AssignmentFinal
{
    partial class frmBillDetails
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
            label8 = new Label();
            txtBillDetailsID = new TextBox();
            txtBillID = new TextBox();
            txtFruitID = new TextBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtReset = new Button();
            btnSearch = new Button();
            lvViewBillDetails = new ListView();
            billDetailsID = new ColumnHeader();
            billID = new ColumnHeader();
            fruitID = new ColumnHeader();
            quantity = new ColumnHeader();
            UnitPrice = new ColumnHeader();
            Subtotal = new ColumnHeader();
            txtSearch = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.Size = new Size(291, 33);
            label1.TabIndex = 0;
            label1.Text = "Bill Details Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 94);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 1;
            label2.Text = "Bill Details ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 134);
            label3.Name = "label3";
            label3.Size = new Size(48, 19);
            label3.TabIndex = 1;
            label3.Text = "Bill ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 174);
            label4.Name = "label4";
            label4.Size = new Size(52, 19);
            label4.TabIndex = 1;
            label4.Text = "FruitID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 214);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 1;
            label5.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(38, 254);
            label8.Name = "label8";
            label8.Size = new Size(68, 19);
            label8.TabIndex = 1;
            label8.Text = "UnitPrice";
            // 
            // txtBillDetailsID
            // 
            txtBillDetailsID.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBillDetailsID.Location = new Point(142, 91);
            txtBillDetailsID.Name = "txtBillDetailsID";
            txtBillDetailsID.Size = new Size(187, 27);
            txtBillDetailsID.TabIndex = 2;
            // 
            // txtBillID
            // 
            txtBillID.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBillID.Location = new Point(142, 134);
            txtBillID.Name = "txtBillID";
            txtBillID.Size = new Size(187, 27);
            txtBillID.TabIndex = 2;
            // 
            // txtFruitID
            // 
            txtFruitID.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFruitID.Location = new Point(142, 174);
            txtFruitID.Name = "txtFruitID";
            txtFruitID.Size = new Size(187, 27);
            txtFruitID.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(142, 214);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(187, 27);
            txtQuantity.TabIndex = 2;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitPrice.Location = new Point(142, 254);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(187, 27);
            txtUnitPrice.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = SystemColors.ControlDark;
            btnAdd.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(373, 90);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = SystemColors.ControlDark;
            btnUpdate.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(373, 134);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = SystemColors.ControlDark;
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(373, 174);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtReset
            // 
            txtReset.AutoSize = true;
            txtReset.BackColor = SystemColors.ControlDark;
            txtReset.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReset.Location = new Point(373, 214);
            txtReset.Name = "txtReset";
            txtReset.Size = new Size(75, 29);
            txtReset.TabIndex = 3;
            txtReset.Text = "Reset";
            txtReset.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = SystemColors.ControlDark;
            btnSearch.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(373, 287);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lvViewBillDetails
            // 
            lvViewBillDetails.BackColor = SystemColors.Window;
            lvViewBillDetails.Columns.AddRange(new ColumnHeader[] { billDetailsID, billID, fruitID, quantity, UnitPrice, Subtotal });
            lvViewBillDetails.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvViewBillDetails.FullRowSelect = true;
            lvViewBillDetails.GridLines = true;
            lvViewBillDetails.Location = new Point(38, 332);
            lvViewBillDetails.Name = "lvViewBillDetails";
            lvViewBillDetails.Size = new Size(493, 132);
            lvViewBillDetails.TabIndex = 4;
            lvViewBillDetails.UseCompatibleStateImageBehavior = false;
            lvViewBillDetails.View = View.Details;
            lvViewBillDetails.SelectedIndexChanged += lvViewBillDetails_SelectedIndexChanged_1;
            // 
            // billDetailsID
            // 
            billDetailsID.Text = "Bill Details ID";
            billDetailsID.Width = 120;
            // 
            // billID
            // 
            billID.Text = "Bill ID";
            billID.Width = 70;
            // 
            // fruitID
            // 
            fruitID.Text = "Fruit ID";
            // 
            // quantity
            // 
            quantity.Text = "Quantity";
            quantity.Width = 100;
            // 
            // UnitPrice
            // 
            UnitPrice.Text = "Unit Price";
            // 
            // Subtotal
            // 
            Subtotal.Text = "Subtotal";
            Subtotal.Width = 80;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(142, 287);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(187, 27);
            txtSearch.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.BackColor = SystemColors.ControlDark;
            btnBack.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(536, 512);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frmBillDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.backround;
            ClientSize = new Size(612, 544);
            Controls.Add(btnBack);
            Controls.Add(txtSearch);
            Controls.Add(lvViewBillDetails);
            Controls.Add(btnSearch);
            Controls.Add(txtReset);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtFruitID);
            Controls.Add(txtQuantity);
            Controls.Add(txtBillID);
            Controls.Add(txtBillDetailsID);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmBillDetails";
            Text = "frmBillDetails";
            Load += frmBillDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private TextBox txtBillDetailsID;
        private TextBox txtBillID;
        private TextBox txtFruitID;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button txtReset;
        private Button btnSearch;
        private ListView lvViewBillDetails;
        private ColumnHeader billDetailsID;
        private ColumnHeader billID;
        private ColumnHeader fruitID;
        private ColumnHeader quantity;
        private ColumnHeader UnitPrice;
        private ColumnHeader Subtotal;
        private TextBox txtSearch;
        private Button btnBack;
    }
}