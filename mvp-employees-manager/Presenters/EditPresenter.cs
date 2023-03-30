using mvp_employees_manager.Models;
using mvp_employees_manager.Views;

namespace mvp_employees_manager.Presenters
{
    public class EditPresenter
    {
        //Fields
        private IEditView _editView;
        private ListBox _listBox;
        private int _index;

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
                if (error.ParamName == "Name")
                {
                    _editView.ShowNameError(errorMessage);
                }
                else
                {
                    _editView.HideNameError();
                }

                if (error.ParamName == "Surname")
                {
                    _editView.ShowSurnameError(errorMessage);
                }
                else
                {
                    _editView.HideSurnameError();
                }

                if (error.ParamName == "ContractType")
                {
                    _editView.ShowContractTypeError(errorMessage);
                }
                else
                {
                    _editView.HideContractTypeError();
                }

                if (error.ParamName == "Position")
                {
                    _editView.ShowPositionError(errorMessage);
                }
                else
                {
                    _editView.HidePositionError();
                }
            }
        }

        private void CancelEdit(object? sender, EventArgs e)
        {
            _editView.Close();
        }

    }
}
