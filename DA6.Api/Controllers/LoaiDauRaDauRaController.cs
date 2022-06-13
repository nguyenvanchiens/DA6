using DA6.Api.ViewModel.LoaiDauRaDauRa;
using DA6.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DA6.Api.Controllers
{

    public class LoaiDauRaDauRaController : BaseController
    {
        public LoaiDauRaDauRaController(DA6DbContext context) : base(context)
        {
        }
        [HttpGet("get-dau-ra-loai-dau-ra")]
        public IActionResult Get([FromQuery]int LoaiDauRa)
        {
            try
            {
                var result = (from ldr in _context.QuanLyDauRas join ldrdr in _context.LoaiDauRaDauRas
                             on ldr.Id equals ldrdr.MaLoaiDauRa
                             join dr in _context.DauRas on ldrdr.MaDauRa equals dr.Id
                             where ldr.Id == LoaiDauRa
                             select new {ldr,ldrdr,dr}).Select(x=>new DauRaLoaiDauRaViewModel()
                             {
                                 Id = x.ldr.Id,
                                 MaDauRa = x.ldrdr.MaDauRa,
                                 MaLoaiDauRa = x.ldrdr.MaLoaiDauRa,
                                 TenDauRa = x.dr.Name
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
