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
        public IActionResult Insert([FromBody] ChungLoaiCreateVM chungLoai)
        {
            try
            {
                if (chungLoai.Ten == "" || chungLoai.Kieu == "" || chungLoai.MoTa == "")
                {
                    return BadRequest(new { msg = "Dữ liệu không thể để trống", status = 400 });
                }
                else
                {
                    var chungloai = new ChungLoai();
                    chungloai.MaCL = Guid.NewGuid();
                    chungloai.Ten = chungLoai.Ten;
                    chungloai.MoTa = chungLoai.MoTa;
                    chungloai.Kieu = chungLoai.Kieu;
                    chungLoai.CreatedDate = DateTime.Now;
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
        public IActionResult Get(Guid Id)
        {
            var result = _context.ChungLoais.Find(Id);
            return Ok(new { data= result});
        }
        [HttpDelete("{Id}")]
        public IActionResult Delete(Guid Id)
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
        public IActionResult Update(Guid Id, [FromBody] ChungLoai chungLoai)
        {
            try
            {
                if (chungLoai.Ten == "" || chungLoai.Kieu == "" || chungLoai.MoTa == "")
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
    }
}
