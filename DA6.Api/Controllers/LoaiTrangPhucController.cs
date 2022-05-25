using DA6.Api.Common;
using DA6.Core.Data;
using DA6.Core.Entities;
using Microsoft.AspNetCore.Mvc;


namespace DA6.Api.Controllers
{
    public class LoaiTrangPhucController : BaseController
    {
        public LoaiTrangPhucController(DA6DbContext context) : base(context)
        {
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var res = _context.LoaiTrangPhucs.ToList();
            return Ok(new { data = res });
        }
        [HttpGet("get-by-id")]
        public IActionResult Get([FromQuery] string id)
        {
            var res = _context.LoaiTrangPhucs.Find(id);
            return Ok(new { data = res });
        }
        [HttpPost("Create")]
        public IActionResult Insert([FromBody] LoaiTrangPhuc model)
        {
            try
            {
                model.MoTa = Helper.SlugFriendly(model.Ten);
                if (!Validate(model))
                {
                    return Ok(new { msg = "Không thể bỏ trống các trường", status = 400 });
                }
                var entity = new LoaiTrangPhuc();
                entity.MaTP = model.MaTP;
                entity.Ten = model.Ten;
                entity.MoTa = model.MoTa;
                entity.CreatedDate = DateTime.Now;
                _context.LoaiTrangPhucs.Add(entity);
                var result = _context.SaveChanges();
                return Ok(new { data = result, status = 201 });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("update")]
        public IActionResult Update([FromQuery] string id, [FromBody] LoaiTrangPhuc model)
        {
            try
            {
                if (!Validate(model))
                {
                    return Ok(new { msg = "Không thể bỏ trống các trường", status = 400 });
                }
                var entity = _context.LoaiTrangPhucs.Find(id);
                entity.MaTP = model.MaTP;
                entity.Ten = model.Ten;
                entity.MoTa = model.MoTa;
                entity.ModifiedDate = DateTime.Now;
                _context.LoaiTrangPhucs.Update(entity);
                var result = _context.SaveChanges();
                return Ok(new { data = result, status = 201 });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] string id)
        {
            try
            {
                var entity = _context.LoaiTrangPhucs.Find(id);
                if (entity == null)
                {
                    return BadRequest(new { mgs = "Không tìm thấy id", status = 400 });
                }
                _context.LoaiTrangPhucs.Remove(entity);
                var result = _context.SaveChanges();
                return Ok(new { data = result, status = 201 });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        private bool Validate(LoaiTrangPhuc model)
        {
            if (model == null || model.Ten == "" || model.MoTa == "")
            {
                return false;
            }
            return true;
        }

    }
}
