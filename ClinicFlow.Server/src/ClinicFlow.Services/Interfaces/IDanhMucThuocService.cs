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
    public interface IDanhMucThuocService
    {
        Task<AppResponse<DanhMucThuocResponse>> GetByIdAsync(Guid id);
        Task<AppResponse<DanhMucThuocResponse>> CreateAsync(DanhMucThuocRequest request);
        Task<AppResponse<DanhMucThuocResponse>> UpdateAsync(DanhMucThuocRequest request);
        Task<AppResponse<string>> DeleteAsync(Guid id);
        Task<AppResponse<SearchResponse<DanhMucThuocResponse>>> SearchAsync(SearchRequest request);
    }
}
