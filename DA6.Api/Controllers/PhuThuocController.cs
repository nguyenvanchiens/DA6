using DA6.Api.Entities;
using DA6.Api.ViewModel.PhuThuoc;
using DA6.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DA6.Api.Controllers
{
    public class PhuThuocController : BaseController
    {
        public PhuThuocController(DA6DbContext context) : base(context)
        {
        }
        
        [HttpGet("get-all-phu-thuoc")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _context.PhuThuocs.ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("create-phu-thuoc")]
        public IActionResult Create([FromBody] PhuThuoc model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest(model);
                }
                _context.PhuThuocs.Add(model);
                var result = _context.SaveChanges();
                return Ok(result);

            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut("update-phu-thuoc")]
        public IActionResult Update([FromQuery] int Id, PhuThuoc model)
        {
            try
            {
                var result = _context.PhuThuocs.Where(x => x.Id == Id).FirstOrDefault();
                if (result == null)
                {
                    return BadRequest("Can not find by id");
                }
                result.MaOptionDaura = model.MaOptionDaura;
                result.MaDauRa = model.MaDauRa;
                result.MaLoaiDauRa = model.MaLoaiDauRa;
                result.MaSanPham = model.MaSanPham;
                _context.PhuThuocs.Update(result);
                var res = _context.SaveChanges();
                return Ok(res);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete("delete-phu-thuoc")]
        public IActionResult Delete([FromQuery] int Id)
        {
            try
            {
                var entity = _context.PhuThuocs.Where(x => x.Id == Id).FirstOrDefault();
                if (entity == null)
                {
                    return BadRequest("Can not find by id");
                }
                _context.PhuThuocs.Remove(entity);
                var res = _context.SaveChanges();
                return Ok(res);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("get-phu-thuoc-by-list-id")]
        public IActionResult GetPhuThuocById([FromQuery] PhuThuocRequestModel request)
        {
            try
            {
                var result = (from p in _context.PhuThuocs join op in _context.OptionDauRas
                             on p.MaOptionDaura equals op.Id
                             where p.MaSanPham == request.MaSanPham && p.MaLoaiDauRa == request.MaLoaiDauRa
                             && p.MaDauRa ==request.MaDauRa
                             select new {p,op}).Select(x=>new PhuThuocResponModel()
                             {
                                 Id = x.p.MaOptionDaura,
                                 TenOptionDauRa = x.op.Name
                             });
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
