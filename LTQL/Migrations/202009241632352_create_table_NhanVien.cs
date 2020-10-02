namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_NhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenNV = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                        QueQuan = c.String(),
                        SDT = c.Int(nullable: false),
                        Luong = c.Int(nullable: false),
                        MaGH = c.String(unicode: false),
                        GioiTinh = c.String(),
                    })
                .PrimaryKey(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhanViens");
        }
    }
}
