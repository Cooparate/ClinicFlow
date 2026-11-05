using Microsoft.EntityFrameworkCore.Storage.Json;
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
    public static class BacSiMapper
    {
        public static BacSiResponse ToResponse(BACSI entity)
        {
            return new BacSiResponse
            {
                MaBS = entity.MaBS,
                HoTen = entity.HoTen,
                ChuyenKhoa = entity.ChuyenKhoa,
                SoDienThoai = entity.SoDienThoai,
                Email = entity.TaiKhoan?.Email
            };
        }

        public static BACSI ToEntity(BacSiRequest request)
        {
            return new BACSI
            {
                HoTen = request.HoTen,
                ChuyenKhoa = request.ChuyenKhoa,
                SoDienThoai = request.SoDienThoai
            };
        }
    }
}
