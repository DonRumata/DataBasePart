using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresenterLibrary.Common
{
    public class ArgDepositer<TArg>
    {
        public TArg DataHandler
        {
            get;
            private set;
        }

        public ArgDepositer(TArg InData)
        {
            DataHandler = InData;
        }
    }

    public class ArgDepositer<TFArg, TSArg>
    {
        public TFArg FirstDataHandler
        {
            get;
            private set;
        }

        public TSArg SecondDataHandler
        {
            get;
            private set;
        }

        public ArgDepositer(TFArg InFData, TSArg InSData)
        {
            FirstDataHandler = InFData;
            SecondDataHandler = InSData;
        }
    }
}
