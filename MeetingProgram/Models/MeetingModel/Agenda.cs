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
        public Agenda(List<Topic> agendaList)
        {
            AgendaList = agendaList;
        }

        [Key]
        [HiddenInput(DisplayValue = false)]
        public int AgendaID { get; set; }
        public List<Topic> AgendaList = new List<Topic>();

        public void AddTopic(Topic topic)
        {
            AgendaList.Add(topic);
        }

        public void RemoveTopic(Topic topic)
        {
            //AgendaList.Remove(Topic topic);
            throw new NotImplementedException();
        }
    }
}
