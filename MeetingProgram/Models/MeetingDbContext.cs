using System.Data.Entity;
using MeetingProgram.Models.MeetingModel;
using MeetingProgram.Models.PersonModel;
using MeetingProgram.Models.ProjectModel;
using MeetingProgram.Models.AttachmentModel;

namespace MeetingProgram.Models
{
    public class MeetingDbContext : DbContext
    {
        public MeetingDbContext() : base("MeetingDbConnectionString")
        {
            Database.SetInitializer(new  MeetingDbInitializer());
        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Attachment> Attachments { get; set; }

        public System.Data.Entity.DbSet<MeetingProgram.Models.PersonModel.User> Users { get; set; }
    }
}