using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresenterLibrary.Common;
using PresenterLibrary.Views;
using PresenterLibrary.Presenters;
using ModelMVPDataBasePart.IModels;
using ModelMVPDataBasePart.Models;

namespace DataBasePart
{
    static class Program
    {
        public static readonly ApplicationContext NowUsingForm = new ApplicationContext();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static void Main()
        {
            var Controller = new ApplicationController(new LightInjectAdapter())
                .RegisterView<ILoginView, LoginForm>()
                .RegisterView<IMainView, MainBaseInterfaceForm>()
                .RegisterView<IAddingEventView, EventAddingForm>()
                .RegisterView<IRemindAddingView, RemindAdding>()
                .RegisterService<ILoginService, LoginModel>()
                .RegisterService<IEventAddingModel, EventAddingModel>()
                .RegisterService<IRemindAddingModel, RemindAddingModel>()
                .RegisterService<IMainIModel, MainModel>()
                .RegisterInstance(new ApplicationContext());
            Controller.Run<PresenterLibrary.LoginPresenter>();
        }
    }
}
