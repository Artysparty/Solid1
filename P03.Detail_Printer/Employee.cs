using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class Employee : IReport {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine(Name);
        }
    }
}
