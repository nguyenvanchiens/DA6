using DA6.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DA6.Api.Controllers
{
    public class SanPhamLoaiDauRaController : BaseController
    {
        public SanPhamLoaiDauRaController(DA6DbContext context) : base(context)
        {
        }
        [HttpGet("get-san-pham-loai-dau-ra")]
        public IActionResult GetSanPhamLoaiDauRa([FromQuery]int MaSp)
        {
            try
            {
                var result = _context.SanPhamLoaiDauRas.Where(x => x.MaSanPham == MaSp).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
