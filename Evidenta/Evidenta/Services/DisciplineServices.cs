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
    public class DisciplineServices : IDisciplineServices
    {

        private readonly IDisciplineRepository _disciplineRepository;
        public DisciplineServices(IDisciplineRepository disciplineRepository)
        {
            _disciplineRepository = disciplineRepository;
        }

        public async Task<bool> CreateDiscipline(Discipline dis)
        {
            try
            {
                _disciplineRepository.Create(dis);
                await _disciplineRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<bool> DeleteDiscipline(int id)
        {
            try
            {
                var dis = await GetDisciplineByID(id);
                _disciplineRepository.Delete(dis);
                await _disciplineRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Task<List<Discipline>> GetAllDiscipline()
        {
            try
            {
                return _disciplineRepository.FindAll().OrderByDescending(dis => dis.Title).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Task<Discipline> GetDisciplineByID(int? id)
        {
            try
            {
                return _disciplineRepository.FindByCondition(dis => dis.DisciplineId == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<bool> UpdateDiscipline(int id, Discipline dis)
        {
            try
            {
                await GetDisciplineByID(id);
                _disciplineRepository.Update(dis);
                await _disciplineRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
