using mvp_employees_manager.Models;
using mvp_employees_manager.Views;

namespace mvp_employees_manager.Presenters
{
    public class EditPresenter
    {
        //Fields
        private readonly IEditView _editView;
        private readonly ListBox _listBox;
        private readonly int _index;

        //Constructor
        public EditPresenter(IEditView editView, int index, ref ListBox listBox)
        {
            //Fields
            _editView = editView;
            _listBox = listBox;
            _index = index;

            //Subscribe event handler methods to view events
            _editView.ConfirmEvent += ConfirmEdit;
            _editView.CancelEvent += CancelEdit;

            _editView.Show();
        }
        
        //Methods
        private void ConfirmEdit(object? sender, EventArgs e)
        {
            try
            {
                EmployeeModel employee = new(_editView.EmployeeName, _editView.EmployeeSurname, _editView.BirthDate, _editView.ContractType, _editView.Position, _editView.Salary);
                _listBox.Items[_index] = employee;
                _editView.ClearAllError();
                _editView.Close();
            }
            catch (ArgumentNullException error)
            {
                string errorMessage = error.Message[..(error.Message.IndexOf("!") + 1)];
                _editView.GetType().GetMethod($"Show{error.ParamName}Error")?.Invoke(_editView, new object[] {errorMessage} );

                foreach(EmployeeModel.ErrorTypes errorType in Enum.GetValues(typeof(EmployeeModel.ErrorTypes)))
                {
                    if(errorType.ToString() != error.ParamName)
                        _editView.GetType().GetMethod($"Hide{errorType}Error")?.Invoke(_editView, null);
                }
            }
        }

        private void CancelEdit(object? sender, EventArgs e)
        {
            _editView.Close();
        }

    }
}
