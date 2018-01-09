using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingProgram.Models.PersonModel
{
    public class SubContractor : Person
    {
        //se om det giver mening at lave navne om til er firma navn her
        public SubContractor(int personID, string firstname, string lastname, string email, int phoneNr, int contractorID, int cvr, string address) : base(personID, firstname, lastname, email, phoneNr)
        {
            PersonID = personID;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            PhoneNr = phoneNr;
            ContractorID = contractorID;
            CVR = cvr;
            Address = address;
        }
        [Key]
        public int ContractorID { get; set; }
        public int CVR { get; set; }
        public string Address { get; set; }
    }
}
