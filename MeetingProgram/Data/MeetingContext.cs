using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MeetingProgram.Data
{
    public class MeetingContext : DbContext
    {
        public MeetingContext() : base("MeetingContext")
        {
                
        }
    }
}