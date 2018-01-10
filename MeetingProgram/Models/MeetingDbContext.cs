using System.Data.Entity;
using MeetingProgram.Models.MeetingModel;
using MeetingProgram.Models.PersonModel;
using MeetingProgram.Models.ProjectModel;
using MeetingProgram.Models.Attachment;

namespace MeetingProgram.Models
{
    public class MeetingDbContext : DbContext
    {
        public MeetingDbContext() : base() { }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Attachment.Attachment> Attachments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}