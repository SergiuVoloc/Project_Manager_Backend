using Evidenta.Models;
using Evidenta.Repository.Interfaces;
using Evidenta.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evidenta.Repository
{
    public class TeacherRepository : RepositoryBase<Teacher>, ITeacherRepository
    {
        public TeacherRepository(DefaultContext repositoryContext)
              : base(repositoryContext)
        {
        }
    }
}
