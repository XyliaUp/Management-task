namespace TMS.CustomPages.OrderManageremnt
{
    partial class Track
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.VehicleAddress = new System.Windows.Forms.Label();
			this.VehicleDriver = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.map1 = new TMS.MapView.Map();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(145, 503);
			this.panel1.TabIndex = 25;
			// 
			// VehicleAddress
			// 
			this.VehicleAddress.AutoSize = true;
			this.VehicleAddress.Font = new System.Drawing.Font("微软雅黑", 11.25F);
			this.VehicleAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.VehicleAddress.Location = new System.Drawing.Point(146, 4);
			this.VehicleAddress.Name = "VehicleAddress";
			this.VehicleAddress.Size = new System.Drawing.Size(69, 20);
			this.VehicleAddress.TabIndex = 368;
			this.VehicleAddress.Text = "车辆位置";
			// 
			// VehicleDriver
			// 
			this.VehicleDriver.AutoSize = true;
			this.VehicleDriver.Font = new System.Drawing.Font("微软雅黑", 11.25F);
			this.VehicleDriver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.VehicleDriver.Location = new System.Drawing.Point(146, 44);
			this.VehicleDriver.Name = "VehicleDriver";
			this.VehicleDriver.Size = new System.Drawing.Size(69, 20);
			this.VehicleDriver.TabIndex = 369;
			this.VehicleDriver.Text = "负责司机";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.RoyalBlue;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(911, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(115, 40);
			this.button1.TabIndex = 370;
			this.button1.Text = "车辆调度";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.RoyalBlue;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(911, 47);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(115, 40);
			this.button2.TabIndex = 371;
			this.button2.Text = "路线规划";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// map1
			// 
			this.map1.Address = null;
			this.map1.BackColor = System.Drawing.Color.Gainsboro;
			this.map1.Dock = System.Windows.Forms.DockStyle.Right;
			this.map1.Location = new System.Drawing.Point(434, 0);
			this.map1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.map1.Name = "map1";
			this.map1.Size = new System.Drawing.Size(593, 503);
			this.map1.TabIndex = 26;
			// 
			// Track
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.map1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.VehicleDriver);
			this.Controls.Add(this.VehicleAddress);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Track";
			this.Size = new System.Drawing.Size(1027, 503);
			this.Load += new System.EventHandler(this.Track_Load);
			this.SizeChanged += new System.EventHandler(this.MainPage_SizeChanged);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Panel panel1;
		private MapView.Map map1;
		private System.Windows.Forms.Label VehicleAddress;
		private System.Windows.Forms.Label VehicleDriver;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}
