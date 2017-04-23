using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresenterLibrary.Views
{
    public enum RemindRadioValues:short
    {
        Err=-1,
        RemindInTime=0,
        RemindBefore=1,
        RemindAfter=2,
    }

    public enum EventRepeatRadioValues:short
    {
        Err=-1,
        WithoutRepeat=0,
        EverydayRepeat=1,
        EveryweekRepeat=2,
        EverymonthRepeat=3,
    }
}
