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
    public interface IDonThuocService
    {
        Task<AppResponse<DonThuocResponse>> GetByIdAsync(Guid id);
        Task<AppResponse<DonThuocResponse>> CreateAsync(DonThuocRequest request);
        Task<AppResponse<DonThuocResponse>> UpdateAsync(DonThuocRequest request);
        Task<AppResponse<string>> DeleteAsync(Guid id);
        Task<AppResponse<SearchResponse<DonThuocResponse>>> SearchAsync(SearchRequest request);
    }
}
