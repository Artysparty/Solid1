using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
            List<string> gg = new List<string>();
            gg.Add("asd");
            gg.Add("dfs");
            gg.Add("gfh");
            gg.Add("ghk");
            
            Employee em1 = new Employee("em1 name");
            Employee em2 = new Employee("em2 name");
            Employee em3 = new Employee("em3 name");
            Employee em4 = new Employee("em4 name");

            List<Employee> employees = new List<Employee>();
            employees.Add(em1);
            employees.Add(em2);
            employees.Add(em3);
            employees.Add(em4);

            Manager mg = new Manager("manager Name", gg);

            DetailsPrinter dp = new DetailsPrinter(employees);
            dp.PrintDetails();
        }
    }
}
