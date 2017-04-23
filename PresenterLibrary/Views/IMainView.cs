using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresenterLibrary.Common;

namespace PresenterLibrary.Views
{
    public interface IMainView:IView
    {
        object MainViewDataGridSet { set; }
        object EventViewDataGridSet { set; }
        object OtherViewGridSet { set; }

        event EventHandler AddEventClick;
        event EventHandler AddRemindClick;
    }
}
