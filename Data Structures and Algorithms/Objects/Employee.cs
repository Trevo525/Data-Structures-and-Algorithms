using System;

namespace Data_Structures_and_Algorithms.Objects
{
    class Employee : IEquatable<Employee>
    {
        private String firstName;
        private String lastName;
        private int id;

        public Employee(String firstName, String lastName, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }


        public String GetFirstName()
        {
            return this.firstName;
        }

        public void SetFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public String GetLastName()
        {
            return this.lastName;
        }

        public void SetLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public int GetId()
        {
            return this.id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public int HashCode()
        {
            return this.GetHashCode();
        }


        public override String ToString()
        {
            return "Employee{" +
                " firstName='" + GetFirstName() + "'" +
                ", lastName='" + GetLastName() + "'" +
                ", id='" + GetId() + "'" +
                "}";
        }

        public bool Equals(Employee other)
        {
            return other != null &&
                   firstName == other.firstName &&
                   lastName == other.lastName &&
                   id == other.id;
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;
            if (!(typeof(Employee).IsInstanceOfType(obj))) {
                return false;
            }
            Employee employee = (Employee)obj;
            return this.Equals(employee);
        }

        public override int GetHashCode()
        {
            return System.HashCode.Combine(firstName, lastName, id);
        }
    }
}
