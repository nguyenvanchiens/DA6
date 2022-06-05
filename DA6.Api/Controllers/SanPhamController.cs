using DA6.Core.Data;
using Microsoft.AspNetCore.Mvc;

namespace DA6.Api.Controllers
{

    public class SanPhamController : BaseController
    {
        public SanPhamController(DA6DbContext context) : base(context)
        {
        }
        [HttpGet("get-all-san-pham")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _context.SanPhams.ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
