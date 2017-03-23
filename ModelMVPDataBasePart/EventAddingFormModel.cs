using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMVPDataBasePart
{
    public class EventDateCreator
    {
        public string EventName { get; private set; }
        public DateTime EventDate { get; private set; }
        public int RemindEvery { get; private set; }

        public EventDateCreator(string InName, DateTime InDate, int InRemind)
        {
            EventName = InName;
            EventDate = InDate;
            RemindEvery = InRemind;
        }
    }

    public interface IEventAddingModel
    {
        List<EventDateCreator> EventViewStruct { get; set; }

        void AddItemToViewStruct(EventDateCreator InItem);
        void AddItemToViewStruct(string InName, DateTime inDate, int InRemind);
        void RemoveItemFromViewStruct(EventDateCreator RemoveItem);
        void RemoveItemFromViewStruct(int RemoveIndex);
        void RemoveRangeFromViewStruct(int FirstValue, int LastValue);
    }

    public class EventAddingFormModel:IEventAddingModel
    {
        public List<EventDateCreator> EventViewStruct { get; set; }

        public void AddItemToViewStruct(EventDateCreator InItem)
        {
            EventViewStruct.Add(InItem);
        }

        public void AddItemToViewStruct(string InName, DateTime InDate, int InRemind)
        {
            EventViewStruct.Add(new EventDateCreator(InName, InDate, InRemind));
        }

        public void RemoveItemFromViewStruct(EventDateCreator RemoveItem)
        {
            EventViewStruct.Remove(RemoveItem);
        }

        public void RemoveItemFromViewStruct(int RemoveIndex)
        {
            EventViewStruct.RemoveAt(RemoveIndex);
        }

        public void RemoveRangeFromViewStruct(int FirstValue, int SecondValue)
        {
            EventViewStruct.RemoveRange(FirstValue, SecondValue - FirstValue);
        }
    }
}
