namespace AssignmentFinal
{
    partial class frmSupplier
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
            txtSupplierID = new TextBox();
            txtCompanyName = new TextBox();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtCity = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            btnBack = new Button();
            txtSearch = new TextBox();
            lvSupplier = new ListView();
            supplierID = new ColumnHeader();
            companyName = new ColumnHeader();
            address = new ColumnHeader();
            phoneNumber = new ColumnHeader();
            city = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 11);
            label1.Name = "label1";
            label1.Size = new Size(264, 33);
            label1.TabIndex = 0;
            label1.Text = "Supplier Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 110);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 1;
            label2.Text = "Supplier ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 181);
            label3.Name = "label3";
            label3.Size = new Size(111, 19);
            label3.TabIndex = 1;
            label3.Text = "Company Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 252);
            label4.Name = "label4";
            label4.Size = new Size(61, 19);
            label4.TabIndex = 1;
            label4.Text = "Address";
            label4.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 323);
            label5.Name = "label5";
            label5.Size = new Size(104, 19);
            label5.TabIndex = 1;
            label5.Text = "Phone Number";
            label5.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(55, 394);
            label6.Name = "label6";
            label6.Size = new Size(34, 19);
            label6.TabIndex = 1;
            label6.Text = "City";
            label6.Click += label3_Click;
            // 
            // txtSupplierID
            // 
            txtSupplierID.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSupplierID.Location = new Point(224, 110);
            txtSupplierID.Margin = new Padding(3, 4, 3, 4);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(234, 27);
            txtSupplierID.TabIndex = 2;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCompanyName.Location = new Point(224, 181);
            txtCompanyName.Margin = new Padding(3, 4, 3, 4);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(234, 27);
            txtCompanyName.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(224, 252);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(234, 27);
            txtAddress.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(224, 323);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(234, 27);
            txtPhoneNumber.TabIndex = 2;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.Location = new Point(224, 394);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(234, 27);
            txtCity.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = SystemColors.ControlDarkDark;
            btnAdd.Location = new Point(507, 110);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 32);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = SystemColors.ControlDarkDark;
            btnUpdate.Location = new Point(507, 181);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 32);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = SystemColors.ControlDarkDark;
            btnDelete.Location = new Point(507, 250);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 32);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.AutoSize = true;
            btnReset.BackColor = SystemColors.ControlDarkDark;
            btnReset.Location = new Point(507, 323);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(86, 32);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.BackColor = SystemColors.ControlDarkDark;
            btnBack.Location = new Point(671, 611);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 32);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(224, 451);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(234, 27);
            txtSearch.TabIndex = 2;
            // 
            // lvSupplier
            // 
            lvSupplier.Columns.AddRange(new ColumnHeader[] { supplierID, companyName, address, phoneNumber, city });
            lvSupplier.FullRowSelect = true;
            lvSupplier.GridLines = true;
            lvSupplier.Location = new Point(88, 490);
            lvSupplier.Name = "lvSupplier";
            lvSupplier.Size = new Size(505, 154);
            lvSupplier.TabIndex = 4;
            lvSupplier.UseCompatibleStateImageBehavior = false;
            lvSupplier.View = View.Details;
            lvSupplier.SelectedIndexChanged += lvSupplier_SelectedIndexChanged;
            // 
            // supplierID
            // 
            supplierID.Text = "Supplier ID";
            supplierID.Width = 100;
            // 
            // companyName
            // 
            companyName.Text = "Company Name";
            companyName.Width = 120;
            // 
            // address
            // 
            address.Text = "Address";
            address.Width = 100;
            // 
            // phoneNumber
            // 
            phoneNumber.Text = "Phone Number";
            phoneNumber.Width = 120;
            // 
            // city
            // 
            city.Text = "City";
            // 
            // frmSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources.backround;
            ClientSize = new Size(769, 656);
            Controls.Add(lvSupplier);
            Controls.Add(btnBack);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSearch);
            Controls.Add(txtCity);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtCompanyName);
            Controls.Add(txtSupplierID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmSupplier";
            Text = "frmSupplier";
            Load += frmSupplier_Load;
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
        private TextBox txtSupplierID;
        private TextBox txtCompanyName;
        private TextBox txtAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtCity;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReset;
        private Button btnBack;
        private TextBox txtSearch;
        private ListView lvSupplier;
        private ColumnHeader supplierID;
        private ColumnHeader companyName;
        private ColumnHeader address;
        private ColumnHeader phoneNumber;
        private ColumnHeader city;
    }
}