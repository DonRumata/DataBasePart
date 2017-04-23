using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelMVPDataBasePart.Common;

namespace ModelMVPDataBasePart.IModels
{
    public interface IRemindAddingModel
    {
        void AddItemToListStruct(RemindDataCreator InItem);
        void RemoveItemFromListStruct(int ItemIndex);
        void RemoveRangeFromListStruct(IEnumerable<int> ItemIndecies);
        bool CommitChangesToDB(IDataRemindAdding DBOperational, int EvID);

        string[] GetEventNames();
    }
}
