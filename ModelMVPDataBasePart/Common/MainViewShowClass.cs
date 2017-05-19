using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelMVPDataBasePart;

namespace ModelMVPDataBasePart.Common
{
    public class MainViewShowClass
    {
        public string EventName { get; private set; }
        public string EventDateTime { get; private set; }
        public string EventDuration { get; private set; }
        public string RepeatType { get; private set; }
        public Nullable<int> ReminderCount { get; private set; }

        private const string MaskToTime = "HH:mm";

        public MainViewShowClass(string EvName, string EvDT, string EvD, Nullable<int> RemCounter)
        {

        }

        public MainViewShowClass(GetViewForNowUser_Result1 InDataItem)
        {
            switch((int)InDataItem.EverywhatRemind)
            {
                case 1:
                    EventDateTime = InDataItem.EventDateTime.ToString(MaskToTime);
                    RepeatType = "Ежедневно";
                    break;
                case 2:
                    EventDateTime = FormatDTToWeekString(InDataItem.EventDateTime);
                    RepeatType = "Еженедельно";
                    break;
                default:
                    EventDateTime = InDataItem.EventDateTime.ToString();
                    break;
            }
            if(InDataItem.EverywhatRemind==1)
            {
                EventDateTime = InDataItem.EventDateTime.ToString(MaskToTime);
            }
            if (InDataItem.EventDuration == null)
            {
                EventDuration = "Не длится";
            }
            else
            {
                EventDuration = InDataItem.EventDuration.ToString();
            }
            EventName = InDataItem.EventName;
            ReminderCount = InDataItem.ReminderCount;
        }

        public static string FormatDTToWeekString(DateTime InDT)
        {
            return InDT.DayOfWeek.ToString()+" " + InDT.ToString(MaskToTime);
        }
    }
}
