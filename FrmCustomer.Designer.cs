namespace AssignmentFinal
{
    partial class FrmCustomer
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
            lvViewCus = new ListView();
            customerID = new ColumnHeader();
            customerName = new ColumnHeader();
            phoneNumber = new ColumnHeader();
            gender = new ColumnHeader();
            city = new ColumnHeader();
            country = new ColumnHeader();
            label2 = new Label();
            txtCusName = new TextBox();
            label3 = new Label();
            labe1 = new Label();
            txtPhone = new TextBox();
            txtCity = new TextBox();
            btnDelete = new Button();
            button1 = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            txtGender = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtCountry = new TextBox();
            txtSearch = new TextBox();
            label1 = new Label();
            label6 = new Label();
            txtCusID = new TextBox();
            btnReset = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lvViewCus
            // 
            lvViewCus.Columns.AddRange(new ColumnHeader[] { customerID, customerName, phoneNumber, gender, city, country });
            lvViewCus.FullRowSelect = true;
            lvViewCus.GridLines = true;
            lvViewCus.Location = new Point(27, 408);
            lvViewCus.Margin = new Padding(3, 4, 3, 4);
            lvViewCus.Name = "lvViewCus";
            lvViewCus.Size = new Size(670, 269);
            lvViewCus.TabIndex = 0;
            lvViewCus.UseCompatibleStateImageBehavior = false;
            lvViewCus.View = View.Details;
            lvViewCus.SelectedIndexChanged += lvViewCus_SelectedIndexChanged;
            // 
            // customerID
            // 
            customerID.Text = "CustomerID";
            customerID.Width = 100;
            // 
            // customerName
            // 
            customerName.Text = "Customer Name";
            customerName.Width = 150;
            // 
            // phoneNumber
            // 
            phoneNumber.Text = "Phone Number";
            phoneNumber.Width = 150;
            // 
            // gender
            // 
            gender.DisplayIndex = 4;
            gender.Text = "Gender";
            // 
            // city
            // 
            city.DisplayIndex = 3;
            city.Text = "City";
            city.Width = 100;
            // 
            // country
            // 
            country.Text = "Country";
            country.Width = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 117);
            label2.Name = "label2";
            label2.Size = new Size(113, 19);
            label2.TabIndex = 1;
            label2.Text = "Customer Name";
            // 
            // txtCusName
            // 
            txtCusName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusName.Location = new Point(231, 117);
            txtCusName.Margin = new Padding(3, 4, 3, 4);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(278, 27);
            txtCusName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 168);
            label3.Name = "label3";
            label3.Size = new Size(104, 19);
            label3.TabIndex = 1;
            label3.Text = "Phone Number";
            // 
            // labe1
            // 
            labe1.AutoSize = true;
            labe1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labe1.Location = new Point(102, 219);
            labe1.Name = "labe1";
            labe1.Size = new Size(34, 19);
            labe1.TabIndex = 1;
            labe1.Text = "City";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(231, 168);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(278, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtCity
            // 
            txtCity.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.Location = new Point(231, 219);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(278, 27);
            txtCity.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.WhiteSmoke;
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(567, 219);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 43);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(567, 76);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(102, 43);
            button1.TabIndex = 3;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.WhiteSmoke;
            btnAdd.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(567, 144);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 43);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = Color.WhiteSmoke;
            btnSearch.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(635, 373);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(62, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtGender
            // 
            txtGender.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGender.Location = new Point(231, 270);
            txtGender.Margin = new Padding(3, 4, 3, 4);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(278, 27);
            txtGender.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(102, 270);
            label4.Name = "label4";
            label4.Size = new Size(56, 19);
            label4.TabIndex = 1;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(99, 321);
            label5.Name = "label5";
            label5.Size = new Size(59, 19);
            label5.TabIndex = 4;
            label5.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCountry.Location = new Point(231, 321);
            txtCountry.Margin = new Padding(3, 4, 3, 4);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(278, 27);
            txtCountry.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(351, 373);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(278, 27);
            txtSearch.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 33);
            label1.TabIndex = 7;
            label1.Text = "Customer Management";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(81, 66);
            label6.Name = "label6";
            label6.Size = new Size(89, 19);
            label6.TabIndex = 8;
            label6.Text = "Customer ID";
            // 
            // txtCusID
            // 
            txtCusID.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusID.Location = new Point(231, 66);
            txtCusID.Margin = new Padding(3, 4, 3, 4);
            txtCusID.Name = "txtCusID";
            txtCusID.Size = new Size(278, 27);
            txtCusID.TabIndex = 9;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.WhiteSmoke;
            btnReset.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(635, 332);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(62, 26);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(725, 625);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(68, 53);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back to home";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backround;
            ClientSize = new Size(851, 690);
            Controls.Add(btnBack);
            Controls.Add(btnReset);
            Controls.Add(txtCusID);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(txtCountry);
            Controls.Add(label5);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(txtGender);
            Controls.Add(txtCity);
            Controls.Add(txtPhone);
            Controls.Add(txtCusName);
            Controls.Add(label4);
            Controls.Add(labe1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lvViewCus);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCustomer";
            Text = "Customer Management";
            Load += FrmCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvViewCus;
        private ColumnHeader customerID;
        private ColumnHeader customerName;
        private ColumnHeader phoneNumber;
        private ColumnHeader city;
        private ColumnHeader gender;
        private ColumnHeader country;
        private Label label2;
        private TextBox txtCusName;
        private Label label3;
        private Label labe1;
        private TextBox txtPhone;
        private TextBox txtCity;
        private Button btnDelete;
        private Button button1;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox txtGender;
        private Label label4;
        private Label label5;
        private TextBox txtCountry;
        private TextBox txtSearch;
        private Label label1;
        private Label label6;
        private TextBox txtCusID;
        private Button btnReset;
        private Button btnBack;
    }
}