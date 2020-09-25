namespace WebsiteSieuThiMini.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLST : DbContext
    {
        public QLST()
            : base("name=QLST")
        {
        }

        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<ChiTietLoaiHang> ChiTietLoaiHangs { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Khaìch HaÌng
            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenKhachHang)
                .IsUnicode(true);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DiaChi)
                .IsUnicode(true);

            //NhaÌ cuÌng câìp

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaNhaCungCap)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.DiaChi)
                .IsUnicode(true);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.TenNhaCungCap)
                .IsUnicode(true);

            //HaÌng Hoìa

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaHangHoa)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
               .Property(e => e.TenHangHoa)
                .IsUnicode(true);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaLoaiHangHoa)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
               .Property(e => e.GhiChu)
                .IsUnicode(false);

            //Chi tiêìt loaòi haÌng

            modelBuilder.Entity<ChiTietLoaiHang>()
               .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietLoaiHang>()
               .Property(e => e.MaLHH)
                .IsUnicode(true);

        }
    }
}
