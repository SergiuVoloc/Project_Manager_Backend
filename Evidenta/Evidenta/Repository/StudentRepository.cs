using Evidenta.Models;
using Evidenta.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evidenta.Context;

namespace Evidenta.Repository
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(DefaultContext repositoryContext)
               : base(repositoryContext)
        {
        }
    }
}
