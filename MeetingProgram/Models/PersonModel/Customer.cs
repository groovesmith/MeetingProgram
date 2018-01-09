using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingProgram.Models.PersonModel
{
    public class Customer : Person 
    {
        public Customer(int personID, string firstname, string lastname, string email, int phoneNr, int customerID, int cvr, string address) : base(personID, firstname, lastname, email, phoneNr)
        {
            PersonID = personID;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            PhoneNr = phoneNr;
            CustomerID = customerID;
            CVR = cvr;
            Address = address;
        }
        [Key]
        public int CustomerID { get; set; }
        public int CVR { get; set; }
        public string Address { get; set; }
    }
}
