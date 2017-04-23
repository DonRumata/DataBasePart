using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelMVPDataBasePart.Common;

namespace PresenterLibrary.Common
{
    public interface IApplicationController
    {
        ModelMVPDataBasePart.DataBaseOperationClass DBClass { get; }

        IApplicationController RegisterView<TIView, TImplementation>()
            where TImplementation : class, TIView
            where TIView : IView;

        IApplicationController RegisterInstance<TArgument>(TArgument Instance);

        IApplicationController RegisterService<TIService, TImplementation>()
            where TImplementation : class, TIService;

        void Run<TPresenter>()
            where TPresenter : class, IBasePresenter;

        void Run<TPresenter, TArgument>(TArgument Arg) 
            where TPresenter : class, IBasePresenter<TArgument>;

        void Run<TPresenter, TArgument1, TArgument2>(TArgument1 Arg1, TArgument2 Arg2)
            where TPresenter : class, IBasePresenter<TArgument1, TArgument2>;
    }
}
