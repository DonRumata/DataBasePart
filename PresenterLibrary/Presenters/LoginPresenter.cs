using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresenterLibrary.Views;
using PresenterLibrary.Common;
using ModelMVPDataBasePart.IModels;
using PresenterLibrary.Presenters;

namespace PresenterLibrary
{
    public class LoginPresenter:BasePresenter<ILoginView>
    {
        private readonly ILoginService ModelInterface;

        public LoginPresenter(IApplicationController Controller, ILoginView InView, ILoginService InModel):base(Controller, InView)
        {
            ModelInterface = InModel;
            ViewInterface.LoginButtonClick += () => Login(ViewInterface.Login, ViewInterface.Pass);
        }

        private void Login(string Username, string Pass)
        {
            if (ModelInterface.Login(Username, Pass, Controller.DBClass))
            {
                Controller.Run<MainInterfacePresenter>();
                ViewInterface.Close();
            }
            else
                ; //Сообщение об ошибке
        }


    }
}
