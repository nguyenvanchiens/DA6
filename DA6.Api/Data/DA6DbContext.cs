using DA6.Api.Entities;
using DA6.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA6.Core.Data
{
    public class DA6DbContext : DbContext
    {
        public DA6DbContext(DbContextOptions<DA6DbContext> options) : base(options)
        {

        }
        public DbSet<ChungLoai> ChungLoais { get; set; }
        public DbSet<Ao> Aos { get; set; }
        public DbSet<Quan>  Quans { get; set; }
        public DbSet<JacKet> JacKets { get; set; }
        public DbSet<LoaiTrangPhuc> LoaiTrangPhucs { get; set; }
        public DbSet<LoaiVai> LoaiVais { get; set; }
        public DbSet<QuyTrinhChiTiet> QuyTrinhChiTiets { get; set; }
        public DbSet<QuyTrinhSanPham> QuyTrinhSanPhams { get; set; }
        public DbSet<Vest>  Vests { get; set; }
        public DbSet<NguoiDung>   NguoiDungs{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
