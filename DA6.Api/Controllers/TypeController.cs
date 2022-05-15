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
        [HttpGet]
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
         [HttpGet]
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
        [HttpGet]
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
        [HttpGet]
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
        [HttpGet]
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
        [HttpGet]
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
        [HttpGet]
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
        [HttpGet]
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
        [HttpGet]
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
        [HttpGet]
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

    }
}
