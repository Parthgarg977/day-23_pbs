using System;
using System.Collections.Generic;
using System.Linq;

namespace Day23_pbs
{
    public class PersonsDetails
    {
        List<Contacts> records = new List<Contacts>();

        public void DetailsOfPerson()
        {
            if (records.Count == 0)
            {
                Console.WriteLine("AddressBook is empty, create new contacts");
            }
            int count = 1;
            foreach (var person in records.ToList())  
            {
                Console.WriteLine("\nRecord - " + count);
                Console.WriteLine("First Name : " + person.firstName);
                Console.WriteLine("Last Name : " + person.lastName);
                Console.WriteLine("Address : " + person.address);
                Console.WriteLine("City : " + person.city);
                Console.WriteLine("State : " + person.state);
                Console.WriteLine("Email : " + person.email);
                Console.WriteLine("Zip code : " + person.zip);
                Console.WriteLine("Phone Number : " + person.phoneNumber);
                count++;

            }
        }

        public void AddRecord() // Adding contacts
        {
            Contacts contact = new Contacts();

            Console.WriteLine("Enter First Name to check Duplication: ");
            string name = Console.ReadLine();

            bool flag = records.Any(x => string.Equals(x.firstName, name));

            if (flag)
            {
                Console.WriteLine("The given Name is already exist");
            }
            else
            {
               Console.WriteLine("No Duplication found ");//if person name not found

                Console.WriteLine("Enter your First Name : ");
                contact.firstName = Console.ReadLine();
                Console.WriteLine("Enter your Last Name : ");
                contact.lastName = Console.ReadLine();
                Console.WriteLine("Enter your Address : ");
                contact.address = Console.ReadLine();
                Console.WriteLine("Enter your City Name : ");
                contact.city = Console.ReadLine();
                Console.WriteLine("Enter your State Name : ");
                contact.state = Console.ReadLine();
                Console.WriteLine("Enter your Zip Code : ");
                contact.zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Phone Number : ");
                contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter your Email Address: ");
                contact.email = Console.ReadLine();

                records.Add(contact);
            }
        }
        public void SortContact()
        {
            List<Contacts> contacts = records.OrderBy(y => y.firstName).ToList();// sorting the list
            Console.WriteLine("Displaying Sorted Contact list in Alphabetic Order");
            int temp = 1;

            foreach (Contacts contact in contacts) //Displaying List
            {
                Console.WriteLine("\nRecord: " + temp);
                Console.WriteLine("First name is: " + contact.firstName);
                Console.WriteLine("Last name is: " + contact.lastName);
                Console.WriteLine("Address : " + contact.address);
                Console.WriteLine("City : " + contact.city);
                Console.WriteLine("State : " + contact.state);
                Console.WriteLine("Email : " + contact.email);
                Console.WriteLine("Zip code : " + contact.zip);
                Console.WriteLine("Phone Number : " + contact.phoneNumber);
                temp++;
            }
        }
    }
}
