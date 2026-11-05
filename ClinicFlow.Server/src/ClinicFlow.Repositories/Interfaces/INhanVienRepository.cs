using MayNghien.Infrastructures.Repository;
using ClinicFlow.DTOs.Responses;
using ClinicFlow.Models.Data;
using ClinicFlow.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Repositories.Interfaces
{
    public interface INhanVienRepository : IGenericRepository<NHANVIEN, ApplicationDbContext, ApplicationUser>
    {
    }
}
