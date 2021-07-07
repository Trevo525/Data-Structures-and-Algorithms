using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms.Objects
{
    class ChainedHashTable
    {
        private LinkedList<StoredEmployee>[] hashtable;

        public ChainedHashTable()
        {
            hashtable = new LinkedList<StoredEmployee>[10];
            for (int i = 0; i < hashtable.Length; i++)
            {
                hashtable[i] = new LinkedList<StoredEmployee>();
            }
        }

        public void Put(String key, Employee employee)
        {
            int hashedKey = HashKey(key);
            hashtable[hashedKey].AddLast(new StoredEmployee(key, employee));
        }

        public Employee Get(String key)
        {
            int hashedKey = HashKey(key);
            LinkedListNode<StoredEmployee> currEmp = hashtable[hashedKey].First;

            StoredEmployee employee = null;
            while (currEmp != null)
            {
                employee = currEmp.Value;
                if (employee.key.Equals(key))
                {
                    return employee.employee;
                }
                currEmp = currEmp.Next;
            }
            return null;
        }

        public Employee Remove(String key)
        {
            int hashedKey = HashKey(key);
            LinkedListNode<StoredEmployee> currEmp = hashtable[hashedKey].First;

            StoredEmployee employee = null;
            int index = -1;
            while (currEmp != null)
            {
                employee = currEmp.Value;
                index++;
                if (employee.key.Equals(key))
                {
                    break;
                }
                currEmp = currEmp.Next;
            }

            if (employee == null || !employee.key.Equals(key))
            {
                return null;
            }
            else
            {
                hashtable[hashedKey].Remove(currEmp);
                return employee.employee;
            }
        }

        private int HashKey(String key)
        {
            // return key.Length() % hashtable.Length;

            return Math.Abs(key.GetHashCode() % hashtable.Length);
        }

        public void PrintHashTable()
        {
            for (int i = 0; i < hashtable.Length; i++)
            {
                if (hashtable[i].Count == 0)
                {
                    Console.WriteLine("Position " + i + ": empty");
                }
                else
                {
                    Console.Write("Position " + i + ": ");
                    LinkedListNode<StoredEmployee> currEmp = hashtable[i].First;

                    StoredEmployee employee = null;
                    while (currEmp != null)
                    {
                        employee = currEmp.Value;
                        Console.Write(employee.employee);
                        Console.Write(" <=> ");
                        currEmp = currEmp.Next;
                    }

                    Console.WriteLine("null");
                }
            }
            Console.WriteLine();
        }
    }
}
