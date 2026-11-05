using MayNghien.Infrastructures.Models.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClinicFlow.DTOs.Requests;
using ClinicFlow.Services.Implementations;
using ClinicFlow.Services.Interfaces;

namespace ClinicFlow.API.Controllers
{
    [Route("lichlamviec")]
    [ApiController]
    public class LichLamViecController : ControllerBase
    {
        private readonly ILichLamViecService _lichLamViecService;

        public LichLamViecController(ILichLamViecService lichLamViecService)
        {
            _lichLamViecService = lichLamViecService;
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "SuperAdmin, BacSi, LeTan, BenhNhan")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var result = await _lichLamViecService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> Create([FromBody] LichLamViecRequest request)
        {
            var result = await _lichLamViecService.CreateAsync(request);
            return Ok(result);
        }

        [HttpPut]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> Update([FromBody] LichLamViecRequest request)
        {
            var result = await _lichLamViecService.UpdateAsync(request);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var result = await _lichLamViecService.DeleteAsync(id);
            return Ok(result);
        }

        [HttpPost("search")]
        [Authorize(Roles = "SuperAdmin, BacSi, LeTan, BenhNhan")]
        public async Task<IActionResult> Search([FromBody] SearchRequest request)
        {
            var result = await _lichLamViecService.SearchAsync(request);
            return Ok(result);
        }
    }
}
