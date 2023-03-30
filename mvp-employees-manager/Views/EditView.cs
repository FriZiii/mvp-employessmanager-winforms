namespace mvp_employees_manager.Views
{
    public partial class EditView : Form, IEditView
    {
        //Constructor
        public EditView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }
        private void AssociateAndRaiseViewEvents()
        {
            btnConfirm.Click += delegate { ConfirmEvent?.Invoke(this, EventArgs.Empty); };
            btnCancel.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
        }

        //Poperties
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
                foreach (System.Windows.Forms.RadioButton rb in Controls.OfType<System.Windows.Forms.RadioButton>())
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
                foreach (System.Windows.Forms.RadioButton rb in Controls.OfType<System.Windows.Forms.RadioButton>())
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

        //Methods
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

        //Events
        public event EventHandler ConfirmEvent;
        public event EventHandler CancelEvent;

        //Singleton pattern
        private static EditView instance;
        public static EditView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new EditView();
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
