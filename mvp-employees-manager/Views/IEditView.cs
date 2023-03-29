namespace mvp_employees_manager.Views
{
    public interface IEditView
    {
        //Properties
        string EmployeeName { get; set; }
        string EmployeeSurname { get; set; }
        DateTime BirthDate { get; set; }
        string ContractType { get; set; }
        string Position { get; set; }
        decimal Salary { get; set; }

        //Events
        event EventHandler ConfirmEvent;
        event EventHandler CancelEvent;

        //Methods
        void Show();
        void Close();
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
