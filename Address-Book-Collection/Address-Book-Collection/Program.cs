using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_Collection
{
    class Program
    {
        AddressBook obj = new AddressBook();//Creating Object of Addressbook class
        static void Main(string[] args)
        {
            Console.WriteLine("++++++++++++Welcome in Address book Collection+++++++++++");

            ///create dictionary and 
            ///Dict is name of dictionary
            /////string is Tkey and AddressBook is TValue.
            Dictionary<string, AddressBook> Dict = new Dictionary<string, AddressBook>();
            //Adding Bool Variable
            bool ProgramIsRunning = true;

            Console.WriteLine("\nHow many address Book want you to create : ");
            //store and convert into int using numAdressBooks variable.
            int numAddressBooks = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numAddressBooks; i++)
            {
                Console.WriteLine("Enter the name of address book " + i + ": ");
                string bookName = Console.ReadLine();
                //creating object of AddressBook class
                AddressBook addressBook = new AddressBook();
                //Add element in dictionary 
                Dict.Add(bookName, addressBook); 
            }
            Console.WriteLine("\nYou have created following Address Books : ");
            //for item in Dictionary
            foreach (var item in Dict)
            {
                Console.WriteLine("{0}", item.Key);
            }
            while (ProgramIsRunning)
            {
                Console.WriteLine("\nChoose option to procced further \n1.Add Contact \n2.Edit Contact \n3.Delete Contact  \n4.Display Contacts \n5.Exit");
                ///store and convert into int using choice variable
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter Existing Address Book Name for adding contacts");
                        string contactName = Console.ReadLine();
                        if (Dict.ContainsKey(contactName))
                        {
                            Console.WriteLine("\nEnter the number of contacts you want to add in address book");
                            int numberOfContacts = Convert.ToInt32(Console.ReadLine());
                            for (int i = 1; i <= numberOfContacts; i++)
                            {
                                addContactBook(Dict[contactName]);
                            }
                            Dict[contactName].displayPerson();
                        }
                        else
                        {
                            Console.WriteLine("No AddressBook exist with name {0}", contactName);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Address Book Name for edit contact");
                        string editcontactName = Console.ReadLine();
                        if (Dict.ContainsKey(editcontactName))
                        {
                            Dict[editcontactName].editPerson();
                            Dict[editcontactName].displayPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", editcontactName);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nEnter Address Book Name for delete contact");
                        string deleteContact = Console.ReadLine();
                        if (Dict.ContainsKey(deleteContact))
                        {
                            Dict[deleteContact].deletePerson();
                            Dict[deleteContact].displayPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", deleteContact);
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nEnter Address Book Name for display contacts");
                        string displayContactsInAddressBook = Console.ReadLine();
                        Dict[displayContactsInAddressBook].displayPerson();
                        break;
                    case 5:
                        ProgramIsRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter valid option");
                        break;
                }
            }

            void addContactBook(AddressBook addressBook)
            {
                Console.WriteLine("Enter First Name : ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name : ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Address : ");
                string address = Console.ReadLine();
                Console.WriteLine("Enter City : ");
                string city = Console.ReadLine();
                Console.WriteLine("Enter State : ");
                string state = Console.ReadLine();
                Console.WriteLine("Enter Phone Number : ");
                long phoneNumber = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter Email id :");
                string email = Console.ReadLine();
                addressBook.AddContact(firstName, lastName, address, city, state, phoneNumber, email);
            }
        }
    }
}
