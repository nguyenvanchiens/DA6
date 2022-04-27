using DA6.Core.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DA6.Api.Controllers
{
    public class ChungLoaiController : BaseController
    {
        public ChungLoaiController(DA6DbContext data) : base(data)
        {
        }
    }
}
