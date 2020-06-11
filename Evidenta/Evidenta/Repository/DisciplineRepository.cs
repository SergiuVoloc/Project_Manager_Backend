using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evidenta.Context;
using Evidenta.Models;
using Evidenta.Repository.Interfaces;

namespace Evidenta.Repository
{
    public class DisciplineRepository : RepositoryBase<Discipline>, IDisciplineRepository
    {
        public DisciplineRepository(DefaultContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
