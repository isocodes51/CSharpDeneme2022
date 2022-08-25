using System;

namespace ReferansClassTips
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);
            Customer customer = new Customer();
            Employee employee = new Employee();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }

    class Customer:Person
    {
        public string CreditCartNumber { get; set; }
    }
    
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
}
