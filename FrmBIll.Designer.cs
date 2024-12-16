namespace AssignmentFinal
{
    partial class frmBIll
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
            txtBillID = new TextBox();
            dtpBillDate = new DateTimePicker();
            lvBill = new ListView();
            billID = new ColumnHeader();
            customerID = new ColumnHeader();
            employeeID = new ColumnHeader();
            billDate = new ColumnHeader();
            txtSearch = new TextBox();
            button1 = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnReset = new Button();
            button2 = new Button();
            txtCustomerID = new TextBox();
            txtEmployeeID = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 33);
            label1.TabIndex = 0;
            label1.Text = "BILL MANAGEMENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 76);
            label2.Name = "label2";
            label2.Size = new Size(48, 19);
            label2.TabIndex = 1;
            label2.Text = "Bill ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 126);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 1;
            label3.Text = "Customer ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(54, 176);
            label4.Name = "label4";
            label4.Size = new Size(90, 19);
            label4.TabIndex = 1;
            label4.Text = "Employee ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(54, 226);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 1;
            label5.Text = "Bill Date";
            // 
            // txtBillID
            // 
            txtBillID.Location = new Point(162, 76);
            txtBillID.Name = "txtBillID";
            txtBillID.Size = new Size(200, 27);
            txtBillID.TabIndex = 2;
            // 
            // dtpBillDate
            // 
            dtpBillDate.Location = new Point(162, 226);
            dtpBillDate.Name = "dtpBillDate";
            dtpBillDate.Size = new Size(200, 27);
            dtpBillDate.TabIndex = 3;
            // 
            // lvBill
            // 
            lvBill.Columns.AddRange(new ColumnHeader[] { billID, customerID, employeeID, billDate });
            lvBill.FullRowSelect = true;
            lvBill.GridLines = true;
            lvBill.Location = new Point(54, 321);
            lvBill.Name = "lvBill";
            lvBill.Size = new Size(392, 234);
            lvBill.TabIndex = 4;
            lvBill.UseCompatibleStateImageBehavior = false;
            lvBill.View = View.Details;
            lvBill.SelectedIndexChanged += lvBill_SelectedIndexChanged;
            // 
            // billID
            // 
            billID.Text = "Bill ID";
            // 
            // customerID
            // 
            customerID.Text = "Customer ID";
            customerID.Width = 100;
            // 
            // employeeID
            // 
            employeeID.Text = "Employee ID";
            employeeID.Width = 100;
            // 
            // billDate
            // 
            billDate.Text = "Bill Date";
            billDate.Width = 120;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(162, 274);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(200, 27);
            txtSearch.TabIndex = 2;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(371, 274);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = SystemColors.ControlDark;
            btnDelete.Location = new Point(371, 176);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = SystemColors.ControlDark;
            btnUpdate.Location = new Point(371, 126);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = SystemColors.ControlDark;
            btnAdd.Location = new Point(371, 76);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReset
            // 
            btnReset.AutoSize = true;
            btnReset.BackColor = SystemColors.ControlDark;
            btnReset.Location = new Point(371, 226);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 29);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(522, 525);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 6;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(162, 126);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(200, 27);
            txtCustomerID.TabIndex = 2;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(162, 176);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(200, 27);
            txtEmployeeID.TabIndex = 2;
            // 
            // frmBIll
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backround;
            ClientSize = new Size(609, 567);
            Controls.Add(button2);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(button1);
            Controls.Add(lvBill);
            Controls.Add(dtpBillDate);
            Controls.Add(txtSearch);
            Controls.Add(txtEmployeeID);
            Controls.Add(txtCustomerID);
            Controls.Add(txtBillID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmBIll";
            Text = "FrmBIll";
            Load += frmBIll_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBillID;
        private DateTimePicker dtpBillDate;
        private ListView lvBill;
        private ColumnHeader billID;
        private ColumnHeader customerID;
        private ColumnHeader employeeID;
        private ColumnHeader billDate;
        private TextBox txtSearch;
        private Button button1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnReset;
        private Button button2;
        private TextBox txtCustomerID;
        private TextBox txtEmployeeID;
    }
}