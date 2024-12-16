namespace AssignmentFinal
{
    partial class FrmLogin
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
            groupBox1 = new GroupBox();
            btnExit = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            chkViewPass = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(chkViewPass);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(22, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 241);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login to the home page";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(145, 191);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(70, 31);
            btnExit.TabIndex = 5;
            btnExit.Text = "Close";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(286, 191);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(70, 31);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ok";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Enter;
            btnLogin.Enter += btnLogin_Enter;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(109, 125);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(216, 27);
            txtPassword.TabIndex = 3;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(109, 70);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(216, 27);
            txtUserName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 128);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 73);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 0;
            label1.Text = "User Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Calibri", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(100, 9);
            label3.Name = "label3";
            label3.Size = new Size(221, 58);
            label3.TabIndex = 1;
            label3.Text = "Wellcome";
            // 
            // chkViewPass
            // 
            chkViewPass.AutoSize = true;
            chkViewPass.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkViewPass.Location = new Point(109, 158);
            chkViewPass.Name = "chkViewPass";
            chkViewPass.Size = new Size(126, 23);
            chkViewPass.TabIndex = 6;
            chkViewPass.Text = "View Password";
            chkViewPass.UseVisualStyleBackColor = true;
            chkViewPass.CheckedChanged += chkViewPass_CheckedChanged;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backround;
            ClientSize = new Size(426, 403);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnExit;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label2;
        private Label label1;
        private Label label3;
        private CheckBox chkViewPass;
    }
}