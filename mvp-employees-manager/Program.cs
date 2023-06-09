using mvp_employees_manager.Presenters;
using mvp_employees_manager.Views;

namespace mvp_employees_manager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            IEmployeeView view = new EmployeeView();
            _ = new EmployeePresenter(view);
            Application.Run((Form)view);
        }
    }
}