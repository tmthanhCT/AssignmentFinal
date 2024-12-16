namespace AssignmentFinal
{
    partial class FrmHome
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
            button6 = new Button();
            btnCusManage = new Button();
            btnEmployeeManage = new Button();
            btnFruitManage = new Button();
            btnFruitTypeManage = new Button();
            btnBillManage = new Button();
            btnBillDetailsManage = new Button();
            btnSupplierManage = new Button();
            pictureBox1 = new PictureBox();
            btnRevenueManagement = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Calibri", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(115, 25);
            label1.Name = "label1";
            label1.Size = new Size(563, 53);
            label1.TabIndex = 0;
            label1.Text = "Fresh Fruit store management";
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.BackColor = Color.Transparent;
            button6.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ControlText;
            button6.Location = new Point(635, 375);
            button6.Name = "button6";
            button6.Size = new Size(107, 39);
            button6.TabIndex = 7;
            button6.Text = "Back to Login";
            button6.UseVisualStyleBackColor = false;
            button6.Click += btnBackToLogin_Click_1;
            // 
            // btnCusManage
            // 
            btnCusManage.AutoSize = true;
            btnCusManage.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCusManage.Location = new Point(64, 95);
            btnCusManage.Name = "btnCusManage";
            btnCusManage.Size = new Size(171, 29);
            btnCusManage.TabIndex = 8;
            btnCusManage.Text = "Customer Management";
            btnCusManage.UseVisualStyleBackColor = true;
            btnCusManage.Click += btnCusManage_Click;
            // 
            // btnEmployeeManage
            // 
            btnEmployeeManage.AutoSize = true;
            btnEmployeeManage.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmployeeManage.Location = new Point(64, 230);
            btnEmployeeManage.Name = "btnEmployeeManage";
            btnEmployeeManage.Size = new Size(172, 29);
            btnEmployeeManage.TabIndex = 9;
            btnEmployeeManage.Text = "Employee Management";
            btnEmployeeManage.UseVisualStyleBackColor = true;
            btnEmployeeManage.Click += btnEmployeeManage_Click;
            // 
            // btnFruitManage
            // 
            btnFruitManage.AutoSize = true;
            btnFruitManage.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFruitManage.Location = new Point(64, 140);
            btnFruitManage.Name = "btnFruitManage";
            btnFruitManage.Size = new Size(171, 29);
            btnFruitManage.TabIndex = 10;
            btnFruitManage.Text = "Fruit Management";
            btnFruitManage.UseVisualStyleBackColor = true;
            btnFruitManage.Click += btnFruitManage_Click;
            // 
            // btnFruitTypeManage
            // 
            btnFruitTypeManage.AutoSize = true;
            btnFruitTypeManage.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFruitTypeManage.Location = new Point(64, 185);
            btnFruitTypeManage.Name = "btnFruitTypeManage";
            btnFruitTypeManage.Size = new Size(172, 29);
            btnFruitTypeManage.TabIndex = 11;
            btnFruitTypeManage.Text = "Fruit Type Management";
            btnFruitTypeManage.UseVisualStyleBackColor = true;
            btnFruitTypeManage.Click += btnFruitTypeManage_Click;
            // 
            // btnBillManage
            // 
            btnBillManage.AutoSize = true;
            btnBillManage.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBillManage.Location = new Point(64, 275);
            btnBillManage.Name = "btnBillManage";
            btnBillManage.Size = new Size(171, 29);
            btnBillManage.TabIndex = 12;
            btnBillManage.Text = "Bill Management";
            btnBillManage.UseVisualStyleBackColor = true;
            btnBillManage.Click += btnBillManage_Click;
            // 
            // btnBillDetailsManage
            // 
            btnBillDetailsManage.AutoSize = true;
            btnBillDetailsManage.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBillDetailsManage.Location = new Point(64, 320);
            btnBillDetailsManage.Name = "btnBillDetailsManage";
            btnBillDetailsManage.Size = new Size(176, 29);
            btnBillDetailsManage.TabIndex = 13;
            btnBillDetailsManage.Text = "BillDetails Management";
            btnBillDetailsManage.UseVisualStyleBackColor = true;
            btnBillDetailsManage.Click += btnBillDetails_Click;
            // 
            // btnSupplierManage
            // 
            btnSupplierManage.AutoSize = true;
            btnSupplierManage.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSupplierManage.Location = new Point(64, 365);
            btnSupplierManage.Name = "btnSupplierManage";
            btnSupplierManage.Size = new Size(171, 29);
            btnSupplierManage.TabIndex = 14;
            btnSupplierManage.Text = "Supplier Management";
            btnSupplierManage.UseVisualStyleBackColor = true;
            btnSupplierManage.Click += btnSupplierManage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.trai_cay_giau_canxi1;
            pictureBox1.Location = new Point(458, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 223);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnRevenueManagement
            // 
            btnRevenueManagement.AutoSize = true;
            btnRevenueManagement.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRevenueManagement.Location = new Point(64, 410);
            btnRevenueManagement.Name = "btnRevenueManagement";
            btnRevenueManagement.Size = new Size(171, 29);
            btnRevenueManagement.TabIndex = 14;
            btnRevenueManagement.Text = "Revenue Management";
            btnRevenueManagement.UseVisualStyleBackColor = true;
            btnRevenueManagement.Click += btnRevenueManagement_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.backround;
            ClientSize = new Size(773, 470);
            Controls.Add(pictureBox1);
            Controls.Add(btnRevenueManagement);
            Controls.Add(btnSupplierManage);
            Controls.Add(btnBillDetailsManage);
            Controls.Add(btnBillManage);
            Controls.Add(btnFruitTypeManage);
            Controls.Add(btnFruitManage);
            Controls.Add(btnEmployeeManage);
            Controls.Add(btnCusManage);
            Controls.Add(button6);
            Controls.Add(label1);
            Name = "FrmHome";
            Text = "Home";
            Load += FrmHome_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button6;
        private Button btnCusManage;
        private Button btnEmployeeManage;
        private Button btnFruitManage;
        private Button btnFruitTypeManage;
        private Button btnBillManage;
        private Button btnBillDetailsManage;
        private Button btnSupplierManage;
        private PictureBox pictureBox1;
        private Button btnRevenueManagement;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}