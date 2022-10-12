using System;
using System.Collections.Generic;

namespace MultiCastDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee rachana = new Employee("Rachana", 923);
            Employee keerthu = new Employee("Keerthana", 131);
            Employee guddu = new Employee("Guddu", 88);

            Manager rajdeep = new Manager("Rajdeep", 913, new List<int> {923, 131, 88 });

            Employee arpana = new Employee("Arpana", 1113);
            Employee dhebu = new Employee("Divyaansh", 0723);
            Manager diploo = new Manager("Diploo", 1120, new List<int> { 1113, 0723 });

            Report.PublishReport();
        }
    }

    class Manager
    {
        private string Name { get; set; }
        private int ID { get; set; }

        private List<int> ManageIDs { get; set; }
        public Manager(string name, int iD, List<int> manageIds)
        {
            Name = name;
            ID = iD;
            ManageIDs = manageIds;
            Report.ReportInfo += PublishReport;
        }

        private void PublishReport()
        {
            Console.WriteLine("My Name is {0} and my ID is {1} and I manage:",this.Name,this.ID);
            foreach (int id in ManageIDs)
            {
                Console.WriteLine("Employee Id: {0}", id);
            }
        }
    }

    class Employee
    {
        private string Name { get; set; }
        private int ID { get; set; }

        public Employee(string name, int iD)
        {
            Name = name;
            ID = iD;
            Report.ReportInfo+=PublishReport;
        }

        private void PublishReport()
        {
            Console.WriteLine("My Name is {0} and my ID is {1} and I manage:", this.Name, this.ID);
        }
    }
    class Report
    {
        public delegate void ReportDelegate();

        public static event ReportDelegate ReportInfo;

        public static void PublishReport()
        {
            if(ReportInfo != null)
            {
                Console.WriteLine("Publishing Report...");
                ReportInfo();
            }
        }

    }
}
