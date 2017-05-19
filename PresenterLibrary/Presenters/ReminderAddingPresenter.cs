using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresenterLibrary.Views;
using PresenterLibrary.Common;
using ModelMVPDataBasePart.IModels;
using ModelMVPDataBasePart.Common;

namespace PresenterLibrary.Presenters
{
    class ReminderAddingPresenter:BasePresenter<IRemindAddingView,ArgDepositer<int,string>>
    {
        private readonly IRemindAddingModel ModelInterface;
        private readonly IEnumerable<EventDataCreator> DateList;

        public ReminderAddingPresenter(IApplicationController Controller,IRemindAddingView InView, IRemindAddingModel InModel):base(Controller,InView)
        {
            ModelInterface = InModel;
            ViewInterface.AddRemind += (sender, args) => AddRemind();
            ViewInterface.DeleteRemind += (arg) => RemoveSelectRemind(arg);
            ViewInterface.PanelConfirm += (arg) => PanelConfirm(arg);
        }

        public void PanelConfirm(int ConfirmIndex)
        {
            //var temp=ModelInterface.GetItemsForFormInitialize(Controller.DBClass, ConfirmIndex);
            //ViewInterface.SetTimersList();
            //temp[ViewInterface.SelectedValue].EventRemindTable
        }

        public void AddRemind()
        {
            if (ViewInterface.RemindAfterBefore != null)
            {
                ModelInterface.AddItemToListStruct(new RemindDataCreator(
                    DateList.ElementAt(ViewInterface.SelectedValue).EventDate.Add(ViewInterface.RemindAfterBefore.Value),
                    ViewInterface.RemindUntil, 
                    (int)ViewInterface.HowToRemind));
            }
            else
            {
                ModelInterface.AddItemToListStruct(new RemindDataCreator(
                    DateList.ElementAt(ViewInterface.SelectedValue).EventDate,
                    ViewInterface.RemindUntil,
                    (int)ViewInterface.HowToRemind));
            }
        }

        public void RemoveSelectRemind(int arg)
        {
            ModelInterface.RemoveItemFromListStruct(arg);
            ViewInterface.RemoveSelectedItem_From_RemindersList(arg);
        }

        public override void Run(ArgDepositer<int, string> Arg)
        {
            switch(Arg.FirstDataHandler)
            {
                case 0:
                    ViewInterface.FirstPanelInitialization(Arg.FirstDataHandler, ModelInterface.GetEventNames(Controller.DBClass));
                    ViewInterface.Show();
                    break;
            }
        }
    }
}
