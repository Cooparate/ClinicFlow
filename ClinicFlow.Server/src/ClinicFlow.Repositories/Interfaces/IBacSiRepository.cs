using MayNghien.Infrastructures.Repository;
using ClinicFlow.Models.Data;
using ClinicFlow.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Repositories.Interfaces
{
    public interface IBacSiRepository : IGenericRepository<BACSI, ApplicationDbContext, ApplicationUser>
    {
    }
}
