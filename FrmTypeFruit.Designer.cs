namespace AssignmentFinal
{
    partial class FrmTypeFruit
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
            txtFruitTypeID = new TextBox();
            txtTypeName = new TextBox();
            txtDescription = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lvViewTypeFruit = new ListView();
            fruitTypeID = new ColumnHeader();
            typeName = new ColumnHeader();
            description = new ColumnHeader();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnReset = new Button();
            btnBack = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 23);
            label1.Name = "label1";
            label1.Size = new Size(251, 29);
            label1.TabIndex = 0;
            label1.Text = "Fruit Type Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 109);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 1;
            label2.Text = "Fruit Type ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 159);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 2;
            label3.Text = "Type Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 209);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 3;
            label4.Text = "Description";
            label4.Click += label4_Click;
            // 
            // txtFruitTypeID
            // 
            txtFruitTypeID.Location = new Point(166, 106);
            txtFruitTypeID.Name = "txtFruitTypeID";
            txtFruitTypeID.Size = new Size(212, 27);
            txtFruitTypeID.TabIndex = 4;
            // 
            // txtTypeName
            // 
            txtTypeName.Location = new Point(166, 159);
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Size = new Size(212, 27);
            txtTypeName.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(166, 209);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(212, 27);
            txtDescription.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.BackColor = SystemColors.ButtonShadow;
            btnAdd.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(432, 111);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.AutoSize = true;
            btnUpdate.BackColor = SystemColors.ButtonShadow;
            btnUpdate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(432, 159);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.BackColor = SystemColors.ButtonShadow;
            btnDelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(432, 209);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lvViewTypeFruit
            // 
            lvViewTypeFruit.Columns.AddRange(new ColumnHeader[] { fruitTypeID, typeName, description });
            lvViewTypeFruit.FullRowSelect = true;
            lvViewTypeFruit.GridLines = true;
            lvViewTypeFruit.Location = new Point(60, 271);
            lvViewTypeFruit.Name = "lvViewTypeFruit";
            lvViewTypeFruit.Size = new Size(447, 150);
            lvViewTypeFruit.TabIndex = 10;
            lvViewTypeFruit.UseCompatibleStateImageBehavior = false;
            lvViewTypeFruit.View = View.Details;
            lvViewTypeFruit.SelectedIndexChanged += lvViewTypeFruit_SelectedIndexChanged;
            // 
            // fruitTypeID
            // 
            fruitTypeID.Text = "Fruit Type ID";
            fruitTypeID.Width = 120;
            // 
            // typeName
            // 
            typeName.Text = "Type Name";
            typeName.Width = 120;
            // 
            // description
            // 
            description.Text = "Description";
            description.Width = 150;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = true;
            btnSearch.BackColor = SystemColors.ButtonShadow;
            btnSearch.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(609, 64);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 29);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(382, 64);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(212, 27);
            txtSearch.TabIndex = 12;
            // 
            // btnReset
            // 
            btnReset.AutoSize = true;
            btnReset.BackColor = SystemColors.ButtonShadow;
            btnReset.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(609, 104);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 29);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.BackColor = SystemColors.ButtonShadow;
            btnBack.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(609, 392);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 29);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // FrmTypeFruit
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources.backround;
            ClientSize = new Size(760, 454);
            Controls.Add(btnReset);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(lvViewTypeFruit);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(txtTypeName);
            Controls.Add(txtFruitTypeID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmTypeFruit";
            Text = "FrmTypeFruit";
            Load += FrmTypeFruit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFruitTypeID;
        private TextBox txtTypeName;
        private TextBox txtDescription;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ListView lvViewTypeFruit;
        private ColumnHeader fruitTypeID;
        private ColumnHeader typeName;
        private ColumnHeader description;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnReset;
        private Button btnBack;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}