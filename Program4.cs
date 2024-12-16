using System;
using System.Collections.Generic;

namespace Lecture8.Example4
{
    class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(string name, string position)
        {
            Name = name;
            Position = position;
        }

        public override string ToString()
        {
            return $"{Name} - {Position}";
        }
    }

    class GenericList<T> where T : class
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public void DisplayAll()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var employees = new GenericList<Employee>();

            employees.Add(new Employee("Джордж", "Менеджер"));
            employees.Add(new Employee("Джейн", "Розробник"));

            Console.WriteLine("Employee List:");
            employees.DisplayAll();

            Console.ReadKey();
        }
    }
}

