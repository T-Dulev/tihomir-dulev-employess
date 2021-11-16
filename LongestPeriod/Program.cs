using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LongestPeriod
{
    class Program
    {
        static void Main(string[] args)
        {
            string file;

            Console.Write("Enter your file data: ");
            file = Console.ReadLine();

            if (!File.Exists(file))
            {
                Console.WriteLine("Missing file!");
                return;
            }

            var employess = new List<Employee>(Employee.ReadFromFile(file));

            var resJoin = new List<JoinEmployess>(JoinEmployess.JoinEmp(employess));
      
            var res = JoinEmployess.GetMaxInterval(resJoin);

            Console.WriteLine("Longest period: EmpId1={0}, EmpId2={1}, DaysWorked={2}", res.EmpFirstId, res.EmpSecondId, res.DaysWorked);
        }
    }
}
