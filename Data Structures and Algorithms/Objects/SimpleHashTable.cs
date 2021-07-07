using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms.Objects
{
    class SimpleHashTable
    {
        private StoredEmployee[] hashtable;

        public SimpleHashTable()
        {
            hashtable = new StoredEmployee[10];
        }

        public void Put(String key, Employee employee)
        {
            int hashedKey = HashKey(key);

            // linear probing
            if (Occupied(hashedKey))
            {
                int stopIndex = hashedKey;
                if (hashedKey == hashtable.Length - 1)
                {
                    hashedKey = 0;
                }
                else
                {
                    hashedKey++;
                }

                while (Occupied(hashedKey) && hashedKey != stopIndex)
                {
                    hashedKey = (hashedKey + 1) % hashtable.Length;
                }
            }

            if (Occupied(hashedKey))
            {
                Console.WriteLine("Sorry, there is already an employee at position " + hashedKey);
            }
            else
            {
                hashtable[hashedKey] = new StoredEmployee(key, employee);
            }
        }

        public Employee Get(String key)
        {
            int hashedKey = FindKey(key);

            if (hashedKey == -1)
            {
                return null;
            }
            return hashtable[hashedKey].employee;
        }

        public Employee Remove(String key)
        {
            int hashedKey = FindKey(key);
            if (hashedKey == -1)
            {
                return null;
            }

            Employee employee = hashtable[hashedKey].employee;
            hashtable[hashedKey] = null;

            StoredEmployee[] oldHashtable = hashtable;
            hashtable = new StoredEmployee[oldHashtable.Length];
            for (int i = 0; i < oldHashtable.Length; i++)
            {
                if (oldHashtable[i] != null)
                {
                    Put(oldHashtable[i].key, oldHashtable[i].employee);
                }
            }

            return employee;
        }

        private int FindKey(String key)
        {
            int hashedKey = HashKey(key);
            if (hashtable[hashedKey] != null && hashtable[hashedKey].key.Equals(key))
            {
                return hashedKey;
            }

            int stopIndex = hashedKey;
            if (hashedKey == hashtable.Length - 1)
            {
                hashedKey = 0;
            }
            else
            {
                hashedKey++;
            }

            while (hashedKey != stopIndex && hashtable[hashedKey] != null && !hashtable[hashedKey].key.Equals(key))
            {
                hashedKey = (hashedKey + 1) % hashtable.Length;
            }

            if (hashtable[hashedKey] != null && hashtable[hashedKey].key.Equals(key))
            {
                return hashedKey;
            }
            else
            {
                return -1;
            }
        }

        private int HashKey(String key)
        {
            return key.Length % hashtable.Length;
        }

        private bool Occupied(int index)
        {
            return hashtable[index] != null;
        }

        public void PrintHashTable()
        {
            for (int i = 0; i < hashtable.Length; i++)
            {
                if (hashtable[i] == null)
                {
                    Console.WriteLine("empty");
                }
                else
                {
                    Console.WriteLine("Position " + i + ": " + hashtable[i].employee);
                }
            }
            Console.WriteLine();
        }
    }
}
