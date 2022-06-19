using DA6.Api.Entities;
using DA6.Api.ViewModel.Option;
using DA6.Api.ViewModel.PhuThuoc;
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
        public IActionResult GetAll([FromQuery] PhuThuocRequestModel request)
        {
            try
            {
                var phuthuoc = (from p in _context.PhuThuocs
                                join op in _context.OptionDauRas
                                on p.MaOptionDaura equals op.Id
                                where p.MaSanPham == request.MaSanPham && p.MaLoaiDauRa == request.MaLoaiDauRa
                                && p.MaDauRa == request.MaDauRa
                                select new { p, op }).Select(x => new PhuThuocResponModel()
                                {
                                    Id = x.p.MaOptionDaura,
                                    TenOptionDauRa = x.op.Name
                                }).OrderBy(s => s.Id).ToList();
                var option = _context.OptionDauRas.Select(x => new OptionViewModel()
                {
                    Value = x.Id.ToString(),
                    Label = x.Name
                }).ToList();
                foreach (var item in phuthuoc)
                {
                    foreach (var o in option)
                    {
                        if (o.Value == item.Id.ToString())
                        {
                            o.Checked = true;
                        }
                    }
                }
                return Ok(option);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
