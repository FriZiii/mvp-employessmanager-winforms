namespace mvp_employees_manager.Models
{
    public class EmployeeModel
    {
        //Fields
        private string employeeName;
        private string employeeSurname;
        private DateTime birthDate;
        private string contractType;
        private string position;
        private decimal salary;

        //Constructor
        public EmployeeModel()
        {
        }
        public EmployeeModel(string employeeName, string employeeSurname, DateTime birthDate, string contractType, string position, decimal salary)
        {
            Name = employeeName;
            Surname = employeeSurname;
            this.birthDate = birthDate;
            ContractType = contractType;
            Position = position;
            this.salary = salary;
        }

        //Properties
        public string Name 
        {
            get { return employeeName; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentNullException(paramName: nameof(Name), message: "Name cannot be empty!");

                employeeName = value;
            }
        }
        public string Surname
        {
            get { return employeeSurname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException(paramName: nameof(Surname), message: "Surname cannot be empty!");

                employeeSurname = value;
            }
        }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string ContractType
        {
            get { return contractType; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException(paramName: nameof(ContractType), message: "Contract type is required!");

                contractType = value; 
            }
        }
        public string Position
        {
            get { return position; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException(paramName: nameof(Position), message: "Position cannot be empty!");

                position = value;
            }
        }
        public decimal Salary { get => salary; set => salary = value; }

        //Methods
        public override string ToString()
        {
            return $"{employeeName}, {employeeSurname}, {birthDate}, {contractType}, {position}, {salary}";
        }
    }
}
