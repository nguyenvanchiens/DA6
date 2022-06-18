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
                var result = _context.KieuTays.ToList();
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
                var result = _context.KieuCuaTays.ToList();
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
                var result = _context.KieuGaus.ToList();
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
                var result = _context.KieuCos.ToList();
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
                var result = _context.KieuTuis.ToList();
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
                var result = _context.KieuNeps.ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("")]
        public IActionResult GetAllKieuThanTruoc()
        {
            try
            {
                var result = _context.KieuThanTruocs.ToList();
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
                var result = _context.KieuXes.ToList();
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
                var result = _context.KieuThanSaus.ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("GetAllThanhPhanVai")]
        public IActionResult GetAllThanhPhanVai()
        {
            try
            {
                var result = _context.ThanhPhanVais.ToList();
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
                var result = _context.ThanhPhanVai2s.ToList();
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
                var result = _context.ThanhPhanVai3s.ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("KieuThepTay")]
        public IActionResult KieuThepTay()
        {
            try
            {
                var result = _context.KieuThepTays.ToList();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
