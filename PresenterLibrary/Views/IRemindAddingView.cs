using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresenterLibrary.Common;

namespace PresenterLibrary.Views
{
    public interface IRemindAddingView:IView
    {
        TimeSpan? RemindAfterBefore { get; set; }
        DateTime RemindUntil { get; set; }
        RemindRadioValues HowToRemind { get; set; }
        int SelectedValue { get; }

        event EventHandler AddRemind;
        event Action<int> DeleteRemind;
        event EventHandler Back;

        void AdditemToReminders(DateTime RemindDate);
        void RemoveSelectedItem_From_RemindersList(int RemoveIndex);
        void FirstPanelInitialization(int WhichOne, string[] ComboElementsIn = null);
    }
}
