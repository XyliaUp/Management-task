namespace TMS.Pages
{
    partial class UpdateUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.rbDeactivated = new System.Windows.Forms.RadioButton();
			this.rbActivated = new System.Windows.Forms.RadioButton();
			this.rbAll = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbSurname = new System.Windows.Forms.TextBox();
			this.cbActivated = new System.Windows.Forms.ComboBox();
			this.tbEmail = new System.Windows.Forms.TextBox();
			this.cbAdmin = new System.Windows.Forms.ComboBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbIDentityNo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lblUserID = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dgvUser = new System.Windows.Forms.DataGridView();
			this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserIDentityNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserActivated = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblIdentityNo = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblSurname = new System.Windows.Forms.Label();
			this.lblEmail = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.tbSearchName = new System.Windows.Forms.TextBox();
			this.btnSearchName = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lblAdmin = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
			this.SuspendLayout();
			// 
			// rbDeactivated
			// 
			this.rbDeactivated.AutoSize = true;
			this.rbDeactivated.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.rbDeactivated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.rbDeactivated.Location = new System.Drawing.Point(622, 25);
			this.rbDeactivated.Name = "rbDeactivated";
			this.rbDeactivated.Size = new System.Drawing.Size(139, 29);
			this.rbDeactivated.TabIndex = 105;
			this.rbDeactivated.TabStop = true;
			this.rbDeactivated.Text = "Deactivated";
			this.rbDeactivated.UseVisualStyleBackColor = true;
			this.rbDeactivated.CheckedChanged += new System.EventHandler(this.rbDeactivated_CheckedChanged);
			// 
			// rbActivated
			// 
			this.rbActivated.AutoSize = true;
			this.rbActivated.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.rbActivated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.rbActivated.Location = new System.Drawing.Point(506, 25);
			this.rbActivated.Name = "rbActivated";
			this.rbActivated.Size = new System.Drawing.Size(116, 29);
			this.rbActivated.TabIndex = 104;
			this.rbActivated.TabStop = true;
			this.rbActivated.Text = "Activated";
			this.rbActivated.UseVisualStyleBackColor = true;
			this.rbActivated.CheckedChanged += new System.EventHandler(this.rbActivated_CheckedChanged);
			// 
			// rbAll
			// 
			this.rbAll.AutoSize = true;
			this.rbAll.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.rbAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.rbAll.Location = new System.Drawing.Point(453, 25);
			this.rbAll.Name = "rbAll";
			this.rbAll.Size = new System.Drawing.Size(53, 29);
			this.rbAll.TabIndex = 103;
			this.rbAll.TabStop = true;
			this.rbAll.Text = "All";
			this.rbAll.UseVisualStyleBackColor = true;
			this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 17F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(26, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 31);
			this.label1.TabIndex = 98;
			this.label1.Text = "修改其他用户资料";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(857, 459);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 25);
			this.label5.TabIndex = 226;
			this.label5.Text = "Update";
			// 
			// tbSurname
			// 
			this.tbSurname.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.tbSurname.Location = new System.Drawing.Point(209, 322);
			this.tbSurname.Name = "tbSurname";
			this.tbSurname.Size = new System.Drawing.Size(245, 33);
			this.tbSurname.TabIndex = 224;
			// 
			// cbActivated
			// 
			this.cbActivated.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbActivated.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.cbActivated.FormattingEnabled = true;
			this.cbActivated.Location = new System.Drawing.Point(209, 446);
			this.cbActivated.Name = "cbActivated";
			this.cbActivated.Size = new System.Drawing.Size(245, 33);
			this.cbActivated.TabIndex = 223;
			// 
			// tbEmail
			// 
			this.tbEmail.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.tbEmail.Location = new System.Drawing.Point(209, 352);
			this.tbEmail.Name = "tbEmail";
			this.tbEmail.Size = new System.Drawing.Size(245, 33);
			this.tbEmail.TabIndex = 222;
			this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
			// 
			// cbAdmin
			// 
			this.cbAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbAdmin.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.cbAdmin.FormattingEnabled = true;
			this.cbAdmin.Location = new System.Drawing.Point(209, 414);
			this.cbAdmin.Name = "cbAdmin";
			this.cbAdmin.Size = new System.Drawing.Size(245, 33);
			this.cbAdmin.TabIndex = 221;
			// 
			// tbName
			// 
			this.tbName.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.tbName.Location = new System.Drawing.Point(209, 293);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(245, 33);
			this.tbName.TabIndex = 220;
			// 
			// tbIDentityNo
			// 
			this.tbIDentityNo.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.tbIDentityNo.Location = new System.Drawing.Point(209, 263);
			this.tbIDentityNo.Name = "tbIDentityNo";
			this.tbIDentityNo.Size = new System.Drawing.Size(245, 33);
			this.tbIDentityNo.TabIndex = 219;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label7.Location = new System.Drawing.Point(28, 270);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(168, 25);
			this.label7.TabIndex = 218;
			this.label7.Text = "Identity Number:";
			// 
			// lblUserID
			// 
			this.lblUserID.AutoSize = true;
			this.lblUserID.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.lblUserID.Location = new System.Drawing.Point(217, 245);
			this.lblUserID.Name = "lblUserID";
			this.lblUserID.Size = new System.Drawing.Size(71, 25);
			this.lblUserID.TabIndex = 217;
			this.lblUserID.Text = "userID";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label16.Location = new System.Drawing.Point(28, 244);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(84, 25);
			this.label16.TabIndex = 216;
			this.label16.Text = "User ID:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label10.Location = new System.Drawing.Point(28, 358);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(66, 25);
			this.label10.TabIndex = 215;
			this.label10.Text = "Email:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label19.Location = new System.Drawing.Point(28, 454);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(109, 25);
			this.label19.TabIndex = 214;
			this.label19.Text = "Activated: ";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label13.Location = new System.Drawing.Point(28, 418);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(77, 25);
			this.label13.TabIndex = 213;
			this.label13.Text = "Admin:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label9.Location = new System.Drawing.Point(28, 329);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(99, 25);
			this.label9.TabIndex = 212;
			this.label9.Text = "Surname:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label6.Location = new System.Drawing.Point(28, 299);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 25);
			this.label6.TabIndex = 211;
			this.label6.Text = "Name:";
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackgroundImage = global::TMS.Properties.Resources.ok_appproval_acceptance__1_;
			this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Location = new System.Drawing.Point(858, 400);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(80, 56);
			this.btnUpdate.TabIndex = 225;
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::TMS.Properties.Resources.reply__1_;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.Location = new System.Drawing.Point(955, 376);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(61, 104);
			this.button1.TabIndex = 210;
			this.button1.Text = "Back";
			this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbSearch
			// 
			this.tbSearch.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.tbSearch.Location = new System.Drawing.Point(739, 72);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(162, 33);
			this.tbSearch.TabIndex = 227;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label3.Location = new System.Drawing.Point(739, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(168, 25);
			this.label3.TabIndex = 228;
			this.label3.Text = "Identity Number:";
			// 
			// button2
			// 
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.button2.Image = global::TMS.Properties.Resources.search;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button2.Location = new System.Drawing.Point(907, 54);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 52);
			this.button2.TabIndex = 229;
			this.button2.Text = "Search";
			this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// tbPassword
			// 
			this.tbPassword.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.tbPassword.Location = new System.Drawing.Point(209, 384);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(245, 33);
			this.tbPassword.TabIndex = 231;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label4.Location = new System.Drawing.Point(28, 388);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 25);
			this.label4.TabIndex = 230;
			this.label4.Text = "Password:";
			// 
			// dgvUser
			// 
			this.dgvUser.AllowUserToAddRows = false;
			this.dgvUser.AllowUserToDeleteRows = false;
			this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUser.BackgroundColor = System.Drawing.Color.White;
			this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserIDentityNumber,
            this.UserName,
            this.UserSurname,
            this.UserEmail,
            this.UserAdmin,
            this.UserActivated});
			this.dgvUser.Location = new System.Drawing.Point(32, 56);
			this.dgvUser.Name = "dgvUser";
			this.dgvUser.ReadOnly = true;
			this.dgvUser.RowHeadersVisible = false;
			this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUser.Size = new System.Drawing.Size(700, 185);
			this.dgvUser.TabIndex = 232;
			this.dgvUser.SelectionChanged += new System.EventHandler(this.dgvUser_SelectionChanged);
			// 
			// UserID
			// 
			this.UserID.HeaderText = "User ID";
			this.UserID.Name = "UserID";
			this.UserID.ReadOnly = true;
			this.UserID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// UserIDentityNumber
			// 
			this.UserIDentityNumber.HeaderText = "Identity Number";
			this.UserIDentityNumber.Name = "UserIDentityNumber";
			this.UserIDentityNumber.ReadOnly = true;
			this.UserIDentityNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// UserName
			// 
			this.UserName.HeaderText = "Name";
			this.UserName.Name = "UserName";
			this.UserName.ReadOnly = true;
			this.UserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// UserSurname
			// 
			this.UserSurname.HeaderText = "Surname";
			this.UserSurname.Name = "UserSurname";
			this.UserSurname.ReadOnly = true;
			this.UserSurname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// UserEmail
			// 
			this.UserEmail.HeaderText = "Email";
			this.UserEmail.Name = "UserEmail";
			this.UserEmail.ReadOnly = true;
			this.UserEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// UserAdmin
			// 
			this.UserAdmin.HeaderText = "Admin";
			this.UserAdmin.Name = "UserAdmin";
			this.UserAdmin.ReadOnly = true;
			this.UserAdmin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// UserActivated
			// 
			this.UserActivated.HeaderText = "Activated";
			this.UserActivated.Name = "UserActivated";
			this.UserActivated.ReadOnly = true;
			this.UserActivated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// lblIdentityNo
			// 
			this.lblIdentityNo.AutoSize = true;
			this.lblIdentityNo.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.lblIdentityNo.ForeColor = System.Drawing.Color.Red;
			this.lblIdentityNo.Location = new System.Drawing.Point(461, 270);
			this.lblIdentityNo.Name = "lblIdentityNo";
			this.lblIdentityNo.Size = new System.Drawing.Size(73, 25);
			this.lblIdentityNo.TabIndex = 233;
			this.lblIdentityNo.Text = "label 2";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.lblName.ForeColor = System.Drawing.Color.Red;
			this.lblName.Location = new System.Drawing.Point(461, 299);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(67, 25);
			this.lblName.TabIndex = 234;
			this.lblName.Text = "label8";
			// 
			// lblSurname
			// 
			this.lblSurname.AutoSize = true;
			this.lblSurname.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.lblSurname.ForeColor = System.Drawing.Color.Red;
			this.lblSurname.Location = new System.Drawing.Point(461, 333);
			this.lblSurname.Name = "lblSurname";
			this.lblSurname.Size = new System.Drawing.Size(78, 25);
			this.lblSurname.TabIndex = 235;
			this.lblSurname.Text = "label11";
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.lblEmail.ForeColor = System.Drawing.Color.Red;
			this.lblEmail.Location = new System.Drawing.Point(461, 363);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(78, 25);
			this.lblEmail.TabIndex = 236;
			this.lblEmail.Text = "label12";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.lblPassword.ForeColor = System.Drawing.Color.Red;
			this.lblPassword.Location = new System.Drawing.Point(461, 392);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(78, 25);
			this.lblPassword.TabIndex = 237;
			this.lblPassword.Text = "label14";
			// 
			// tbSearchName
			// 
			this.tbSearchName.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.tbSearchName.Location = new System.Drawing.Point(739, 126);
			this.tbSearchName.Name = "tbSearchName";
			this.tbSearchName.Size = new System.Drawing.Size(162, 33);
			this.tbSearchName.TabIndex = 238;
			// 
			// btnSearchName
			// 
			this.btnSearchName.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnSearchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnSearchName.Image = global::TMS.Properties.Resources.search;
			this.btnSearchName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSearchName.Location = new System.Drawing.Point(907, 114);
			this.btnSearchName.Name = "btnSearchName";
			this.btnSearchName.Size = new System.Drawing.Size(56, 52);
			this.btnSearchName.TabIndex = 239;
			this.btnSearchName.Text = "Search";
			this.btnSearchName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSearchName.UseVisualStyleBackColor = true;
			this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label2.Location = new System.Drawing.Point(743, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 25);
			this.label2.TabIndex = 240;
			this.label2.Text = "Name: ";
			// 
			// lblAdmin
			// 
			this.lblAdmin.AutoSize = true;
			this.lblAdmin.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.lblAdmin.ForeColor = System.Drawing.Color.Red;
			this.lblAdmin.Location = new System.Drawing.Point(460, 420);
			this.lblAdmin.Name = "lblAdmin";
			this.lblAdmin.Size = new System.Drawing.Size(621, 75);
			this.lblAdmin.TabIndex = 241;
			this.lblAdmin.Text = "There is a minimum of two admin users registered to this system ,\r\ntherefore you " +
    "can not unregister or deactivate \r\nthis user an admin user.";
			this.lblAdmin.Visible = false;
			// 
			// UpdateUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.lblAdmin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnSearchName);
			this.Controls.Add(this.tbSearchName);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.lblSurname);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.lblIdentityNo);
			this.Controls.Add(this.dgvUser);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbSearch);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.tbSurname);
			this.Controls.Add(this.cbActivated);
			this.Controls.Add(this.tbEmail);
			this.Controls.Add(this.cbAdmin);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.tbIDentityNo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblUserID);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.rbDeactivated);
			this.Controls.Add(this.rbActivated);
			this.Controls.Add(this.rbAll);
			this.Controls.Add(this.label1);
			this.Name = "UpdateUser";
			this.Size = new System.Drawing.Size(1031, 491);
			this.Load += new System.EventHandler(this.UpdateUser_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDeactivated;
        private System.Windows.Forms.RadioButton rbActivated;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.ComboBox cbActivated;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cbAdmin;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbIDentityNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label lblIdentityNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDentityNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserActivated;

       
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAdmin;
    }
}
