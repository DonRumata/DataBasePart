using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMVPDataBasePart.Common
{
    public class EventDataCreator
    {
        public string EventName { get; private set; }
        public DateTime EventDate { get; private set; }
        public int RemindEvery { get; private set; }
        public DateTime? EventDuration { get; private set; }

        public EventDataCreator(string InName, DateTime InDate, int InRemind, DateTime? InDuration=null)
        {
            EventName = InName;
            EventDate = InDate;
            RemindEvery = InRemind;
            EventDuration = InDuration;
        }
    }
}
