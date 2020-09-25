namespace LTQL.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LTQL : DbContext
    {
        public LTQL()
            : base("name=LTQL")
        {
        }
        public virtual DbSet<NhaCC> NhaCCs { get; set; }
        public virtual DbSet<ChiTietLoaiHang> ChiTietLoaiHangs { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Nha� Cung c��p
            modelBuilder.Entity<NhaCC>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);
            modelBuilder.Entity<NhaCC>()
                .Property(e => e.TenNCC)
                .IsUnicode(true);
            modelBuilder.Entity<NhaCC>()
                .Property(e => e.DiaChi)
                .IsUnicode(true);

            //Chi ti��t ha�ng ho�a
            modelBuilder.Entity<ChiTietLoaiHang>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);
            modelBuilder.Entity<ChiTietLoaiHang>()
                .Property(e => e.TenNCC)
                .IsUnicode(false);

            //Ha�ng ho�a
            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaHH)
                .IsUnicode(false);
            modelBuilder.Entity<HangHoa>()
                .Property(e => e.TenHH)
                .IsUnicode(true);
            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaLHH)
                .IsUnicode(false);
            modelBuilder.Entity<HangHoa>()
                .Property(e => e.GhiChu)
                .IsUnicode(true);

            //User
            modelBuilder.Entity<User>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);
            modelBuilder.Entity<User>()
               .Property(e => e.MatKhau)
               .IsUnicode(false);
        }
    }
}
