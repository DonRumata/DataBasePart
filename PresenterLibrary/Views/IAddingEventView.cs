using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelMVPDataBasePart.Common;
using PresenterLibrary.Common;
using System.Windows.Forms;

namespace PresenterLibrary.Views
{
    public interface IAddingEventView : IView
    {

        string Namebox { get; set; }
        EventRepeatRadioValues WhichTypeOfRemind { get; set; }
        DateTime EventHappen { get; set; }
        DateTime? EventDuration { get; set; }
        ListView.ListViewItemCollection ListViewItems { get; set; }
        string MaskFormat{get;}
        string MaskDurationFormat { get; }

        event EventHandler AddItemToViewStruct;
        event Action<IEnumerable<int>> RemoveRangeFromViewStruct;
        event EventHandler SaveAndQuit;
        event EventHandler SaveAndAddRemind;
        void AdditemToView(ListViewItem InItem);
        void RemoveSelectedItemsFromView();
        void Remove_Button_Enabler(bool value);
    }
}
