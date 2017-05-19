using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelMVPDataBasePart.IModels;
using ModelMVPDataBasePart.Common;

namespace ModelMVPDataBasePart.Models
{
    public class RemindAddingModel:IRemindAddingModel
    {
        private List<RemindDataCreator> RemindViewStruct { get; set; }

        public void AddItemToListStruct(RemindDataCreator InItem)
        {
            RemindViewStruct.Add(InItem);
        }

        public bool CommitChangesToDB(IDataRemindAdding DBOperational, int EvID)
        {
            return DBOperational.AddRemindsFromRemindCreator(RemindViewStruct, EvID);
        }

        public void RemoveRangeFromListStruct(IEnumerable<int> ItemIndecies)
        {
            foreach (int IC in ItemIndecies)
            {
                RemindViewStruct.RemoveAt(IC);
            }
        }

        public void RemoveItemFromListStruct(int ItemIndex)
        {
            RemindViewStruct.RemoveAt(ItemIndex);
        }

        public string[] GetEventNames(IDataRemindAdding DBOperational)
        {
            return DBOperational.GetEventNamesArray();
        }

        public List<EventTimeTable> GetItemsForFormInitialize(IDataRemindAdding DBOperational, int InID)
        {
            return DBOperational.GetItemsForFormInitialize(InID);
        }


    }
}
