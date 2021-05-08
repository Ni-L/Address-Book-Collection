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

            //Create dictionary and 
            ///myDict is name of dictionary
            Dictionary<string, AddressBook> myDict = new Dictionary<string, AddressBook>();//string is Tkey and AddressBook is TValue.
            bool ProgramIsRunning = true;

            Console.WriteLine("\nHow many address Book you want to create : ");
            int numAddressBooks = Convert.ToInt32(Console.ReadLine()); //store and convert into int using numAdressBooks variable.

            for (int i = 1; i <= numAddressBooks; i++)
            {
                Console.WriteLine("Enter the name of address book " + i + ": ");
                string bookName = Console.ReadLine();
                AddressBook addressBook = new AddressBook(); //creating object of AddressBook class
                myDict.Add(bookName, addressBook); //add element in dictionary
            }
            Console.WriteLine("\nYou have created following Address Books : ");
            foreach (var item in myDict) //var is used and it is store any data type value.
            {
                Console.WriteLine("{0}", item.Key);
            }
            while (ProgramIsRunning)
            {
                Console.WriteLine("\nChoose option \n1.Add Contact \n2.Edit Contact \n3.Delete Contact  \n4.Display Contacts \n5.Search Person By City & State \n6.Display Contacts Same City \n7.Display Contacts Same State \n8.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter Existing Address Book Name for adding contacts");
                        string contactName = Console.ReadLine();
                        if (myDict.ContainsKey(contactName))
                        {
                            Console.WriteLine("\nEnter the number of contacts you want to add in address book");
                            int numberOfContacts = Convert.ToInt32(Console.ReadLine());
                            for (int i = 1; i <= numberOfContacts; i++)
                            {
                                addContactBook(myDict[contactName]);
                            }
                            myDict[contactName].displayPerson();
                        }
                        else
                        {
                            Console.WriteLine("No AddressBook exist with name {0}", contactName);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Address Book Name for edit contact");
                        string editcontactName = Console.ReadLine();
                        if (myDict.ContainsKey(editcontactName))
                        {
                            myDict[editcontactName].editPerson();
                            myDict[editcontactName].displayPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", editcontactName);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nEnter Address Book Name for delete contact");
                        string deleteContact = Console.ReadLine();
                        if (myDict.ContainsKey(deleteContact))
                        {
                            myDict[deleteContact].deletePerson();
                            myDict[deleteContact].displayPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", deleteContact);
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nEnter Address Book Name for display contacts");
                        string displayContactsInAddressBook = Console.ReadLine();
                        myDict[displayContactsInAddressBook].displayPerson();
                        break;
                    case 5:
                        Console.WriteLine("\n Enter address book name :");
                        string searchContacts = Console.ReadLine();
                        if (myDict.ContainsKey(searchContacts))
                        {
                            myDict[searchContacts].searchPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", searchContacts);
                        }
                        break;
                    case 6:
                        Console.WriteLine("\n Enter address book name :");
                        string displayContacts = Console.ReadLine();
                        if (myDict.ContainsKey(displayContacts))
                        {
                            myDict[displayContacts].sameCityPerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", displayContacts);
                        }
                        break;
                    case 7:
                        Console.WriteLine("\n Enter address book name :");
                        string displayContacts2 = Console.ReadLine();
                        if (myDict.ContainsKey(displayContacts2))
                        {
                            myDict[displayContacts2].sameStatePerson();
                        }
                        else
                        {
                            Console.WriteLine("No Address book exist with name {0} ", displayContacts2);
                        }
                        break;
                    case 8:
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
