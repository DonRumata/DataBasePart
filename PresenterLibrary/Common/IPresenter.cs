using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresenterLibrary.Common;

namespace PresenterLibrary
{
    public interface IBasePresenter
    {
        void Run();
    }

    public interface IBasePresenter<TArg>
    {
        void Run(TArg arg);
    }

    public interface IBasePresenter<TArg1,TArg2>
    {
        void Run(TArg1 arg1, TArg2 arg2);
    }
}
