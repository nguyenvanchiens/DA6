using DA6.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DA6.Api.Controllers
{
    public class PhuThuocController : BaseController
    {
        public PhuThuocController(DA6DbContext context) : base(context)
        {
        }
        [HttpGet("get-all-phu-thuoc")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _context.PhuThuocs.ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
