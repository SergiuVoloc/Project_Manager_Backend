using Evidenta.Models;
using Evidenta.Repository.Interfaces;
using Evidenta.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evidenta.Services
{
    public class ProjectServices : IProjectServices
    {

        private readonly IProjectRepository _projectRepository;
        public ProjectServices(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<bool> CreateProject(Project pr)
        {
            try
            {
                _projectRepository.Create(pr);
                await _projectRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<bool> DeleteProject(int id)
        {
            try
            {
                var pr = await GetProjectByID(id);
                _projectRepository.Delete(pr);
                await _projectRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Task<List<Project>> GetAllProject()
        {
            try
            {
                return _projectRepository.FindAll().OrderByDescending(pr => pr.Name).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Task<Project> GetProjectByID(int? id)
        {
            try
            {
                return _projectRepository.FindByCondition(pr => pr.ProjectId == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<bool> UpdateProject(int id, Project pr)
        {
            try
            {
                await GetProjectByID(id);
                _projectRepository.Update(pr);
                await _projectRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
