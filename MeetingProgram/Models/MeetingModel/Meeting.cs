using System;
using System.Collections.Generic;
using MeetingProgram.Models.PersonModel;
using System.ComponentModel.DataAnnotations;

namespace MeetingProgram.Models.MeetingModel
{
    public class Meeting 
    {

        public Meeting()
        {
        }

        [Key]
        public int MeetingID { get; set; }
        public virtual Agenda Agenda { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set;  }
        public string Description { get; set; }
        public bool IsDraft { get; set; }
        public ICollection<Person> Atendees { get; set; }

    }
}
