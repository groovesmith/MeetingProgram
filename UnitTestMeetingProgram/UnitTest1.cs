using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MeetingProgram.Models.MeetingModel;
using MeetingProgram.Controllers;
using System.Collections.Generic;

namespace UnitTestMeetingProgram
{
    [TestClass]
    public class UnitTestAgenda
    {
        [TestMethod]
        public void AgendaAddTest()
        {
            // arrange
            Agenda agenda = new Agenda();
            agenda.Topics = new List<Topic>();
            Topic topic = new Topic("Indkommenden Opgaver");            

            //  act
            agenda.Topics.Add(topic);

            //  assert
            Assert.AreEqual(1, agenda.Topics.Count);

        }
        [TestMethod]
        public void AgendaTopicCompareTest()
        {
            // arrange
            Agenda agenda = new Agenda();
            agenda.Topics = new List<Topic>();
            Topic topic = new Topic("Indkommenden Opgaver");

            //  act
            agenda.Topics.Add(topic);
            
            // assert
            Assert.IsTrue(agenda.Topics.Contains(topic));
           
        }

    }
}
