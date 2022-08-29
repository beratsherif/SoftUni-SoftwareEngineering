using System;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companiesInfo = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "End")
                {
                    break;
                }

                string companyName = input[0];
                string employeeId = input[1];

                if (!companiesInfo.ContainsKey(companyName))
                {
                    companiesInfo.Add(companyName, new List<string>());
                }

                if (companiesInfo[companyName].Contains(employeeId)) continue;

                companiesInfo[companyName].Add(employeeId);
            }

            foreach (var company in companiesInfo)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
