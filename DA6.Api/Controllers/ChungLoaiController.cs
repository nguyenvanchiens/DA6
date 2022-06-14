using DA6.Api.ViewModel;
using DA6.Api.ViewModel.ChungLoai;
using DA6.Core.Data;
using DA6.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DA6.Api.Controllers
{
    public class ChungLoaiController : BaseController
    {
        public ChungLoaiController(DA6DbContext context) : base(context)
        {
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _context.ChungLoais.ToList();
            return Ok(new { data = result });
        }
        [HttpGet("get-parent-tree-chung-loai")]
        public IActionResult GetParentNode()
        {
            var chungloai = _context.ChungLoais.Select(x => new ChungLoaiViewModel()
            {
                MaCL = x.MaCL,
                Ten = x.Ten,
                ParenId = x.ParenId,
                Level = x.Level
            }).ToList();


            List<ChungLoaiViewModel> result = new List<ChungLoaiViewModel>();
            int count = chungloai.Where(x => x.ParenId == null).Count();
            result = chungloai
                            .Where(c => c.ParenId == null)
                            .Select(c => new ChungLoaiViewModel() { MaCL = c.MaCL, Ten = c.Ten, ParenId = c.ParenId, Childrent = GetChildren(chungloai, c.MaCL) })
                            .ToList();
            return Ok(result);
        }

        public static List<ChungLoaiViewModel> GetChildren(List<ChungLoaiViewModel> chungloai, string parentId)
        {
            return chungloai
                    .Where(c => c.ParenId == parentId)
                    .Select(c => new ChungLoaiViewModel { MaCL = c.MaCL, Ten = c.Ten, ParenId = c.ParenId, Childrent = GetChildren(chungloai, c.MaCL) })
                    .ToList();
        }
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] ChungLoai chungLoai)
        {
            try
            {
                var isValid = await Validate(chungLoai);
                if (!isValid.isOk)
                {
                    return BadRequest(isValid.Message);
                }
                else
                {
                    var chungloai = new ChungLoai();
                    chungloai.MaCL = chungLoai.MaCL;
                    chungloai.Ten = chungLoai.Ten;
                    chungloai.MoTa = chungLoai.MoTa;
                    chungloai.Kieu = chungLoai.Kieu;
                    chungloai.CreatedDate = DateTime.Now;
                    chungloai.ParenId = chungLoai.ParenId;
                    chungloai.Level = chungLoai.Level;
                    _context.ChungLoais.Add(chungloai);
                    var result = _context.SaveChanges();
                    return Ok(new { data = result, status = 201 });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("get-by-id")]
        public IActionResult Get([FromQuery] string Id)
        {
            try
            {
                var result = _context.ChungLoais.Find(Id);
                return Ok(new { data = result });
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }
        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] string Id)
        {
            try
            {
                var result = _context.ChungLoais.Find(Id);
                _context.ChungLoais.Remove(result);
                var res = _context.SaveChanges();
                return Ok(new { data = res, status = 201 });
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromQuery] string Id, [FromBody] ChungLoai chungLoai)
        {
            try
            {
                var isValid = await Validate(chungLoai,true);
                if (!isValid.isOk)
                {
                    return BadRequest(isValid.Message);
                }
                else
                {
                    var entity = _context.ChungLoais.Find(Id);
                    entity.Ten = chungLoai.Ten;
                    entity.MoTa = chungLoai.MoTa;
                    entity.Kieu = chungLoai.Kieu;
                    entity.ModifiedDate = DateTime.Now;
                    entity.ParenId = chungLoai.ParenId;
                    entity.Level = chungLoai.Level;
                    _context.ChungLoais.Update(entity);
                    var res = _context.SaveChanges();
                    return Ok(new { data = res, status = 201 });
                }
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet("get-level")]
        public IActionResult GetLevel([FromQuery] int level)
        {
            try
            {
                var result = _context.ChungLoais.Where(x => x.Level == level).ToList();
                if (result.Count > 0)
                {
                    return Ok(result);
                }
                return BadRequest();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }
        private async Task<Responsive> Validate(ChungLoai chungLoai, bool isUpdate = false)
        {
            var message = "";
            if (chungLoai == null)
            {
                message = "Không thể bỏ trống dữ liệu";
                return new Responsive(message);
            }
            if (chungLoai.MaCL == null)
            {
                message = "Không thể bỏ trống dữ liệu";
                return new Responsive(message);
            }
            if (isUpdate==true)
            {
                var entity = _context.ChungLoais.Find(chungLoai.MaCL);
                if (entity != null && entity.MaCL != entity.MaCL)
                {
                    message = "Mã chủng loại đã tồn tại";
                    return new Responsive(message);
                }
            }
            if (isUpdate==false)
            {
                var entity = _context.ChungLoais.Find(chungLoai.MaCL);
                if (entity != null)
                {
                    message = "Mã chủng loại đã tồn tại";
                    return new Responsive(message);
                }
            }
            return new Responsive("", true);
        }
    }
}
