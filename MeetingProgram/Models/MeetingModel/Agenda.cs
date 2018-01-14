using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MeetingProgram.Models.MeetingModel
{
    public class Agenda
    {
        // singel topic and mulit topics 
        public Agenda()
        {
        }


        public Agenda(string topic)
        {
            Topics = new List<Topic>();
            AddTopic(topic);
        }

        public int AgendaID { get; set; }
        public virtual List<Topic> Topics { get; set; }


        public void AddTopic(string topic) => Topics.Add(new Topic(topic));

        public void AddTopic(Topic topic)
            => Topics.Add(topic);

        public void RemoveTopic(Topic topic)
            => Topics.Remove(topic);
    }
}
