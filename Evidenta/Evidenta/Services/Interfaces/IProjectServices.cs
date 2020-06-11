using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evidenta.Models;

namespace Evidenta.Services.Interfaces
{
    interface IProjectServices
    {
        public Task<List<Project>> GetAllProject();
        public Task<Project> GetProjectByID(int? id);



        public Task<bool> CreateProject(Project pr);
        public Task<bool> DeleteProject(int id);
        public Task<bool> UpdateProject(int id, Project pr);
    }
}
