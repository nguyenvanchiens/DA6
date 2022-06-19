using DA6.Api.ViewModel.Response;
using DA6.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DA6.Api.Controllers
{
    public class TypeController : BaseController
    {
        public TypeController(DA6DbContext context) : base(context)
        {
        }
        [HttpGet("GetAllKieuTay")]
        public IActionResult GetAllKieuTay()
        {
            try
            {
                var result = _context.KieuTays.Select(s=> new ResponseSelect{
                    Value = s.MaKieuTay.ToString(),
                    Label = s.TenKieu,
                    GroupLabel = "Tên kiểu tay",
                    CreatedDate = s.CreatedDate,
                }).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
         [HttpGet("GetAllKieuCuaTay")]
        public IActionResult GetAllKieuCuaTay()
        {
            try
            {
                var result = _context.KieuCuaTays.Select(s=> new ResponseSelect{
                    Value = s.MaKieuCuaTay.ToString(),
                    Label = s.TenKieuCuaTay,
                    GroupLabel = "Tên kiểu cửa tay",
                    CreatedDate = s.CreatedDate,
                }).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("GetAllKieuGau")]
        public IActionResult GetAllKieuGau()
        {
            try
            {
                var result = _context.KieuGaus.Select(s=> new ResponseSelect{
                    Value = s.MaKieuGau.ToString(),
                    Label = s.TenKieuGau,
                    GroupLabel = "Tên kiểu gấu",
                    CreatedDate = s.CreatedDate,
                }).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("GetAllKieuCo")]
        public IActionResult GetAllKieuCo()
        {
            try
            {
                var result = _context.KieuCos.Select(s=> new ResponseSelect{
                    Value = s.MaKieuCo.ToString(),
                    Label = s.TenKieuCo,
                    GroupLabel = "Tên kiểu cổ",
                    CreatedDate = s.CreatedDate,
                }).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("GetAllKieuTui")]
        public IActionResult GetAllKieuTui()
        {
            try
            {
                var result = _context.KieuTuis.Select(s=> new ResponseSelect{
                    Value = s.MaKieuTui.ToString(),
                    Label = s.TenKieuTui,
                    GroupLabel = "Tên kiểu túi",
                    CreatedDate = s.CreatedDate,
                }).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("GetAllKieuNep")]
        public IActionResult GetAllKieuNep()
        {
            try
            {
                var result = _context.KieuNeps.Select(s=> new ResponseSelect{
                    Value = s.MaKieuNep.ToString(),
                    Label = s.TenKieuNep,
                    GroupLabel = "Tên kiểu nẹp",
                    CreatedDate = s.CreatedDate,
                }).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("GetAllKieuthantruoc")]
        public IActionResult GetAllKieuThanTruoc()
        {
            try
            {
                var result = _context.KieuThanTruocs.Select(s=> new ResponseSelect{
                    Value = s.MaKieuThanTruoc.ToString(),
                    Label = s.TenKieuThanTruoc,
                    GroupLabel = "Tên kiểu thân trước",
                    CreatedDate = s.CreatedDate,
                }).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("GetAllKieuXe")]
        public IActionResult GetAllKieuXe()
        {
            try
            {
                var result = _context.KieuXes.Select(s=> new ResponseSelect{
                    Value = s.MaKieuXe.ToString(),
                    Label = s.TenKieuXe,
                    GroupLabel = "Tên kiểu xẻ",
                    CreatedDate = s.CreatedDate,
                }).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("GetAllKieuThanSau")]
        public IActionResult GetAllKieuThanSau()
        {
            try
            {
                var result = _context.KieuThanSaus.Select(s=> new ResponseSelect{
                    Value = s.MaKieuThanSau.ToString(),
                    Label = s.TenKieuThanSau,
                    GroupLabel = "Tên kiểu thân sau",
                    CreatedDate = s.CreatedDate,
                }).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("GetAllThanhPhanVai1")]
        public IActionResult GetAllThanhPhanVai()
        {
            try
            {
                var result = _context.ThanhPhanVais.Select(s=> new ResponseSelect{
                    Value = s.MaThanhPhanVai.ToString(),
                    Label = s.TenThanhPhanVai,
                    GroupLabel = "Tên thành phần vải",
                    CreatedDate = s.CreatedDate,
                }).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("GetAllThanhPhanVai2")]
        public IActionResult GetAllThanhPhanVai1()
        {
            try
            {
                var result = _context.ThanhPhanVai2s.Select(s=> new ResponseSelect{
                    Value = s.MaThanhPhanVai2.ToString(),
                    Label = s.TenThanhPhanVai2,
                    GroupLabel = "Tên thành phần vải",
                    CreatedDate = s.CreatedDate,
                }).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("GetAllThanhPhanVai3")]
        public IActionResult GetAllThanhPhanVai3()
        {
            try
            {
                var result = _context.ThanhPhanVai3s.Select(s=> new ResponseSelect{
                    Value = s.MaThanhPhanVai3.ToString(),
                    Label = s.TenThanhPhanVai3,
                    GroupLabel = "Tên thành phần vải",
                    CreatedDate = s.CreatedDate,
                }).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("GetAllKieuThepTay")]
        public IActionResult KieuThepTay()
        {
            try
            {
                var result = _context.KieuThepTays.Select(s=> new ResponseSelect{
                    Value = s.MaKieuThepTay.ToString(),
                    Label = s.TenKieuThepTay,
                    GroupLabel = "Tên kiểu thếp tay",
                    CreatedDate = s.CreatedDate,
                }).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("GetAllChungloai")]
        public IActionResult GetAllChungloai()
        {
            try
            {
                var result = _context.ChungLoais.Where(s=>s.Level==1).Select(s=> new ResponseSelect{
                    Value = s.MaCL.ToString(),
                    Label = s.Ten,
                    GroupLabel = "Tên thành phần vải",
                    CreatedDate = s.CreatedDate,
                }).ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
