namespace WeatherForcastingSystem
{
    partial class frmAdminControlls
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
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbUsername
            // 
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.Location = new System.Drawing.Point(69, 35);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(161, 21);
            this.cmbUsername.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(29, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(34, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Users";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(69, 113);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(161, 23);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(69, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete User";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add a User here.";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 204);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(12, 230);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(53, 13);
            this.lblpassword.TabIndex = 7;
            this.lblpassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(73, 201);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(73, 227);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(73, 253);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 23);
            this.btnApply.TabIndex = 10;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(226, 253);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 11;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.Location = new System.Drawing.Point(195, 200);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(129, 17);
            this.cbAdmin.TabIndex = 12;
            this.cbAdmin.Text = "Give admin privileges.";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // frmAdminControlls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 296);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cmbUsername);
            this.Name = "frmAdminControlls";
            this.Text = "Admin Controlles";
            this.Load += new System.EventHandler(this.frmAdminControlls_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.CheckBox cbAdmin;
    }
}