using System.Windows.Forms;

namespace TMS.Windows.Extension
{
	public static class Common
	{
        public static void ChangeView<T>(this Control ParentControl) where T : Control, new()
        {
            try
            {
                ParentControl.Controls.Clear();

                T find = new T();
                find.Parent = ParentControl;
                find.Dock = DockStyle.Fill;
                find.BringToFront();
            }
            catch
            {

            }
        }

        public static void ChangeView(this Control ParentControl,Control T)
        {
            try
            {
                ParentControl.Controls.Clear();

                T.Parent = ParentControl;
                T.Dock = DockStyle.Fill;
                T.BringToFront();
            }
            catch
            {

            }
        }
    }
}
