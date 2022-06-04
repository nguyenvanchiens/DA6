using DA6.Api.Entities;
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
                var result = _context.OptionDauRas.ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("create-option-dau-ra")]
        public IActionResult Create([FromBody] OptionDauRa model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest(model);
                }
                _context.OptionDauRas.Add(model);
                var result = _context.SaveChanges();
                return Ok(result);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut("update-option-dau-ra")]
        public IActionResult Update([FromQuery]int Id, OptionDauRa model)
        {
            try
            {
                var result = _context.OptionDauRas.Where(x => x.Id==Id).FirstOrDefault();
                if (result == null)
                {
                    return BadRequest("Can not find by id");
                }
                result.MaDauRa = model.MaDauRa;
                result.MaQuanLyDauRa = model.MaQuanLyDauRa;
                result.MaPhuThuoc = model.MaPhuThuoc;
                _context.OptionDauRas.Update(result);
                var res = _context.SaveChanges();
                return Ok(res);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete("delete-option-dau-ra")]
        public IActionResult Delete([FromQuery]int Id)
        {
            try
            {
                var entity = _context.OptionDauRas.Where(x => x.Id == Id).FirstOrDefault();
                if (entity == null)
                {
                    return BadRequest("Can not find by id");
                }
                _context.OptionDauRas.Remove(entity);
                var res = _context.SaveChanges();
                return Ok(res);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
