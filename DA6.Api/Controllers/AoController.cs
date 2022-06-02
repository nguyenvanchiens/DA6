using DA6.Api.Entities;
using DA6.Api.ViewModel;
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
        [HttpGet("get-by-id")]
        public IActionResult Get([FromQuery]string id)
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

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Ao model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("error");
                }
                var isvalid = await Validate(model);
                if (!isvalid.isOk)
                {
                    return BadRequest(isvalid.Message);
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
        private async Task<Responsive> Validate(Ao ao,bool isUpdate=false)
        {
            var message = "";
            if(ao == null)
            {
                message = "Không thể bỏ trống dữ liệu";
                return new Responsive(message);
            }
            if (ao.MaA == null)
            {
                message = "Không thể bỏ trống dữ liệu";
                return new Responsive(message);
            }
            if (isUpdate == true)
            {
                var entity = _context.Aos.Find(ao.MaA);
                if(entity!=null && entity.MaA != ao.MaA)
                {
                    message = "Mã áo đã tồn tại";
                    return new Responsive(message);
                }
            }
            if (isUpdate == false)
            {
                var entity = _context.Aos.Find(ao.MaA);
                if (entity != null)
                {
                    message = "Mã áo đã tồn tại";
                    return new Responsive(message);
                }
            }
            return new Responsive("",true);
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update([FromQuery]string id, [FromBody] Ao model)
        {
            try
            {
                var entity = _context.Aos.FirstOrDefault(x => x.MaA == id);
                if (entity == null)
                {
                    return BadRequest("error");
                }
                var isValid = await Validate(model,true);
                if (!isValid.isOk)
                {
                    return BadRequest(isValid.Message);
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

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] string id)
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
        [HttpPost("create-option-ao")]
        public IActionResult CreateOptionAo([FromBody] OptionAo optionAo)
        {
            try
            {
                _context.OptionAos.Add(optionAo);
                var ressult = _context.SaveChanges();
                return Ok(ressult);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("get-option-ao")]
        public IActionResult GetOptionAo([FromQuery] string MaAo)
        {
            try
            {
                var option = _context.OptionAos.FirstOrDefault(x => x.MaAo == MaAo);
                return Ok(option);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("update-option-ao")]
        public IActionResult UpdateOptionAo([FromQuery]string MaAo,[FromBody]OptionAo model)
        {
            try
            {
                var option = _context.OptionAos.Find(MaAo);
                if (option == null)
                {
                    return BadRequest("Can not find by Id");
                }
                option.MaKieuTay = model.MaKieuTay;
                option.MaKieuGau = model.MaKieuGau;
                option.MaKieuGau = model.MaKieuGau;
                option.MaKieuCo = model.MaKieuCo;
                option.MaKieuTui = model.MaKieuTui;
                option.MaKieuNep = model.MaKieuNep;
                option.MaKieuThanTruoc = model.MaKieuThanTruoc;
                option.MaKieuXe = model.MaKieuXe;
                option.MaKieuThanSau = model.MaKieuThanSau;
                option.MaThanhPhanVai1 = model.MaThanhPhanVai1;
                option.MaThanhPhanVai2 = model.MaThanhPhanVai2;
                option.MaThanhPhanVai3 = model.MaThanhPhanVai3;
                _context.OptionAos.Update(option);
                var result = _context.SaveChanges();
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

   

}
