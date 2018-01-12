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
        public Agenda(List<Topic> topics)
        {
            Topics = topics;
        }
        public Agenda()
        {

        }
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int AgendaID { get; set; }
        public List<Topic> Topics { get; set; } = new List<Topic>();

        public void AddTopic(Topic topic)
            => Topics.Add(topic);

        public void RemoveTopic(Topic topic)
            => Topics.Remove(topic);
    }
}
