using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresenterLibrary.Views;

namespace DataBasePart
{
    public partial class LoginForm : Form, ILoginView
    {
        private readonly ApplicationContext _context;
        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        #region IMainForm
        #region Parameters
        public string Login
        {
            get { return LoginBox.Text; }
        }

        public string Pass
        {
            get { return PassBox.Text; }
        }
        #endregion
        #region Events
        public event Action LoginButtonClick;
        #endregion
        #endregion

        
        public LoginForm(ApplicationContext InContext)
        {
            _context = InContext;
            InitializeComponent();
            LoginButton.Click += (sender, args) => Invoke(LoginButtonClick);
        }

        private void Invoke(Action action)
        {
            action?.Invoke();
        }
    }
}
