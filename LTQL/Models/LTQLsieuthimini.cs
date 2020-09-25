namespace LTQL.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LTQLsieuthimini : DbContext
    {
        public LTQLsieuthimini()
            : base("name=LTQLsieuthimini")
        {
        }

        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<GianHang> GianHangs { get; set; }
        public virtual DbSet<LoaiHangHoa> LoaiHangHoas { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<ChiTietLoaiHang> ChiTietLoaiHangs { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<NhaCC> NhaCCs { get; set; }
        public virtual DbSet<User> Users { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /////////KhachHang////////////////
            
            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenKH)
                .IsUnicode(true);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.DiaChi)
                .IsUnicode(true);

            ////////HoaDon///////////////////////
            
            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKH)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            ////////NhanVien///////////////////
            
            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaGH)
                .IsUnicode(false);

            ///////GianHang///////////////////

            modelBuilder.Entity<GianHang>()
                .Property(e => e.MaGH)
                .IsUnicode(false);

            modelBuilder.Entity<GianHang>()
                .Property(e => e.MaNQL)
                .IsUnicode(false);

            ///////LoaiHangHoa////////////////

            modelBuilder.Entity<LoaiHangHoa>()
               .Property(e => e.MaLHH)
               .IsUnicode(false);

            modelBuilder.Entity<LoaiHangHoa>()
               .Property(e => e.MaGH)
               .IsUnicode(false);

            ///////ChiTietHoaDon////////////////

            modelBuilder.Entity<ChiTietHoaDon>()
               .Property(e => e.MaHD)
               .IsUnicode(false);

            modelBuilder.Entity<ChiTietHoaDon>()
               .Property(e => e.MaHH)
               .IsUnicode(false);
        }
    }
}
