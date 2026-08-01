using SOLIDPrinciple.OpenClose.Applicants;
using System;
using System.Collections.Generic;

namespace SOLIDPrinciple.OpenClose
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Applicants.ApplicantAbstract> applicants = new List<Applicants.ApplicantAbstract>()
            {
                new Person(){ FirstName="Ashutosh", LastName="Nigam" },
                new Manager(){FirstName="Ritam", LastName= "Nigam"},
                new JoniorDeveloper(){FirstName="Jon", LastName="Dev"}
            };
            List<EmployeeModel> employees = new List<EmployeeModel>();
            foreach (var app in applicants)
            {
                employees.Add(app.AccountManager.CreateEmployee(app));
            }
            foreach (var item in employees)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
