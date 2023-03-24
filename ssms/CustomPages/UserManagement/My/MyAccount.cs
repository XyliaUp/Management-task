using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.Pages
{
    public partial class MyAccount : UserControl
    {
        public MyAccount()
        {
            InitializeComponent();
        }


        //Margo
        private void MyAccount_Load(object sender, EventArgs e)
        {
            try
            {
                id.Text = TMS.Properties.Common.LoggedIn.UserID.ToString();
                name.Text = TMS.Properties.Common.LoggedIn.UserName.ToString();
                email.Text = TMS.Properties.Common.LoggedIn.UserEmail.ToString();

                IsAdmin.Text = (TMS.Properties.Common.LoggedIn.UserAdmin ? "是" : "否").ToString();
                IsActivated.Text = (TMS.Properties.Common.LoggedIn.UserActivated ? "是" : "否").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TMS.Util.ErrorCode.Common.ErrorCodes.Find(EC => EC.Code == 100).Info);
            }
        }

        //Margo
        private void button3_Click(object sender, EventArgs e)
        {
            ((Main)this.Parent.Parent).ChangeView<UpdateMyAccount>();
        }
    }
}
