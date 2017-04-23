using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelMVPDataBasePart;

namespace PresenterLibrary.Common
{
    public class ApplicationController : IApplicationController
    {
        private readonly IContainer ContContainer;

        public DataBaseOperationClass DBClass { get; }

        public ApplicationController(IContainer InContainer)
        {
            DBClass = new DataBaseOperationClass();
            ContContainer = InContainer;
            ContContainer.RegisterInstance<IApplicationController>(this);
        }

        public IApplicationController RegisterInstance<TArgument>(TArgument Instance)
        {
            ContContainer.RegisterInstance(Instance);
            return this;
        }

        public IApplicationController RegisterService<TIService, TImplementation>() where TImplementation : class, TIService
        {
            ContContainer.Register<TIService, TImplementation>();
            return this;
        }

        public IApplicationController RegisterView<TIView, TImplementation>()
            where TIView : IView
            where TImplementation : class, TIView
        {
            ContContainer.Register<TIView, TImplementation>();
            return this;
        }

        public void Run<TPresenter>() where TPresenter:class, IBasePresenter
        {
            if (!ContContainer.IsRegistered<TPresenter>())
                ContContainer.Register<TPresenter>();
            var presenter = ContContainer.Resolve<TPresenter>();
            presenter.Run();
        }

        public void Run<TPresenter,TArgument>(TArgument Arg) where TPresenter:class, IBasePresenter<TArgument>
        {
            if (!ContContainer.IsRegistered<TPresenter>())
                ContContainer.Register<TPresenter>();
            var presenter = ContContainer.Resolve<TPresenter>();
            presenter.Run(Arg);
        }

        public void Run<TPresenter, TArgument1, TArgument2>(TArgument1 Arg1, TArgument2 Arg2) where TPresenter:class, IBasePresenter<TArgument1,TArgument2>
        {
            if (!ContContainer.IsRegistered<TPresenter>())
                ContContainer.Register<TPresenter>();
            var presenter = ContContainer.Resolve<TPresenter>();
            presenter.Run(Arg1, Arg2);
        }
    }
}
