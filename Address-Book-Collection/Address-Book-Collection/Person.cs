using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book_Collection
{/// <summary>
/// Adding data to the Person 
/// </summary>
   public class Person
    {
		/// <summary>
		/// Creating Variables for data in list
		/// </summary>
		public string FirstName;
		public string LastName;
		public string city;
		public string state;
		public string email;
		public long phoneNumber;
		//Adding Method To add data
		public Person(string firstName, string lastName, string city, string state, string email, long phoneNumber)
		{
			//Create Instace Variable
			this.FirstName = firstName;
			this.LastName = lastName;
			this.city = city;
			this.state = state;
			this.email = email;
			this.phoneNumber = phoneNumber;
		}
		//Adding Method for getting and Setting Element
		public String getFirstName()
		{
			return FirstName;
		}

		public void setFirstName(String firstName)
		{
			this.FirstName = firstName;
		}

		public String getLastName()
		{
			return LastName;
		}

		public void setLastName(String lastName)
		{
			this.LastName = lastName;
		}

		public String getCity()
		{
			return city;
		}

		public void setCity(String city)
		{
			this.city = city;
		}

		public String getState()
		{
			return state;
		}

		public void setState(String state)
		{
			this.state = state;
		}
		public long getPhoneNumber()
		{
			return phoneNumber;
		}

		public void setPhoneNumber(long phoneNumber)
		{
			this.phoneNumber = phoneNumber;
		}

		public String getEmail()
		{
			return email;
		}

		public void setEmail(String email)
		{
			this.email = email;
		}
	}
}
