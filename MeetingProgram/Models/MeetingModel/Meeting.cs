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
        public Meeting(int meetingID, Agenda meetingAgenda, DateTime date, string description, bool isDraft, List<Meeting> partialMeeting, List<Person> atendees)
        {
            meetingID = MeetingID;
            MeetingAgenda = meetingAgenda;
            Date = date;
            Description = description;
            IsDraft = isDraft;
            PartialMeeting = partialMeeting;
            Atendees = atendees;
        }
        public Meeting()
        {

        }
        [Key]
        public int MeetingID { get; set; }
        public Agenda MeetingAgenda { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set;  }
        public string Description { get; set; }
        public bool IsDraft { get; set; }
        public List<Meeting> PartialMeeting = new List<Meeting>();
        public List<Person> Atendees = new List<Person>();

        public void AddTopictoAgenda(string topic)
        {
            MeetingAgenda.AddTopic(new Topic(topic));
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
