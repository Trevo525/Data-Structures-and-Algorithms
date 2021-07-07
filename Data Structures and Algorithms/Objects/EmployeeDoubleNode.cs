using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms.Objects
{
    class EmployeeDoubleNode
    {
        private Employee employee;
        private EmployeeDoubleNode next;
        private EmployeeDoubleNode previous;

        public EmployeeDoubleNode(Employee employee)
        {
            this.employee = employee;
        }

        public Employee GetEmployee()
        {
            return this.employee;
        }

        public void SetEmployee(Employee employee)
        {
            this.employee = employee;
        }

        public EmployeeDoubleNode GetNext()
        {
            return this.next;
        }

        public EmployeeDoubleNode GetPrevious()
        {
            return this.previous;
        }

        public void SetPrevious(EmployeeDoubleNode previous)
        {
            this.previous = previous;
        }

        public void SetNext(EmployeeDoubleNode next)
        {
            this.next = next;
        }

        public override String ToString()
        {
            return employee.ToString();
        }
    }
}
