namespace AssignmentFinal
{
    partial class FrmEmployee
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
            txtEmployeeID = new TextBox();
            txtEmployeeName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lvEmployee = new ListView();
            employeeID = new ColumnHeader();
            employeeName = new ColumnHeader();
            phoneNumber = new ColumnHeader();
            address = new ColumnHeader();
            btnReset = new Button();
            btnBack = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 24);
            label1.Name = "label1";
            label1.Size = new Size(297, 33);
            label1.TabIndex = 0;
            label1.Text = "Employeee Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 111);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 1;
            label2.Text = "EmployeeID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 159);
            label3.Name = "label3";
            label3.Size = new Size(114, 19);
            label3.TabIndex = 2;
            label3.Text = "Employee Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 208);
            label4.Name = "label4";
            label4.Size = new Size(104, 19);
            label4.TabIndex = 2;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(157, 262);
            label5.Name = "label5";
            label5.Size = new Size(61, 19);
            label5.TabIndex = 2;
            label5.Text = "Address";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(240, 111);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(228, 27);
            txtEmployeeID.TabIndex = 3;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(240, 159);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(228, 27);
            txtEmployeeName.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(240, 210);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(228, 27);
            txtPhoneNumber.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(240, 259);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(228, 27);
            txtAddress.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(489, 109);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(488, 157);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(489, 208);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lvEmployee
            // 
            lvEmployee.Columns.AddRange(new ColumnHeader[] { employeeID, employeeName, phoneNumber, address });
            lvEmployee.FullRowSelect = true;
            lvEmployee.GridLines = true;
            lvEmployee.Location = new Point(67, 346);
            lvEmployee.Name = "lvEmployee";
            lvEmployee.Size = new Size(532, 135);
            lvEmployee.TabIndex = 5;
            lvEmployee.UseCompatibleStateImageBehavior = false;
            lvEmployee.View = View.Details;
            lvEmployee.SelectedIndexChanged += lvEmployee_SelectedIndexChanged;
            // 
            // employeeID
            // 
            employeeID.Text = "Employee ID";
            employeeID.Width = 100;
            // 
            // employeeName
            // 
            employeeName.Text = "Employee Name";
            employeeName.Width = 150;
            // 
            // phoneNumber
            // 
            phoneNumber.Text = "Phone Number";
            phoneNumber.Width = 125;
            // 
            // address
            // 
            address.Text = "Address";
            address.Width = 150;
            // 
            // btnReset
            // 
            btnReset.AutoSize = true;
            btnReset.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(488, 257);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 29);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(638, 452);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(114, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back to Home";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(240, 304);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(228, 27);
            txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(488, 304);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search ";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backround;
            ClientSize = new Size(749, 517);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(btnReset);
            Controls.Add(lvEmployee);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmployeeID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmEmployee";
            Text = "FrmEmployee";
            Load += FrmEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtEmployeeID;
        private TextBox txtEmployeeName;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ListView lvEmployee;
        private Button btnReset;
        private Button btnBack;
        private TextBox txtSearch;
        private ColumnHeader employeeID;
        private ColumnHeader employeeName;
        private ColumnHeader phoneNumber;
        private ColumnHeader address;
        private Button btnSearch;
    }
}