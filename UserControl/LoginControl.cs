using System;
using System.Drawing;
using System.Windows.Forms;

namespace UserControlApp
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        //public string Username
        //{
        //    get { return txtUser.Text; }
        //    set { txtUser.Text = value; }
        //}

        //public string Password
        //{
        //    get { return txtPass.Text; }
        //    set { txtPass.Text = value; }
        //}

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Length < 3)
            {
                lblResult.Text = "Потребителят е твърде кратък";
                lblResult.ForeColor = Color.Red;
            }
            else if (txtPass.Text.Length < 6)
            {
                lblResult.Text = "Паролата е твърде кратка";
                lblResult.ForeColor = Color.Red;
            }
            else
            {
                lblResult.Text = "Успешен вход";
                lblResult.ForeColor = Color.Green;
            }
        }
    }
}
