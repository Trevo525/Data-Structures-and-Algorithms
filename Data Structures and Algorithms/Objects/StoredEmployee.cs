using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms.Objects
{
    class StoredEmployee
    {
        public String key;
        public Employee employee;

        public StoredEmployee(String key, Employee employee)
        {
            this.key = key;
            this.employee = employee;
        }
    }
}
