using System;
using System.Collections.Generic;
using System.Linq;
using Evidenta.Models;
using System.Threading.Tasks;

namespace Evidenta.Services.Interfaces
{
    interface IDisciplineServices
    {
        public Task<List<Discipline>> GetAllDiscipline();
        public Task<Discipline> GetDisciplineByID(int? id);



        public Task<bool> CreateDiscipline(Discipline dis);
        public Task<bool> DeleteDiscipline(int id);
        public Task<bool> UpdateDiscipline(int id, Discipline dis);
    }
}
