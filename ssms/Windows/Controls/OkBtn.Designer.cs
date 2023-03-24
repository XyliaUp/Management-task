namespace TMS.Windows.Controls
{
	partial class OkBtn
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackgroundImage = global::TMS.Properties.Resources.ok_appproval_acceptance__1_;
			this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 14.25F);
			this.btnUpdate.Location = new System.Drawing.Point(0, 0);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(48, 40);
			this.btnUpdate.TabIndex = 181;
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微软雅黑", 17F);
			this.label5.Location = new System.Drawing.Point(54, 5);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 30);
			this.label5.TabIndex = 182;
			this.label5.Text = "修改";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// OkBtn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnUpdate);
			this.Name = "OkBtn";
			this.Size = new System.Drawing.Size(116, 44);
			this.Load += new System.EventHandler(this.OkBtn_Load);
			this.SizeChanged += new System.EventHandler(this.OkBtn_SizeChanged);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label label5;
	}
}
