namespace AssignmentFinal
{
    partial class frmRevenueStatistics
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
            dtpDateTime = new DateTimePicker();
            label1 = new Label();
            btnSearch = new Button();
            btnReset = new Button();
            txtSearch = new TextBox();
            lvViewStatistics = new ListView();
            billID = new ColumnHeader();
            billDate = new ColumnHeader();
            totalQuantity = new ColumnHeader();
            averageUnitPrice = new ColumnHeader();
            totalRevenue = new ColumnHeader();
            btnBack = new Button();
            SuspendLayout();
            // 
            // dtpDateTime
            // 
            dtpDateTime.Location = new Point(85, 46);
            dtpDateTime.Name = "dtpDateTime";
            dtpDateTime.Size = new Size(200, 23);
            dtpDateTime.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 46);
            label1.Name = "label1";
            label1.Size = new Size(40, 19);
            label1.TabIndex = 1;
            label1.Text = "Date";
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(303, 44);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReset
            // 
            btnReset.AutoSize = true;
            btnReset.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(303, 92);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 29);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(87, 92);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(198, 23);
            txtSearch.TabIndex = 3;
            // 
            // lvViewStatistics
            // 
            lvViewStatistics.Columns.AddRange(new ColumnHeader[] { billID, billDate, totalQuantity, averageUnitPrice, totalRevenue });
            lvViewStatistics.Location = new Point(39, 185);
            lvViewStatistics.Name = "lvViewStatistics";
            lvViewStatistics.Size = new Size(667, 208);
            lvViewStatistics.TabIndex = 4;
            lvViewStatistics.UseCompatibleStateImageBehavior = false;
            lvViewStatistics.View = View.Details;
            // 
            // billID
            // 
            billID.Text = "Bill ID";
            billID.Width = 100;
            // 
            // billDate
            // 
            billDate.Text = "Bill Date";
            billDate.Width = 150;
            // 
            // totalQuantity
            // 
            totalQuantity.Text = "Total Quantity";
            totalQuantity.Width = 150;
            // 
            // averageUnitPrice
            // 
            averageUnitPrice.Text = "Average UnitPrice";
            averageUnitPrice.Width = 150;
            // 
            // totalRevenue
            // 
            totalRevenue.Text = "Total Revenue";
            totalRevenue.Width = 150;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(713, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 29);
            btnBack.TabIndex = 5;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmRevenueStatistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(lvViewStatistics);
            Controls.Add(txtSearch);
            Controls.Add(btnReset);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(dtpDateTime);
            Name = "frmRevenueStatistics";
            Text = "frmRevenueStatistics";
            Load += frmRevenueStatistics_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDateTime;
        private Label label1;
        private Button btnSearch;
        private Button btnReset;
        private TextBox txtSearch;
        private ListView lvViewStatistics;
        private ColumnHeader billID;
        private ColumnHeader billDate;
        private ColumnHeader totalQuantity;
        private ColumnHeader averageUnitPrice;
        private ColumnHeader totalRevenue;
        private Button btnBack;
    }
}