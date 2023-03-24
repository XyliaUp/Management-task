using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TMS.Pages
{
	public partial class UpdateMyAccount : UserControl
	{
		string emailUpdateCheck;
		string emailUpdateCheckCompare;
		public UpdateMyAccount()
		{
			InitializeComponent();
		}


		//Marius
		private void UpdateMyAccount_Load(object sender, EventArgs e)
		{
			try
			{
				lblEmail.Visible = false;
				lblName.Visible = false;
				lblPassword.Visible = false;


				//Margo
				if (!TMS.Properties.Common.LoggedIn.UserAdmin)
				{
					cbAdmin.Enabled = false;
					cbActivated.Enabled = false;
				}


				List<string> ComboVal = new List<string>();
				ComboVal.Add("是");
				ComboVal.Add("否");

				List<string> ComboVal2 = new List<string>();
				ComboVal2.Add("是");
				ComboVal2.Add("否");

				cbAdmin.DataSource = ComboVal;
				cbActivated.DataSource = ComboVal2;

				lblUserID.Text = TMS.Properties.Common.LoggedIn.UserID.ToString();

				var user = TMS.Properties.Common.LoggedIn;
				tbPassword.Text = user.UserPassword;
			
				tbName.Text = user.UserName;
				tbEmail.Text = user.UserEmail;

				string isAdminActivated = "";
				string isUserActivated = "";

				isAdminActivated = user.UserAdmin ? "是" : "否";
				isUserActivated = user.UserActivated ? "是" : "否";

				cbAdmin.Text = isAdminActivated;
				cbActivated.Text = isUserActivated;

				emailUpdateCheckCompare = tbEmail.Text;
			}
			catch (Exception ex)
			{
				MessageBox.Show(TMS.Util.ErrorCode.Common.ErrorCodes.Find(EC => EC.Code == 100).Info);
			}
		}




		//Margo
		private void buttonBack_Click(object sender, EventArgs e)
		{
			((Main)this.Parent.Parent).ChangeView<MyAccount>();
		}
		private void tbEmail_TextChanged(object sender, EventArgs e)
		{
			if (tbEmail.Text != "")
			{
				emailUpdateCheck = tbEmail.Text;
			}
		}

		bool IsDigitsOnly(string str)
		{
			foreach (char c in str) if (c < '0' || c > '9') return false;
			return true;
		}

		private void okBtn1_CustomClick(object sender, EventArgs e)
		{
			try
			{
				try
				{
					lblPassword.Visible = false;
					lblName.Visible = false;
				
					lblEmail.Visible = false;

					LTS.User user = new LTS.User()
					{
						UserID = int.Parse(lblUserID.Text),
						UserName = tbName.Text,
						UserPassword = tbPassword.Text,
					};


					List<string> emailList = new List<string>();

					List<LTS.User> listEmail = new List<LTS.User>();
					listEmail = DAT.DataAccess.GetUser().ToList();
					for (int b = 0; b < listEmail.Count; b++)
					{
						emailList.Add(listEmail[b].UserEmail);
					}


					if (!emailList.Contains(tbEmail.Text) || emailUpdateCheck == emailUpdateCheckCompare)
					{
						user.UserEmail = tbEmail.Text;
					}
					else
					{
						lblEmail.Visible = true;
						lblEmail.Text = "Email已经存在";
					}




					user.UserAdmin = cbAdmin.SelectedItem.Equals("是");
					user.UserActivated = cbActivated.SelectedItem.Equals("是");


					if (tbName.Text == "")
					{
						lblName.Visible = true;
						lblName.Text = "请输入一个名字";
					}

					if (tbEmail.Text == "" || !Regex.IsMatch(tbEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
					{
						lblEmail.Visible = true;
						lblEmail.Text = "请输入一个有效的email";
					}

					if (tbPassword.Text == "")
					{
						lblPassword.Visible = true;
						lblPassword.Text = "请输入一个有效的密码";
					}




					bool ok = false;
					if (!lblEmail.Visible  && !lblName.Visible && !lblPassword.Visible)
					{
						ok = DAT.DataAccess.UpdateUser(user);
					}

					//未成功
					if (!ok) MessageBox.Show(TMS.Util.ErrorCode.Common.ErrorCodes.Find(EC => EC.Code == 101).Info);
					else
					{
						if (DialogResult.OK == MessageBox.Show("用户信息更新成功！"))
						{
							TMS.Properties.Common.LoggedIn = user;
							((Main)this.Parent.Parent).ChangeView<UpdateMyAccount>();
						}
					}
				}
				catch (Exception ex)
				{
					if (DialogResult.OK == MessageBox.Show("用户信息更新失败！"))
					{
						((Main)this.Parent.Parent).ChangeView<UpdateMyAccount>();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(TMS.Util.ErrorCode.Common.ErrorCodes.Find(EC => EC.Code == 100).Info);
			}
		}
	}
}
