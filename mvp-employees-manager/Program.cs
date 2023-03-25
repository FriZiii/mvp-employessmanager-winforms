using mvp_employees_manager.Presenters;
using mvp_employees_manager.Models;
using mvp_employees_manager.Views;

namespace mvp_employees_manager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            IEmployeeView view = new EmployeeView();
            _ = new EmployeePresenter(view);
            Application.Run((Form)view);
        }
    }
}