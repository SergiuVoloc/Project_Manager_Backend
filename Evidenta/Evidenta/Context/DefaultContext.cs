using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Evidenta.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Evidenta.Context
{
    public class DefaultContext : IdentityDbContext<IdentityUser>
    {
        public DefaultContext(DbContextOptions<DefaultContext> options)
        : base(options)
        { }

        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Discipline> disciplines { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Projects_subjects> projects_subjects { get; set; }
        public DbSet<Teacher_projects> teacher_projects { get; set; }
        public DbSet<Project_review> project_reviews { get; set; }
  
    }
}
