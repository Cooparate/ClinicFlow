using MayNghien.Infrastructures.Repository;
using Microsoft.EntityFrameworkCore;
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
    public class NhanVienRepository : GenericRepository<NHANVIEN, ApplicationDbContext, ApplicationUser>, INhanVienRepository
    {
        public NhanVienRepository(ApplicationDbContext unitOfWork) : base(unitOfWork)
        {
        }
    }
}
