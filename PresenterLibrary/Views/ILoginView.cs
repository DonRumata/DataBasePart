using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresenterLibrary.Common;

namespace PresenterLibrary.Views
{
    public interface ILoginView:IView
    {
        string Login { get; }
        string Pass { get; }
        event Action LoginButtonClick;
    }
}
