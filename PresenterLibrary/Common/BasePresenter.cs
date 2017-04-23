namespace PresenterLibrary.Common
{

    public abstract class BasePresenter<TView> : IBasePresenter where TView : IView
    {
        protected TView ViewInterface { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresenter(IApplicationController controller, TView InView)
        {
            Controller = controller;
            ViewInterface = InView;
        }

        public void Run()
        {
            ViewInterface.Show();
        }
    }

    public abstract class BasePresenter<TView, TArg>:IBasePresenter<TArg> where TView:IView
    {
        protected TView ViewInterface { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresenter(IApplicationController controller, TView InView)
        {
            Controller = controller;
            ViewInterface = InView;
        }

        public abstract void Run(TArg Arg);
    }

    public abstract class BasePresenter<TView, TArg1, TArg2>:IBasePresenter<TArg1,TArg2> where TView:IView
    {
        protected TView ViewInterface { get; private set; }
        protected IApplicationController Controller { get; private set; }

        protected BasePresenter(IApplicationController controller, TView InView)
        {
            Controller = controller;
            ViewInterface = InView;
        }

        public abstract void Run(TArg1 Arg1, TArg2 Arg2);
    }
}
