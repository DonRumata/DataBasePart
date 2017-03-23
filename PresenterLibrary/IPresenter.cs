using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelMVPDataBasePart;
using DataBasePart;

namespace PresenterLibrary
{

    public class MainPresenter
    {
        
        //Интерфейсы всех View форм.
        #region View Interfaces
        private readonly ILoginForm ILoginFormView;
        private readonly IMainBaseView IMainFormView;
        private readonly IEventAddingView IEventAddView;
        #endregion
        //Интерфейсы всех моделей и сервисов
        #region Model Interfaces
        private readonly IDataBaseOperation I_DBModel;
        private readonly IEventAddingModel IEventAddModel;
        #endregion

        public MainPresenter(ILoginForm InLoginF, IMainBaseView InBaseF, IDataBaseOperation InDBModel, IEventAddingModel InAddViewModel)
        {
            ILoginFormView = InLoginF;
            IMainFormView = InBaseF;
            I_DBModel = InDBModel;
            IEventAddModel = InAddViewModel;
            ILoginFormView.LoginButtonClick += new EventHandler(LoginBClick);
            IMainFormView.EventAddingClick += new EventHandler(EventAdding);
            IMainFormView.RemindAddingClick += new EventHandler(RemindAdding);
            IEventAddView.AddTimeClick += new EventHandler(DateTimeAddButton_Click);
            IEventAddView.RemoveTimeClick += new EventHandler<IEnumerable<int>>(DateTimeRemoveButtun_Click);
        }
        #region View_Realization
        //Реализация всех событий ILoginForm
        #region ILoginMethods
        private void LoginBClick(object sender, EventArgs e)
        {
            I_DBModel.CreateConnection(ILoginFormView.Login, ILoginFormView.Pass, 2);
        }
        #endregion
        //Реализация всех событий IMainBaseView
        #region IMainFormView_Methods
        private void EventAdding(object sender, EventArgs e)
        {
            
        }

        private void RemindAdding(object sender, EventArgs e)
        {

        }
        #endregion

        #region IEventAdding_Methods
        public void DateTimeAddButton_Click(object sender, EventArgs e)
        {
            IEventAddModel.AddItemToViewStruct(IEventAddView.NameBox, IEventAddView.EventTimeHap, IEventAddView.Which_type_of_remind);
        }

        private void SaveAndQuit_Click(object sender, EventArgs e)
        {
            I_DBModel.AddEventsFromEventCreator(IEventAddModel.EventViewStruct);
        }

        private void DateTimeRemoveButtun_Click(object sender, IEnumerable<int> e)
        {
            foreach (int T in e)
            {
                IEventAddModel.RemoveItemFromViewStruct(T);
            }
        }

        #endregion

        #endregion

        
    }
}
