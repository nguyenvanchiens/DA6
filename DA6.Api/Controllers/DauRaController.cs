using DA6.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DA6.Api.Controllers
{
    public class DauRaController : BaseController
    {
        public DauRaController(DA6DbContext context) : base(context)
        {
        }
        [HttpGet("get-all-dau-ra")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _context.DauRas.ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
