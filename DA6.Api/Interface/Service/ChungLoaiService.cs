using DA6.Api.Interface.IService;
using DA6.Core.Data;
using DA6.Core.Entities;

namespace DA6.Api.Interface.Service
{
    public class ChungLoaiService : BaseService<ChungLoai>, IChungLoaiService
    {
        public ChungLoaiService(DA6DbContext context) : base(context)
        {
        }
    }
}
