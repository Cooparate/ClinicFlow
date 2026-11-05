using ClinicFlow.DTOs.Requests;
using ClinicFlow.DTOs.Responses;
using ClinicFlow.Models.Entities;

namespace ClinicFlow.Services.Mapping
{
    public static class BenhNhanMapper
    {
        public static BenhNhanResponse ToResponse(BENHNHAN e) => new()
        {
            MaBN = e.MaBN,
            HoTen = e.HoTen,
            NgaySinh = e.NgaySinh,
            GioiTinh = e.GioiTinh,
            SoDienThoai = e.SoDienThoai,
            DiaChi = e.DiaChi,
            SoBHYT = e.SoBHYT,
            TienSuDiUng = e.TienSuDiUng,
        };

        public static BENHNHAN ToEntity(BenhNhanRequest r) => new()
        {
            HoTen = r.HoTen,
            NgaySinh = r.NgaySinh,
            GioiTinh = r.GioiTinh,
            SoDienThoai = r.SoDienThoai,
            DiaChi = r.DiaChi,
            SoBHYT = r.SoBHYT,
            TienSuDiUng = r.TienSuDiUng,
        };
    }
}
