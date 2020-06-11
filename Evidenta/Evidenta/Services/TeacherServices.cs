using Evidenta.Models;
using Evidenta.Repository.Interfaces;
using Evidenta.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace Evidenta.Services
{
    public class TeacherServices : ITeacherServices
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherServices(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public async Task<bool> CreateTeacher(Teacher tc)
        {
            try
            {
                _teacherRepository.Create(tc);
                await _teacherRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<bool> DeleteTeacher(int id)
        {
            try
            {
                var tc = await GetTeacherByID(id);
                _teacherRepository.Delete(tc);
                await _teacherRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Task<List<Teacher>> GetAllTeacher()
        {
            try
            {
                return _teacherRepository.FindAll().OrderByDescending(tc => tc.TeacherName).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Task<Teacher> GetTeacherByID(int? id)
        {
            try
            {
                return _teacherRepository.FindByCondition(tc => tc.TeacherId == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<bool> UpdateTeacher(int id, Teacher tc)
        {
            try
            {
                await GetTeacherByID(id);
                _teacherRepository.Update(tc);
                await _teacherRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
