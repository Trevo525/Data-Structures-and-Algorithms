using Data_Structures_and_Algorithms.Objects;
using System;
using System.Collections.Generic;
using System.Collections;

namespace Data_Structures_and_Algorithms
{
    class HashTables
    {
        internal static void ArrayImplementation()
        {
            Employee janeJones = new Employee("Jane", "Jones", 123);
            Employee johnDoe = new Employee("John", "Doe", 4567);
            Employee marySmith = new Employee("Mary", "Smith", 22);
            Employee mikeWilson = new Employee("Mike", "Wilson", 3245);
            Employee billEnd = new Employee("Bill", "End", 78);
            // Employee zachGalifianakis = new Employee("Zach", "Galifianakis", 69);

            SimpleHashTable ht = new SimpleHashTable();
            ht.Put(janeJones.GetLastName(), janeJones);
            ht.Put(johnDoe.GetLastName(), johnDoe);
            ht.Put(marySmith.GetLastName(), marySmith);
            ht.Put(mikeWilson.GetLastName(), mikeWilson);
            ht.Put(billEnd.GetLastName(), billEnd);
            // ht.Put(zachGalifianakis.GetLastName(), zachGalifianakis);

            Console.WriteLine("Print table (sorted by last name): ");
            ht.PrintHashTable();

            Console.WriteLine("Retrieve key Wilson: " + ht.Get("Wilson"));
            Console.WriteLine("Retrieve key Smith: " + ht.Get("Smith"));

            ht.Remove("Wilson");
            ht.Remove("Jones");

            Console.WriteLine("Print table after Wilson and Smith removed: ");
            ht.PrintHashTable();

            Console.WriteLine("Retrieve key Smith: " + ht.Get("Smith"));
        }

        internal static void ChainedHashTable()
        {
            Employee janeJones = new Employee("Jane", "Jones", 123);
            Employee johnDoe = new Employee("John", "Doe", 4567);
            Employee marySmith = new Employee("Mary", "Smith", 22);
            Employee mikeWilson = new Employee("Mike", "Wilson", 3245);
            Employee billEnd = new Employee("Bill", "End", 78);
            Employee zachGalifianakis = new Employee("Zach", "Galifianakis", 69);

            ChainedHashTable ht = new ChainedHashTable();
            ht.Put(janeJones.GetLastName(), janeJones);
            ht.Put(johnDoe.GetLastName(), johnDoe);
            ht.Put(marySmith.GetLastName(), marySmith);
            ht.Put(mikeWilson.GetLastName(), mikeWilson);
            ht.Put(billEnd.GetLastName(), billEnd);
            ht.Put(zachGalifianakis.GetLastName(), zachGalifianakis);

            ht.PrintHashTable();

            Console.WriteLine("Retrieve key Wilson: " + ht.Get("Wilson"));
            Console.WriteLine("Retrieve key Smith: " + ht.Get("Smith"));

            ht.Remove("Wilson");
            ht.Remove("Jones");

            ht.PrintHashTable();

            Console.WriteLine("Retrieve key Smith: " + ht.Get("Smith"));

            ht.PrintHashTable();
        }

        internal static void BucketSort()
        {
            int[] intArray = { 54, 46, 83, 66, 95, 92, 43 };

            BucketSort(intArray);

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }
        private static void BucketSort(int[] input)
        {
            ArrayList[] buckets = new ArrayList[10];
            //LinkedList<int>[] buckets = new LinkedList<int>[10];

            for (int i = 0; i < buckets.Length; i++)
            {
                // using ArrayLists for the buckets
                buckets[i] = new ArrayList();
                // using LinkedLists for the buckets
                //buckets[i] = new LinkedList<int>();
            }

            // scattering phase
            for (int i = 0; i < input.Length; i++)
            {
                buckets[Hash(input[i])].Add(input[i]);
            }

            // sort into buckets
            foreach (ArrayList bucket in buckets)
            {
                bucket.Sort();
            }

            // gathering phase
            int j = 0;
            for (int i = 0; i < buckets.Length; i++)
            {
                foreach (int value in buckets[i])
                {
                    input[j++] = value;
                }
            }
        }

        private static int Hash(int value)
        {
            return value / (int)10;
        }
    }
}
