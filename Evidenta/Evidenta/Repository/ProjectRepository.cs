using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evidenta.Context;
using Evidenta.Models;
using Evidenta.Repository.Interfaces;

namespace Evidenta.Repository
{
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(DefaultContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
