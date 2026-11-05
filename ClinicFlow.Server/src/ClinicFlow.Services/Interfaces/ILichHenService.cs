using MayNghien.Infrastructures.Models.Requests;
using MayNghien.Infrastructures.Models.Responses;
using ClinicFlow.DTOs.Requests;
using ClinicFlow.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Services.Interfaces
{
    public interface ILichHenService
    {
        Task<AppResponse<LichHenResponse>> GetByIdAsync(Guid id);
        Task<AppResponse<LichHenResponse>> CreateAsync(LichHenRequest request);
        Task<AppResponse<LichHenResponse>> UpdateAsync(LichHenRequest request);
        Task<AppResponse<string>> DeleteAsync(Guid id);
        Task<AppResponse<SearchResponse<LichHenResponse>>> SearchAsync(SearchRequest request);
    }
}
