using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMVPDataBasePart.Common
{
    public class RemindDataCreator
    {
        public DateTime RemindDate { get; private set; }
        public DateTime RemindUntil { get; private set; }
        public TimeSpan TimeUntilNextRemind { get; private set; } //TODO
        public int HowToRemind { get; private set; }

        public RemindDataCreator(DateTime Reminddate, DateTime Reminduntil, int HowToremind)
        {
            RemindDate = Reminddate;
            RemindUntil = Reminduntil;
            HowToRemind = HowToremind;
        }
    }
}
