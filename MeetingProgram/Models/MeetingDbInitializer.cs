using MeetingProgram.Models.MeetingModel;
using MeetingProgram.Models.PersonModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MeetingProgram.Models
{
    public class MeetingDbInitializer : DropCreateDatabaseAlways<MeetingDbContext>
    {
        protected override void Seed(MeetingDbContext context)
        {
            IList<User> defaultUsers = new List<User>();
            IList<Meeting> defaultMeetings = new List<Meeting>();

            defaultUsers.Add(new User {FirstName = "Jonas", LastName ="Glad", PassWord = "test1243", Email = "jonas@glad.dk", PhoneNr = 21343203, UserName = "groovesmith" });
            defaultUsers.Add(new User { FirstName = "test", LastName = "1", PassWord = "test1", Email = "test@2.dk", PhoneNr = 12345678, UserName = "test1" });
            defaultUsers.Add(new User { FirstName = "test", LastName = "2", PassWord = "test2", Email = "test@2.dk", PhoneNr = 87654321, UserName = "test2" });

            defaultMeetings.Add(new Meeting { Date = new DateTime(2018, 2, 9), Description = "Fredagsmøde", Agenda = new Agenda()});

            foreach (User user in defaultUsers)
                context.Users.Add(user);

            foreach (Meeting meeting in defaultMeetings)
                context.Meetings.Add(meeting);

            base.Seed(context);
        }
    }
       
}