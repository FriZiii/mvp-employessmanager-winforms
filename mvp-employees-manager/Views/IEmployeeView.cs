namespace mvp_employees_manager.Views
{
    public interface IEmployeeView
    {
        //Properties
        string EmployeeName { get; set; }
        string EmployeeSurname { get; set; }
        DateTime BirthDate { get; set; }
        string ContractType { get; set; }
        string Position { get; set; }
        decimal Salary { get; set; }
        ListBox EmployeesList { get; set; }

        //Events
        event EventHandler AddEvent;
        event EventHandler RemoveEvent;
        event EventHandler ExportEvent;
        event EventHandler ImportEvent;
        event EventHandler ReadEvent;


        //Methods
        public void ShowNameError(string message);
        public void ShowSurnameError(string message);
        void ShowContractTypeError(string message);
        void ShowPositionError(string message);

        void HideNameError();
        void HideSurnameError();
        void HideContractTypeError();
        void HidePositionError();
        void ClearAllError();
    }
}
