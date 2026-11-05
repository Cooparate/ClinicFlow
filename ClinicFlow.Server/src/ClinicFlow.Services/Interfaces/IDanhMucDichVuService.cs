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
    public interface IDanhMucDichVuService
    {
        Task<AppResponse<DanhMucDichVuResponse>> GetByIdAsync(Guid id);
        Task<AppResponse<DanhMucDichVuResponse>> CreateAsync(DanhMucDichVuRequest request);
        Task<AppResponse<DanhMucDichVuResponse>> UpdateAsync(DanhMucDichVuRequest request);
        Task<AppResponse<string>> DeleteAsync(Guid id);
        Task<AppResponse<SearchResponse<DanhMucDichVuResponse>>> SearchAsync(SearchRequest request);
    }
}
