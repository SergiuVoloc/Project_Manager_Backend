using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evidenta.Models;

namespace Evidenta.Services.Interfaces
{
    interface IStudentServices
    {
        public Task<List<Student>> GetAllStudent();
        public Task<Student> GetStudentByID(int? id);



        public Task<bool> CreateStudent(Student st);
        public Task<bool> DeleteStudent(int id);
        public Task<bool> UpdateStudent(int id, Student st);
    }
}
