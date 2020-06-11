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
    public class StudentServices : IStudentServices
    {
        private readonly IStudentRepository _studentRepository;
        public StudentServices(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<bool> CreateStudent(Student st)
        {
            try
            {
                _studentRepository.Create(st);
                await _studentRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<bool> DeleteStudent(int id)
        {
            try
            {
                var st = await GetStudentByID(id);
                _studentRepository.Delete(st);
                await _studentRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Task<List<Student>> GetAllStudent()
        {
            try
            {
                return _studentRepository.FindAll().OrderByDescending(st => st.StudentName).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public Task<Student> GetStudentByID(int? id)
        {
            try
            {
                return _studentRepository.FindByCondition(st => st.StudentId == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<bool> UpdateStudent(int id, Student st)
        {
            try
            {
                await GetStudentByID(id);
                _studentRepository.Update(st);
                await _studentRepository.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

    }
}
