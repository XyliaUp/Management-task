namespace TMS.CustomPages.InfoManageremnt.Vehicle
{
	partial class VehicleList
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
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.platenum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.register = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.radioButton1.Location = new System.Drawing.Point(609, 3);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(68, 29);
			this.radioButton1.TabIndex = 84;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "全部";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Silver;
			this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(697, 0);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(196, 43);
			this.button4.TabIndex = 83;
			this.button4.Text = "导出为PDF";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.RoyalBlue;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(697, 127);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(196, 40);
			this.button3.TabIndex = 82;
			this.button3.Text = "修改车辆信息";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.RoyalBlue;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(697, 65);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(196, 40);
			this.button1.TabIndex = 81;
			this.button1.Text = "增加车辆";
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
            this.VehicleID,
            this.VehicleName,
            this.platenum,
            this.type,
            this.capacity,
            this.Address,
            this.register});
			this.dataGridView1.Location = new System.Drawing.Point(3, 32);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(674, 284);
			this.dataGridView1.TabIndex = 80;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 17F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 31);
			this.label1.TabIndex = 79;
			this.label1.Text = "车辆信息";
			// 
			// VehicleID
			// 
			this.VehicleID.FillWeight = 48.86937F;
			this.VehicleID.HeaderText = "车辆编号";
			this.VehicleID.Name = "VehicleID";
			this.VehicleID.ReadOnly = true;
			// 
			// VehicleName
			// 
			this.VehicleName.FillWeight = 53.86937F;
			this.VehicleName.HeaderText = "名称";
			this.VehicleName.Name = "VehicleName";
			this.VehicleName.ReadOnly = true;
			// 
			// platenum
			// 
			this.platenum.FillWeight = 52.6705F;
			this.platenum.HeaderText = "车牌号";
			this.platenum.Name = "platenum";
			this.platenum.ReadOnly = true;
			// 
			// type
			// 
			this.type.FillWeight = 50.41579F;
			this.type.HeaderText = "类型";
			this.type.Name = "type";
			this.type.ReadOnly = true;
			// 
			// capacity
			// 
			this.capacity.FillWeight = 45.41579F;
			this.capacity.HeaderText = "载重量";
			this.capacity.Name = "capacity";
			this.capacity.ReadOnly = true;
			// 
			// Address
			// 
			this.Address.FillWeight = 100.4158F;
			this.Address.HeaderText = "位置";
			this.Address.Name = "Address";
			this.Address.ReadOnly = true;
			// 
			// register
			// 
			this.register.FillWeight = 68.41579F;
			this.register.HeaderText = "导入时间";
			this.register.Name = "register";
			this.register.ReadOnly = true;
			// 
			// VehicleList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Name = "VehicleList";
			this.Size = new System.Drawing.Size(896, 321);
			this.Load += new System.EventHandler(this.VehicleList_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn VName;
		private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
		private System.Windows.Forms.DataGridViewTextBoxColumn VehicleName;
		private System.Windows.Forms.DataGridViewTextBoxColumn platenum;
		private System.Windows.Forms.DataGridViewTextBoxColumn type;
		private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Address;
		private System.Windows.Forms.DataGridViewTextBoxColumn register;
	}
}
