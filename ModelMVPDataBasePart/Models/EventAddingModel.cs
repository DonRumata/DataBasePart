using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelMVPDataBasePart.IModels;
using ModelMVPDataBasePart.Common;

namespace ModelMVPDataBasePart.Models
{
    public class EventAddingModel : IEventAddingModel
    {
        private List<EventDataCreator> EventViewStruct { get; set; }

        public void AddItemToViewStruct(EventDataCreator inItem)
        {
            EventViewStruct.Add(inItem);
        }

        public bool CommitItemChangesToDB(IDataEventAdding DBOperational)
        {
            return DBOperational.AddEventsFromEventCreator(EventViewStruct);
        }

        public void RemoveItemFromViewStruct(int InIndex)
        {
            EventViewStruct.RemoveAt(InIndex);
        }

        public void RemoveRangeItemsFromViewStruct(IEnumerable<int> ItemIndecies)
        {
            foreach(int IC in ItemIndecies)
            {
                EventViewStruct.RemoveAt(IC);
            }
        }
    }
}
