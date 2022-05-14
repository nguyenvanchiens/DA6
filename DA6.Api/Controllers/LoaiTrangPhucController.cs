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
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var res = _context.LoaiTrangPhucs.Find(id);
            return Ok(new { data = res });
        }
        [HttpPost]
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
                entity.MaTP = Guid.NewGuid();
                entity.Ten = model.Ten;
                entity.MoTa = model.MoTa;
                _context.LoaiTrangPhucs.Add(entity);
                var result = _context.SaveChanges();
                return Ok(new { data = result, status = 201 });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] LoaiTrangPhuc model)
        {
            try
            {
                if (!Validate(model))
                {
                    return Ok(new { msg = "Không thể bỏ trống các trường", status = 400 });
                }
                var entity = _context.LoaiTrangPhucs.Find(id);
                entity.Ten = model.Ten;
                entity.MoTa = model.MoTa;
                _context.LoaiTrangPhucs.Update(entity);
                var result = _context.SaveChanges();
                return Ok(new { data = result, status = 201 });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
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
