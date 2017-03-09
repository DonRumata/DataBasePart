using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewMVPLibrary
{
    public interface IView
    {
        void Show();
        void Close();
    }

    public interface IAuthorizationForm : IView
    {
        string Login { get; }
        string Pass { get; }
        event Action ActLogin;
        void ShowError(string ErrMessage, string ErrHandler, int ButtonType, int IconType);
        void ShowError(string ErrMessage);
    }
}
