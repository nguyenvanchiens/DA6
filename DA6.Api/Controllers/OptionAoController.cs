using DA6.Api.Entities;
using DA6.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DA6.Api.Controllers
{
    public class OptionAoController : BaseController
    {
        public OptionAoController(DA6DbContext context) : base(context)
        {
        }
        [HttpPost("insert-option")]
        public async Task<IActionResult> Insert([FromBody]OptionAo model)
        {
            try
            {
                if(model == null)
                {
                    return BadRequest();
                }
                var result = _context.OptionAos.Add(model);
                await _context.SaveChangesAsync();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("get-option-by-id")]
        public async Task<IActionResult> GetOptionById([FromQuery]string MaAo)
        {
            try
            {
                var reuslt = await _context.OptionAos.FirstOrDefaultAsync(x => x.MaAo == MaAo);
                if(reuslt == null)
                {
                    return BadRequest("Không thể tìm thấy Option với Mã áo truyền vào");
                }
                return Ok(reuslt);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost("update-option")]
        public async Task<IActionResult> Update([FromBody]OptionAo model)
        {
            try
            {
                var resuslt = await _context.OptionAos.FirstOrDefaultAsync(x => x.MaAo == model.MaAo);
                if (resuslt == null)
                {
                    return BadRequest("Không thể update, lỗi không tìm thấy option với mã áo");
                }
                resuslt.MaKieuTay = model.MaKieuTay;
                resuslt.MaKieuCuaTay = model.MaKieuCuaTay;
                resuslt.MaKieuGau = model.MaKieuGau;
                resuslt.MaKieuCo = model.MaKieuCo;
                resuslt.MaKieuTui = model.MaKieuTui;
                resuslt.MaKieuNep = model.MaKieuNep;
                resuslt.MaKieuThanTruoc = model.MaKieuThanTruoc;
                resuslt.MaKieuXe = model.MaKieuXe;
                resuslt.MaKieuThanSau = model.MaKieuThanSau;
                resuslt.MaThanhPhanVai1 = model.MaThanhPhanVai1;
                resuslt.MaThanhPhanVai2 = model.MaThanhPhanVai2;
                resuslt.MaThanhPhanVai3 = model.MaThanhPhanVai3;
                _context.OptionAos.Update(resuslt);
                await _context.SaveChangesAsync();
                return Ok(resuslt);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
