namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_ChiTietHoaDon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietHoaDons",
                c => new
                    {
                        MaHD = c.String(nullable: false, maxLength: 128, unicode: false),
                        MaHH = c.String(unicode: false),
                        SoLuong = c.Int(nullable: false),
                        DonGia = c.Int(nullable: false),
                        ThanhTien = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaHD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChiTietHoaDons");
        }
    }
}
