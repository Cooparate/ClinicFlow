using ClinicFlow.DTOs.Requests;
using ClinicFlow.DTOs.Responses;
using ClinicFlow.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Services.Mapping
{
    public static class DanhMucThuocMapper
    {
        public static DanhMucThuocResponse ToResponse(DANHMUCTHUOC entity)
        {
            return new DanhMucThuocResponse
            {
                MaThuoc = entity.MaThuoc,
                TenThuoc = entity.TenThuoc,
                DonGia = entity.DonGia,
                ChongChiDinh = entity.ChongChiDinh
            };
        }

        public static DANHMUCTHUOC ToEntity(DanhMucThuocRequest request)
        {
            return new DANHMUCTHUOC
            {
                TenThuoc = request.TenThuoc,
                DonGia = request.DonGia,
                ChongChiDinh = request.ChongChiDinh
            };
        }
    }
}
