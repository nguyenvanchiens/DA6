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
            return Ok(new { data = result});
        }
        [HttpPost]
        public IActionResult Insert([FromBody] ChungLoai chungLoai)
        {
            try
            {
                if (!Validate(chungLoai))
                {
                    return BadRequest(new { msg = "Dữ liệu không thể để trống", status = 400 });
                }
                else
                {
                    var chungloai = new ChungLoai();
                    chungloai.MaCL = chungLoai.MaCL;
                    chungloai.Ten = chungLoai.Ten;
                    chungloai.MoTa = chungLoai.MoTa;
                    chungloai.Kieu = chungLoai.Kieu;
                    chungLoai.CreatedDate = DateTime.Now;
                    chungLoai.ParenId = chungLoai.ParenId;
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
        [HttpGet("{Id}")]
        public IActionResult Get(string Id)
        {
            var result = _context.ChungLoais.Find(Id);
            return Ok(new { data= result});
        }
        [HttpDelete("{Id}")]
        public IActionResult Delete(string Id)
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
        [HttpPut]
        public IActionResult Update(string Id, [FromBody] ChungLoai chungLoai)
        {
            try
            {
                if (!Validate(chungLoai))
                {
                    return BadRequest(new { msg = "Dữ liệu không thể để trống", status = 400 });
                }
                else
                {
                    var entity = _context.ChungLoais.Find(Id);
                    entity.Ten = chungLoai.Ten;
                    entity.MoTa = chungLoai.MoTa;
                    entity.Kieu = chungLoai.Kieu;
                    entity.ModifiedDate = DateTime.Now;
                    entity.ParenId = chungLoai.ParenId;
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
        private bool Validate(ChungLoai model)
        {
            if(model == null|| model.Ten == "" || model.Kieu == "" || model.MoTa == "")
            {
                return false;
            }
            return true;
        }
    }
}
