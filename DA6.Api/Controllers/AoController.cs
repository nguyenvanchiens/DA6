using DA6.Core.Data;
using DA6.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DA6.Api.Controllers
{

    public class AoController : BaseController
    {
        public AoController(DA6DbContext context) : base(context)
        {
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var reuslt = _context.Aos.ToList();
                return Ok(reuslt);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var reuslt = _context.Aos.FirstOrDefault(x=>x.MaA==id);
                if (reuslt == null)
                {
                    return BadRequest("can not find by id");
                }
                return Ok(reuslt);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] Ao model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("error");
                }
                _context.Aos.Add(model);
                var reuslt = _context.SaveChanges();

                return Ok(reuslt);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("{id}")]
        public IActionResult Update(Guid id, [FromBody] Ao model)
        {
            try
            {
                var entity = _context.Aos.FirstOrDefault(x => x.MaA == id);
                if (entity == null)
                {
                    return BadRequest("error");
                }
                entity.ModifiedDate = DateTime.Now;
                entity.MaCL = model.MaCL;
                entity.KieuTay = model.KieuTay;
                entity.KieuCuaTay= model.KieuCuaTay;
                entity.KieuGau = model.KieuGau;
                entity.KieuCo = model.KieuCo;
                entity.KieuTui = model.KieuTui;
                entity.KieuNep = model.KieuNep;
                entity.KieuThanTruoc = model.KieuThanTruoc;
                entity.KieuXe = model.KieuXe;
                entity.KieuThanSau = model.KieuThanSau;
                entity.DaiAo = model.DaiAo;
                entity.DaiTay = model.DaiTay;
                entity.VongNguc = model.VongNguc;
                entity.VongMong = model.VongMong;
                entity.ThanhPhanVai1 = model.ThanhPhanVai1;
                entity.TrongLuongVai1 = model.TrongLuongVai1;
                entity.KhoVai1 = model.KhoVai1;
                entity.ThanhPhanVai2 = model.ThanhPhanVai2;
                entity.TrongLuongVai2 = model.TrongLuongVai2;
                entity.KhoVai2 = model.KhoVai2;
                entity.ThanhPhanVai3 = model.ThanhPhanVai3;
                entity.TrongLuongVai3 = model.TrongLuongVai3;
                entity.KhoVai3 = model.KhoVai3;
                entity.SoSanPhanTrenSoDo = model.SoSanPhanTrenSoDo;
                entity.SoLaoDongTrenDayTruyen = model.SoLaoDongTrenDayTruyen;
                entity.LoiNhuanDuKien = model.LoiNhuanDuKien;
                entity.PhuPhi = model.PhuPhi;
                entity.KhoanPhiKhac = model.KhoanPhiKhac;
                entity.ModifiedBy = model.ModifiedBy;
                
                _context.Aos.Update(entity);
                var result = _context.SaveChanges();
                return Ok(result);

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var reuslt = _context.Aos.FirstOrDefault(x => x.MaA == id);
                if (reuslt == null)
                {
                    return BadRequest("can not find by id");
                }
                _context.Aos.Remove(reuslt);
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
