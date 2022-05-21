using DA6.Core.Data;
using DA6.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.Style;

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
        public IActionResult Get(string id)
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
                model.CreatedDate = DateTime.Now;
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
        public IActionResult Update(string id, [FromBody] Ao model)
        {
            try
            {
                var entity = _context.Aos.FirstOrDefault(x => x.MaA == id);
                if (entity == null)
                {
                    return BadRequest("error");
                }
                entity.MaA = model.MaA;
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
        public IActionResult Delete(string id)
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
        //[HttpGet("Export")]
        //public IActionResult Export()
        //{

        //    ////Format Ctrl+A -> Home -> Format -> Column(with, height)

        //    var stream = new MemoryStream();
        //    var listAo = _context.Aos.ToList();
        //    var filePath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\DA6.Api\Template\Danh_sach_ao.xlsx"));
        //    FileInfo existingFile = new FileInfo(filePath);
        //    //ExcelPackage.LicenseContext = LicenseContext.Commercial;
        //    // If you use EPPlus in a noncommercial context
        //    // according to the Polyform Noncommercial license:
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        //    using (ExcelPackage package = new ExcelPackage(existingFile))
        //    {
        //        //get the first worksheet in the workbook
        //        ExcelWorksheet sheet = package.Workbook.Worksheets[0];
        //        // đổ dữ liệu vào sheet

        //        int rowId = 4;
        //        int stt = 1;
        //        foreach (var ao in listAo)
        //        {
        //            sheet.Cells[rowId, 1].AutoFitColumns(10, 10);
        //            for (int i = 1; i <= 9; i++)
        //            {
        //                // Thêm border cho cột
        //                sheet.Cells[rowId, i].Style.Border.Top.Style = ExcelBorderStyle.Thin;
        //                sheet.Cells[rowId, i].Style.Border.Left.Style = ExcelBorderStyle.Thin;
        //                sheet.Cells[rowId, i].Style.Border.Right.Style = ExcelBorderStyle.Thin;
        //                sheet.Cells[rowId, i].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
        //                // Thêm width vs height cho cột
        //                sheet.Cells[rowId, i + 1].AutoFitColumns(20, 30);
        //                sheet.Cells[rowId, i + 1].Merge = true;
        //            }

        //            sheet.Cells[rowId, 1].Value = stt;
        //            sheet.Cells[rowId, 2].Value = ao.EmployeeCode;
        //            sheet.Cells[rowId, 3].Value = ao.EmployeeName;
        //            sheet.Cells[rowId, 4].Value = ao.GenderName;
        //            sheet.Cells[rowId, 5].Value = ao.DateOfBirth;
        //            sheet.Cells[rowId, 6].Value = ao.EmployeePosition;
        //            sheet.Cells[rowId, 7].Value = ao.DepartmentName;
        //            sheet.Cells[rowId, 8].Value = ao.BankAccountNumber;
        //            sheet.Cells[rowId, 9].Value = ao.BankName;
        //            stt++;
        //            rowId++;
        //        }
        //        stream = new MemoryStream(package.GetAsByteArray());
        //    }
        //    stream.Position = 0;
        //    var fileName = $"DanhSachAo_{DateTime.Now.ToString("dd-MM-yyyy")}.xlsx";
        //    return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
        //        fileName);
        //}
    }
}
