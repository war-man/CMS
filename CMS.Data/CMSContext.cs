using CMS.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CMS.Data
{
    public class CMSContext: DbContext
    {
        public CMSContext(DbContextOptions<CMSContext> options) 
            :base(options)
        {

        }

        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerDocument> CustomerDocuments { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Right> Rights { get; set; }
        public virtual DbSet<RightType> RightTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SuggestionOrComplain> SuggestionOrComplains { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamMember> TeamMembers { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRight> UserRights { get; set; }
        public virtual DbSet<Error> Errors { get; set; }

    }
}
