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
    }
}
