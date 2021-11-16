using System;
using System.Collections.Generic;
using System.IO;

public class Employee
{
    public int EmpId { get; set; }

    public int ProjectId { get; set; }

    public DateTime DateFrom { get; set; }

    public DateTime DateTo { get; set; }

    public static List<Employee> ReadFromFile (string file)
    {
        string[] lines = File.ReadAllLines(file);
        char[] delimiterChars = { ' ', ',' };

        var employess = new List<Employee>();

        foreach (var line in lines)
        {
            string[] words = line.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

            int emplId = int.Parse(words[0]);
            int projectId = int.Parse(words[1]);
            DateTime dateFrom = DateTime.Parse(words[2]);
            var dateTo = String.Equals(words[3].ToUpper(), "NULL") ? DateTime.Today : DateTime.Parse(words[3]);

            employess.Add(new Employee
            {
                EmpId = emplId,
                ProjectId = projectId,
                DateFrom = dateFrom,
                DateTo = dateTo
            });
        }

        return employess;
    }

    public int MatchingPeriod (Employee employee)
    {
        if (this.DateFrom <= employee.DateFrom && employee.DateTo <= this.DateTo)
        {
            return employee.DateTo.Subtract(employee.DateFrom).Days + 1;
        }
        else if (employee.DateFrom <= this.DateFrom && this.DateTo <= employee.DateTo)
        {
            return this.DateTo.Subtract(this.DateFrom).Days + 1;
        }
        else if (this.DateFrom <= employee.DateTo && employee.DateTo <= this.DateTo)
        {
            return employee.DateTo.Subtract(this.DateFrom).Days + 1;
        }
        else if (employee.DateFrom <= this.DateTo && this.DateTo <= employee.DateTo)
        {
            return this.DateTo.Subtract(employee.DateFrom).Days + 1;
        }
        else
        {
            return 0;
        }
    }
}