using DA6.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DA6.Api.Controllers
{

    public class QuanLyDauRaController : BaseController
    {
        public QuanLyDauRaController(DA6DbContext context) : base(context)
        {
        }
        [HttpGet("get-all-quan-ly-dau-ra")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _context.QuanLyDauRas.ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
