using MayNghien.Infrastructures.Repository;
using Microsoft.Identity.Client;
using ClinicFlow.Models.Data;
using ClinicFlow.Models.Entities;

namespace ClinicFlow.Repositories.Interfaces
{
    public interface ILichLamViecRepository : IGenericRepository<LICHLAMVIEC, ApplicationDbContext, ApplicationUser>
    {
    }
}
