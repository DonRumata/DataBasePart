using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresenterLibrary.Views;
using PresenterLibrary.Common;
using ModelMVPDataBasePart.IModels;

namespace PresenterLibrary.Presenters
{
    class AddingEventPresenter:BasePresenter<IAddingEventView>
    {
        private readonly IEventAddingModel ModelInterface;

        public AddingEventPresenter(IApplicationController Controller, IAddingEventView Inview, IEventAddingModel InModel):base(Controller,Inview)
        {
            ModelInterface = InModel;
            ViewInterface.AddItemToViewStruct += (sender, args) => AddItemToViewStruct();
            ViewInterface.RemoveRangeFromViewStruct += (indecies) => RemoveRangeItemsFromViewStruct(indecies);
            ViewInterface.SaveAndQuit += (sender, args) => SaveAndQuit();
        }

        public void AddItemToViewStruct()
        {
            ViewInterface.Remove_Button_Enabler(true);
            ModelInterface.AddItemToViewStruct(new ModelMVPDataBasePart.Common.EventDataCreator(ViewInterface.Namebox, ViewInterface.EventHappen, (int)ViewInterface.WhichTypeOfRemind, ViewInterface.EventDuration));
            ViewInterface.AdditemToView(new System.Windows.Forms.ListViewItem(new string[] { ViewInterface.EventHappen.ToString(ViewInterface.MaskFormat),
                RadioCheckedInToTextValue((int)ViewInterface.WhichTypeOfRemind),
                EventDurationToStringConverter(ViewInterface.EventDuration) }));
        }

        public void RemoveRangeItemsFromViewStruct(IEnumerable<int> ItemIndecies)
        {
            ModelInterface.RemoveRangeItemsFromViewStruct(ItemIndecies);
            ViewInterface.RemoveSelectedItemsFromView();
        }

        public void SaveAndQuit()
        {
            ModelInterface.CommitItemChangesToDB(Controller.DBClass);
        }

        private string EventDurationToStringConverter(DateTime? InDateTime)
        {
            if (InDateTime.HasValue)
            {
                return InDateTime.Value.ToString(ViewInterface.MaskDurationFormat);
            }
            else
                return "";
        }

        private string RadioCheckedInToTextValue(int Invalue)
        {
            switch (Invalue)
            {
                case 1: return "Без повторений";
                case 2: return "Ежедневно";
                case 3: return "Еженедельно";
                case 4: return "Ежемесячно";
            }
            return "";
        }
    }
}
