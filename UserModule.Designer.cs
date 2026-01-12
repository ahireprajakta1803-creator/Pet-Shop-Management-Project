
namespace Pet_Shop_Management_System1
{
    partial class UserModule
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModule));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtDob = new System.Windows.Forms.DateTimePicker();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lbluid = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 10);
            this.panel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(705, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 35);
            this.btnClose.TabIndex = 9;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(581, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 52);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(432, 367);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 52);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(281, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 52);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtDob
            // 
            this.dtDob.Location = new System.Drawing.Point(281, 265);
            this.dtDob.Name = "dtDob";
            this.dtDob.Size = new System.Drawing.Size(425, 28);
            this.dtDob.TabIndex = 4;
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Administrator",
            "Cashier",
            "Employee"});
            this.cbRole.Location = new System.Drawing.Point(281, 220);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(425, 29);
            this.cbRole.TabIndex = 3;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // lbluid
            // 
            this.lbluid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbluid.AutoSize = true;
            this.lbluid.Location = new System.Drawing.Point(14, 368);
            this.lbluid.Name = "lbluid";
            this.lbluid.Size = new System.Drawing.Size(35, 21);
            this.lbluid.TabIndex = 32;
            this.lbluid.Text = "uid";
            this.lbluid.Visible = false;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(281, 311);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(425, 28);
            this.txtPass.TabIndex = 5;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(14, 321);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(98, 21);
            this.lblPass.TabIndex = 30;
            this.lblPass.Text = "Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Date of Birth :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Role :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(281, 174);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(425, 28);
            this.txtPhone.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Phone :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(281, 128);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(425, 28);
            this.txtAddress.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 24;
            this.label3.Text = "Address :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(281, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(425, 28);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 34);
            this.label1.TabIndex = 21;
            this.label1.Text = "User Registration";
            // 
            // UserModule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(748, 445);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtDob);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.lbluid);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserModule";
            this.Load += new System.EventHandler(this.UserModule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.DateTimePicker dtDob;
        public System.Windows.Forms.ComboBox cbRole;
        public System.Windows.Forms.Label lbluid;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtName;
    }
}