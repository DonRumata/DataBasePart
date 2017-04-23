using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelMVPDataBasePart.Common;

namespace ModelMVPDataBasePart.IModels
{
    public interface IEventAddingModel
    {
        void AddItemToViewStruct(EventDataCreator inItem);
        void RemoveRangeItemsFromViewStruct(IEnumerable<int> ItemIndecies);
        bool CommitItemChangesToDB(IDataEventAdding DBOperational);
    }
}
