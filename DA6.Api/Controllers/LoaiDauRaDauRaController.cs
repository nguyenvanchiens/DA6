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
        public IActionResult Get([FromQuery]int MaDauRa)
        {
            try
            {
                var result = (from dr in _context.DauRas join ldr in _context.LoaiDauRaDauRas
                             on dr.Id equals ldr.MaDauRa
                             where dr.Id == MaDauRa
                             select new {dr,ldr}).Select(x=>new DauRaLoaiDauRaViewModel()
                             {
                                 Id = x.ldr.Id,
                                 MaDauRa = x.ldr.MaDauRa,
                                 MaLoaiDauRa = x.ldr.MaLoaiDauRa,
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
