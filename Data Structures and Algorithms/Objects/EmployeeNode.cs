using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms.Objects
{
    class EmployeeNode
    {
        private Employee employee;
        private EmployeeNode next;

        public EmployeeNode(Employee employee)
        {
            this.employee = employee;
        }

        public Employee getEmployee()
        {
            return this.employee;
        }

        public void setEmployee(Employee employee)
        {
            this.employee = employee;
        }

        public EmployeeNode getNext()
        {
            return this.next;
        }

        public void SetNext(EmployeeNode next)
        {
            this.next = next;
        }

        public override String ToString()
        {
            return employee.ToString();
        }
    }
}
