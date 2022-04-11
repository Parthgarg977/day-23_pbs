using System;

namespace Day23_problems
{

    public class Contacts
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string email { get; set; }
        public int zip { get; set; }
        public long phoneNumber { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address book");

            PersonsDetails records = new PersonsDetails();
            while (true) 
            {
                Console.WriteLine("\nEnter 1 to Add persons properties");
                Console.WriteLine("Enter 2 for Display of contact");
                Console.WriteLine("Enter 3 to Sort the contact");
                int choice = int.Parse(Console.ReadLine()); // converting into int

                switch (choice)
                {
                    case 1:
                        records.AddRecord();
                        break;
                    case 2:
                        records.DetailsOfPerson();
                        break;
                    case 3:
                        records.SortContact();
                        break;
                    default:
                        Console.WriteLine("Pleasee select valid input");
                        break;

                }
            } 
        }
    }
}
