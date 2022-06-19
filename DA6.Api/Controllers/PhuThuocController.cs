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
        public IActionResult Create([FromBody] List<PhuThuoc> model)
        {
            try
            {
                var entities = _context.PhuThuocs.Where(x => x.MaDauRa == model[0].MaDauRa && x.MaLoaiDauRa == model[0].MaLoaiDauRa && x.MaSanPham == model[0].MaSanPham).ToList();
                if (entities.Count > 0)
                {
                    foreach(var item in entities)
                    {
                        _context.PhuThuocs.Remove(item);
                    }
                }
                foreach(var item in model)
                {
                    _context.PhuThuocs.Add(item);
                }
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
        public IActionResult Delete([FromQuery] int dauraId, int loaidauraId, int sanphamId)
        {
            try
            {
                var entities = _context.PhuThuocs.Where(x => x.MaDauRa == dauraId && x.MaLoaiDauRa == loaidauraId && x.MaSanPham == sanphamId).ToList();
                foreach(var item in entities)
                {
                    _context.PhuThuocs.Remove(item);
                }
                _context.SaveChanges();
                return Ok();
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
                                 TenOptionDauRa = x.op.Name,
                                 Type = x.op.Type,

                             }).OrderBy(s=>s.Id);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
