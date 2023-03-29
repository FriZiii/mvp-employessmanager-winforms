namespace mvp_employees_manager.Views
{
    public partial class EmployeeView : Form, IEmployeeView
    {
        //Constructor
        public EmployeeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        //Methods
        private void AssociateAndRaiseViewEvents()
        {
            //Events
            btnAdd.Click += delegate { AddEvent?.Invoke(this, EventArgs.Empty); };
            btnRemove.Click += delegate { RemoveEvent?.Invoke(this, EventArgs.Empty); };
            listEmployees.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Delete)
                {
                    RemoveEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            btnEdit.Click += delegate { EditEvent?.Invoke(this, EventArgs.Empty); };
            btnExport.Click += delegate { ExportEvent?.Invoke(this, EventArgs.Empty); };
            btnImport.Click += delegate { ImportEvent?.Invoke(this, EventArgs.Empty); };
            listEmployees.SelectedIndexChanged += delegate { ReadEvent?.Invoke(this, EventArgs.Empty); };
        }

        public void ShowNameError(string message)
        {
            errorProvider.SetError(tbName, message);
        }

        public void HideNameError()
        {
            errorProvider.SetError(tbName, string.Empty);
        }

        public void ShowSurnameError(string message)
        {
            errorProvider.SetError(tbSurname, message);
        }

        public void HideSurnameError()
        {
            errorProvider.SetError(tbSurname, string.Empty);
        }

        public void ShowContractTypeError(string message)
        {
            errorProvider.SetError(labelTypeOfContract, message);
        }

        public void HideContractTypeError()
        {
            errorProvider.SetError(labelTypeOfContract, string.Empty);
        }

        public void ShowPositionError(string message)
        {
            errorProvider.SetError(cbPosition, message);
        }

        public void HidePositionError()
        {
            errorProvider.SetError(cbPosition, string.Empty);
        }

        public void ClearAllError()
        {
            errorProvider.Clear();
        }

        //Properties
        public string EmployeeName
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }
        public string EmployeeSurname
        {
            get { return tbSurname.Text; }
            set { tbSurname.Text = value; }
        }
        public DateTime BirthDate
        {
            get { return tbDate.Value; }
            set { tbDate.Value = value; }
        }
        public string ContractType
        {
            get
            {
                foreach (System.Windows.Forms.RadioButton rb in leftBar.Controls.OfType<System.Windows.Forms.RadioButton>())
                {
                    if (rb.Checked)
                    {
                        return rb.Text;
                    }
                }
                return string.Empty;
            }
            set
            {
                string radioButtonTextToCheck = value;
                foreach (System.Windows.Forms.RadioButton rb in leftBar.Controls.OfType<System.Windows.Forms.RadioButton>())
                {
                    if (rb.Text == radioButtonTextToCheck)
                    {
                        rb.Checked = true;
                        break;
                    }
                }
            }
        }
        public string Position
        {
            get { return cbPosition.Text; }
            set { cbPosition.Text = value; }
        }
        public decimal Salary
        {
            get { return numSalary.Value; }
            set { numSalary.Value = value; }
        }
        public ListBox EmployeesList
        {
            get { return listEmployees; }
            set { listEmployees = value; }
        }

        //Events
        public event EventHandler AddEvent;
        public event EventHandler RemoveEvent;
        public event EventHandler EditEvent;
        public event EventHandler ExportEvent;
        public event EventHandler ImportEvent;
        public event EventHandler ReadEvent;
    }
}
