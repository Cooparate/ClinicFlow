using MayNghien.Infrastructures.Models.Responses;
using ClinicFlow.DTOs.Authentication.Requests;
using ClinicFlow.DTOs.Authentication.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicFlow.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<AppResponse<LoginResponse>> LoginAsync(LoginRequest request);
        Task<AppResponse<RegisterResponse>> RegisterAsync(RegisterRequest request);

        Task<AppResponse<ProfileResponse>> GetProfileAsync();

        Task<AppResponse<RefreshTokenResponse>> RefreshTokenAsync(string refreshToken);
        Task<AppResponse<ChangePasswordResponse>> ChangePasswordAsync(ChangePasswordRequest request);
        Task LogoutAsync(string refreshToken);
    }
}
