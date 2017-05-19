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
    class MainInterfacePresenter:BasePresenter<IMainView>
    {
        private readonly IMainIModel ModelInterface;

        public MainInterfacePresenter(IApplicationController Controller, IMainView InView, IMainIModel InModel):base(Controller, InView)
        {
            ModelInterface = InModel;
            ViewInterface.AddEventClick +=(sender,args)=>AddEvent_Click();
            ViewInterface.AddRemindClick += (sender, args) => AddRemind_Click();
            ShowDataOnInterface();
        }

        public void ShowDataOnInterface()
        {
            ViewInterface.MainViewDataGridSet = ModelInterface.GetMainView(Controller.DBClass);
        }

        public void AddEvent_Click()
        {
            Controller.Run<AddingEventPresenter>();
        }

        public void AddRemind_Click()
        {
            Controller.Run<ReminderAddingPresenter, ArgDepositer<int, string>>(new ArgDepositer<int, string>(0, ""));
        }

        //public new void Run()
        //{
        //    ViewInterface.Show();
        //}
    }
}
