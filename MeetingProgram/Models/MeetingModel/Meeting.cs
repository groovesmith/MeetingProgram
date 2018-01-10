using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetingProgram.Models.Attachment;
using MeetingProgram.Models.PersonModel;
using System.ComponentModel.DataAnnotations;

namespace MeetingProgram.Models.MeetingModel
{
    public class Meeting : Interfaces.IMeeting
    {
        public Meeting(int meetingID, Agenda meetingAgenda, DateTime date, string description, bool isDraft, List<Person> atendees)
        {
            meetingID = MeetingID;
            Agenda = meetingAgenda;
            Date = date;
            Description = description;
            IsDraft = isDraft;
            Atendees = atendees;
        }
        public Meeting()
        {

        }
        [Key]
        public int MeetingID { get; set; }
        public virtual Agenda Agenda { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set;  }
        public string Description { get; set; }
        public bool IsDraft { get; set; }
        public List<Person> Atendees = new List<Person>();

        public void AddTopictoAgenda(string topic)
        {
            Agenda.AddTopic(new Topic(topic));
        }

        public void RemoveTopictoAgenda(Topic topic)
        {
            throw new NotImplementedException();
        }

        public void AddAtendee(Person atendee)
        {
            Atendees.Add(atendee);
        }

        public void RemoveAtendee(Person atendee)
        {
            throw new NotImplementedException();
        }

        public void ChangeAtendeeRole()
        {
            throw new NotImplementedException();
        }

        public SoundFile RecordSound()
        {
            throw new NotImplementedException();
        }               
    }
}
