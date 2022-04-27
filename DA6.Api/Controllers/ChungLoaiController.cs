using DA6.Api.Interface.IService;
using DA6.Api.ViewModel.ChungLoai;
using DA6.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DA6.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChungLoaiController : ControllerBase
    {
        private readonly IChungLoaiService _res;
        public ChungLoaiController(IChungLoaiService res)
        {
            _res = res;
        }
        [HttpPost]
        public IActionResult Insert([FromBody] ChungLoai chungLoai)
        {

                var result = _res.Insert(chungLoai);
                return Ok(result);
            

        }
    }
}
