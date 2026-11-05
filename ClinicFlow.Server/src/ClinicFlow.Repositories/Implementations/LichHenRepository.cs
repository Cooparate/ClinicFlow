using MayNghien.Infrastructures.Repository;
using ClinicFlow.Models.Data;
using ClinicFlow.Models.Entities;
using ClinicFlow.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Repositories.Implementations
{
    public class LichHenRepository : GenericRepository<LICHHEN, ApplicationDbContext, ApplicationUser>, ILichHenRepository
    {
        public LichHenRepository(ApplicationDbContext unitOfWork) : base(unitOfWork)
        {
        }
    }
}
