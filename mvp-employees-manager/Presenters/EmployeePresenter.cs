using mvp_employees_manager.Models;
using mvp_employees_manager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace mvp_employees_manager.Presenters
{
    public class EmployeePresenter
    {
        private IEmployeeView _view;

        //Constructor
        public EmployeePresenter(IEmployeeView view)
        {
            _view = view;
            //Subscribe event handler methods to view events
            _view.AddEvent += AddEmployee;
            _view.RemoveEvent += RemoveEmployee;
            _view.ImportEvent += ImportEmployees;
            _view.ExportEvent += ExportEmployees;
            _view.ReadEvent += ReadEmployee;
        }

        private void ReadEmployee(object? sender, EventArgs e)
        {
            EmployeeModel? model = _view.EmployeesList.SelectedItem as EmployeeModel;

            if (model != null)
            {
                _view.EmployeeName = model.Name;
                _view.EmployeeSurname = model.Surname;
                _view.BirthDate = model.BirthDate;
                _view.ContractType = model.ContractType;
                _view.Position = model.Position;
                _view.Salary = model.Salary;
            }
        }

        private void ExportEmployees(object? sender, EventArgs e)
        {
            //Adding records to the list
            List<EmployeeModel> employees = new();
            foreach (var item in _view.EmployeesList.Items)
            {
                employees.Add((EmployeeModel)item);
            }

            //Folder browser dialog windows
            SaveFileDialog saveFileDialog1 = new();
            saveFileDialog1.Filter = "File XML (*.xml)|*.xml";
            saveFileDialog1.Title = "Export employees list as XML";
            string path = string.Empty;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                path = filePath;
            }

            //Serialization
            if (!string.IsNullOrEmpty(path))
            {
                XmlSerializer serializer = new(typeof(List<EmployeeModel>));
                using (FileStream fileStream = new(path, FileMode.Create))
                {
                    serializer.Serialize(fileStream, employees);
                }
            }
        }

        private void ImportEmployees(object? sender, EventArgs e)
        {
            //Folder browser dialog windows
            OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Pliki XML (*.xml)|*.xml";
            openFileDialog.FilterIndex = 0;
            openFileDialog.RestoreDirectory = true;

            string path = string.Empty;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }

            //Deserialization
            if (!string.IsNullOrEmpty(path))
            {
                List<EmployeeModel>? employees;

                XmlSerializer serializer = new(typeof(List<EmployeeModel>));
                using (FileStream fileStream = new(path, FileMode.Open))
                {
                    employees = serializer.Deserialize(fileStream) as List<EmployeeModel>;
                }

                _view.EmployeesList.Items.Clear();
                if (employees != null) 
                {
                    foreach (var employee in employees)
                    {
                        _view.EmployeesList.Items.Add(employee);
                    }
                }
            }
        }

        private void RemoveEmployee(object? sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedObject = _view.EmployeesList.SelectedItems;
            if (_view.EmployeesList.SelectedIndex != -1)
            {
                for (int i = selectedObject.Count - 1; i >= 0; i--)
                    _view.EmployeesList.Items.Remove(selectedObject[i]);
            }
        }

        private void AddEmployee(object? sender, EventArgs e)
        {
            EmployeeModel employee = new(_view.EmployeeName, _view.EmployeeSurname, _view.BirthDate, _view.ContractType, _view.Position, _view.Salary);
            _view.EmployeesList.Items.Add(employee);
        }
    }
}
