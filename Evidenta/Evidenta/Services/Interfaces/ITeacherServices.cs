using System;
using System.Collections.Generic;
using System.Linq;
using Evidenta.Models;
using System.Threading.Tasks;

namespace Evidenta.Services.Interfaces
{
    interface ITeacherServices
    {
        public Task<List<Teacher>> GetAllTeacher();
        public Task<Teacher> GetTeacherByID(int? id);



        public Task<bool> CreateTeacher(Teacher tc);
        public Task<bool> DeleteTeacher(int id);
        public Task<bool> UpdateTeacher(int id, Teacher tc);
    }
}
