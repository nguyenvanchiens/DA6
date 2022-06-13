using DA6.Api.ViewModel.SanPhamLoaiDauRa;
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
        public IActionResult GetSanPhamLoaiDauRa([FromQuery] int MaSp)
        {
            try
            {
                var result = (from s in _context.SanPhams
                             join spdr in _context.SanPhamLoaiDauRas
                             on s.Id equals spdr.MaSanPham
                             join dr in _context.QuanLyDauRas
                             on spdr.MaLoaiDauRa equals dr.Id
                             where s.Id == MaSp
                             select new { s, spdr, dr }).Select(x=>new SanPhamDauRaViewModel()
                             {
                                 Id = x.spdr.Id,
                                 MaLoaiDauRa = x.spdr.MaLoaiDauRa,
                                 MaSanPham = x.spdr.MaSanPham,
                                 TenLoaiDauRa = x.dr.Name
                             }).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
