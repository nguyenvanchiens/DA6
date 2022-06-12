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
                var result = _context.LoaiDauRaDauRas.Where(x=>x.MaDauRa == MaDauRa).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
