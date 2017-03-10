using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBasePart
{
    public interface ILoginForm
    {
        string Login { get; }
        string Pass { get; }
        event EventHandler LoginButtonClick;
    }

    public partial class LoginForm : Form, ILoginForm
    {
        #region IMainForm
        public string Login
        {
            get { return LoginBox.Text; }
        }

        public string Pass
        {
            get { return PassBox.Text; }
        }

        public event EventHandler LoginButtonClick;
        #endregion

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginButtonClick != null)
                LoginButtonClick(this, EventArgs.Empty);
        }

        
        public LoginForm()
        {
            InitializeComponent();
            LoginButton.Click += new EventHandler(LoginButton_Click);
        }
    }
}
