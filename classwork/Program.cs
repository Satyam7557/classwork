using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Bank Account with Balance Validation
            Console.WriteLine("Question 1: Bank Account with Balance Validation");
            BankAccount account = new BankAccount();
            account.Balance = 1000;  // Valid balance
            Console.WriteLine($"Initial Balance: ${account.Balance}");
            account.Balance = -500;  // Invalid balance, will not change
            Console.WriteLine($"Attempted to set negative balance, current balance: ${account.Balance}");
            Console.ReadLine();

            // Question 2: Car with Full Car Name
            Console.WriteLine("Question 2: Car with Full Car Name");
            Car car = new Car { Make = "Toyota", Model = "Camry", Year = 2022 };
            Console.WriteLine($"Full Car Name: {car.FullCarName}");
            Console.ReadLine();

            // Question 3: Person with Full Name in Uppercase
            Console.WriteLine("Question 3: Person with Full Name in Uppercase");
            Person person = new Person { FirstName = "John", LastName = "Doe" };
            Console.WriteLine($"Full Name (Uppercase): {person.FullName}");
            Console.ReadLine();

            // Question 4: Temperature Conversion (Celsius to Fahrenheit)
            Console.WriteLine("Question 4: Temperature Conversion (Celsius to Fahrenheit)");
            Temperature temp = new Temperature { Celsius = 25 };
            Console.WriteLine($"Temperature in Celsius: {temp.Celsius}°C");
            Console.WriteLine($"Temperature in Fahrenheit: {temp.Fahrenheit}°F");
            Console.ReadLine();
        }
    }

    // Question 1: Bank Account with Balance Validation
    public class BankAccount
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                    balance = value;
                else
                    Console.WriteLine("Balance cannot be negative.");
            }
        }
    }

    // Question 2: Car with Full Car Name
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public string FullCarName
        {
            get { return $"{Make} {Model} {Year}"; }
        }
    }

    // Question 3: Person with Full Name in Uppercase
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}".ToUpper(); }
        }
    }

    // Question 4: Temperature Conversion (Celsius to Fahrenheit)
    public class Temperature
    {
        public double Celsius { get; set; }

        public double Fahrenheit
        {
            get { return (Celsius * 9 / 5) + 32; }
        }
    }
}