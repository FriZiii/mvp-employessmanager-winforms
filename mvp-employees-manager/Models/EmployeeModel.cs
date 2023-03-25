using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp_employees_manager.Models
{
    public class EmployeeModel
    {
        private string employeeName;
        private string employeeSurname;
        private DateTime birthDate;
        private string contractType;
        private string position;
        private decimal salary;

        public EmployeeModel()
        {
        }

        public EmployeeModel(string employeeName, string employeeSurname, DateTime birthDate, string contractType, string position, decimal salary)
        {
            this.employeeName = employeeName;
            this.employeeSurname = employeeSurname;
            this.birthDate = birthDate;
            this.contractType = contractType;
            this.position = position;
            this.salary = salary;
        }

        public string Name { get => employeeName; set => employeeName = value; }
        public string Surname { get => employeeSurname; set => employeeSurname = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string ContractType { get => contractType; set => contractType = value; }
        public string Position { get => position; set => position = value; }
        public decimal Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return $"{employeeName}, {employeeSurname}, {birthDate}, {contractType}, {position},{salary}";
        }
    }
}
