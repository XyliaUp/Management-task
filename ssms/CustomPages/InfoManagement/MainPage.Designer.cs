namespace TMS.CustomPages.InfoManageremnt
{
    partial class MainPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
			this.panel2 = new System.Windows.Forms.Panel();
			this.Btn_Custom = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 47);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1156, 410);
			this.panel2.TabIndex = 2;
			// 
			// Btn_Custom
			// 
			this.Btn_Custom.BackColor = System.Drawing.Color.LightSeaGreen;
			this.Btn_Custom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Btn_Custom.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.Btn_Custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Btn_Custom.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.Btn_Custom.ForeColor = System.Drawing.Color.White;
			this.Btn_Custom.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Custom.Image")));
			this.Btn_Custom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Btn_Custom.Location = new System.Drawing.Point(1, 0);
			this.Btn_Custom.Name = "Btn_Custom";
			this.Btn_Custom.Size = new System.Drawing.Size(121, 45);
			this.Btn_Custom.TabIndex = 24;
			this.Btn_Custom.Text = "客户管理";
			this.Btn_Custom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Btn_Custom.UseVisualStyleBackColor = false;
			this.Btn_Custom.Click += new System.EventHandler(this.Btn_Custom_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point(128, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 45);
			this.button1.TabIndex = 25;
			this.button1.Text = "司机信息";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.PeachPuff;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("微软雅黑", 12F);
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.Location = new System.Drawing.Point(255, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(121, 45);
			this.button2.TabIndex = 26;
			this.button2.Text = "车辆信息";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Btn_Custom);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainPage";
			this.Size = new System.Drawing.Size(1156, 457);
			this.Load += new System.EventHandler(this.MyAccount_Load);
			this.SizeChanged += new System.EventHandler(this.MainPage_SizeChanged);
			this.ResumeLayout(false);

        }

		#endregion
		public System.Windows.Forms.Button Btn_Custom;
		public System.Windows.Forms.Button button1;
		public System.Windows.Forms.Button button2;
		public System.Windows.Forms.Panel panel2;
	}
}
