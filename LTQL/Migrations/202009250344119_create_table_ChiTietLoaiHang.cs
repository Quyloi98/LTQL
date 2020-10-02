namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_ChiTietLoaiHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietLoaiHangs",
                c => new
                    {
                        MaNCC = c.String(nullable: false, maxLength: 10),
                        TenNCC = c.String(maxLength: 10),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaNCC);
            
            CreateTable(
                "dbo.HangHoas",
                c => new
                    {
                        MaHH = c.String(nullable: false, maxLength: 10),
                        TenHH = c.String(maxLength: 50),
                        Gia = c.Int(nullable: false),
                        NSX = c.DateTime(nullable: false),
                        HSD = c.DateTime(nullable: false),
                        MaLHH = c.String(maxLength: 10),
                        GhiChu = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaHH);
            
            CreateTable(
                "dbo.NhaCC",
                c => new
                    {
                        MaNCC = c.String(nullable: false, maxLength: 128),
                        TenNCC = c.String(),
                        DiaChi = c.String(),
                        SDT = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaNCC);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        TaiKhoan = c.String(nullable: false, maxLength: 128),
                        MatKhau = c.String(),
                    })
                .PrimaryKey(t => t.TaiKhoan);
            
            AlterColumn("dbo.NhanViens", "TenNV", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NhanViens", "TenNV", c => c.String());
            DropTable("dbo.User");
            DropTable("dbo.NhaCC");
            DropTable("dbo.HangHoas");
            DropTable("dbo.ChiTietLoaiHangs");
        }
    }
}
