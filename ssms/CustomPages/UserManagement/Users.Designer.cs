﻿namespace TMS.Pages
{
    partial class Users
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
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserActivated = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.radioButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.radioButton4.Location = new System.Drawing.Point(698, 21);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(87, 29);
			this.radioButton4.TabIndex = 96;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "已删除";
			this.radioButton4.UseVisualStyleBackColor = true;
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.radioButton2.Location = new System.Drawing.Point(624, 21);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(68, 29);
			this.radioButton2.TabIndex = 95;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "有效";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.radioButton1.Location = new System.Drawing.Point(550, 21);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(68, 29);
			this.radioButton1.TabIndex = 94;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "全部";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Silver;
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(847, 24);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(161, 42);
			this.button4.TabIndex = 93;
			this.button4.Text = "导出为PDF";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.SteelBlue;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(847, 150);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(161, 40);
			this.button3.TabIndex = 92;
			this.button3.Text = "修改信息";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SteelBlue;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(847, 89);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(161, 40);
			this.button1.TabIndex = 91;
			this.button1.Text = "新增用户";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.UserEmail,
            this.UserAdmin,
            this.UserActivated});
			this.dataGridView1.Enabled = false;
			this.dataGridView1.Location = new System.Drawing.Point(36, 54);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(750, 395);
			this.dataGridView1.TabIndex = 90;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 17F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(30, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 31);
			this.label1.TabIndex = 89;
			this.label1.Text = "用户";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.SteelBlue;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(847, 211);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(161, 40);
			this.button2.TabIndex = 97;
			this.button2.Text = "删除用户";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			// 
			// UserID
			// 
			this.UserID.HeaderText = "用户编号";
			this.UserID.Name = "UserID";
			this.UserID.ReadOnly = true;
			// 
			// UserName
			// 
			this.UserName.HeaderText = "用户名称";
			this.UserName.Name = "UserName";
			this.UserName.ReadOnly = true;
			// 
			// UserEmail
			// 
			this.UserEmail.HeaderText = "Email";
			this.UserEmail.Name = "UserEmail";
			this.UserEmail.ReadOnly = true;
			// 
			// UserAdmin
			// 
			this.UserAdmin.HeaderText = "管理员";
			this.UserAdmin.Name = "UserAdmin";
			this.UserAdmin.ReadOnly = true;
			// 
			// UserActivated
			// 
			this.UserActivated.HeaderText = "账号可用";
			this.UserActivated.Name = "UserActivated";
			this.UserActivated.ReadOnly = true;
			// 
			// Users
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.radioButton4);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Name = "Users";
			this.Size = new System.Drawing.Size(1031, 491);
			this.Load += new System.EventHandler(this.Users_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserAdmin;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserActivated;
	}
}
