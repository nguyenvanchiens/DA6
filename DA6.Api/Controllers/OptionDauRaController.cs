using DA6.Api.Entities;
using DA6.Api.ViewModel.Option;
using DA6.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DA6.Api.Controllers
{
    public class OptionDauRaController : BaseController
    {
        public OptionDauRaController(DA6DbContext context) : base(context)
        {
        }
        [HttpGet("get-all-option-dau-ra")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _context.OptionDauRas.Select(s => new OptionViewModel()
                {
                    Value = s.Id.ToString(),
                    Lable = s.Name
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
