namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_ChiTietLoaiHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietLoaiHangs",
                c => new
                    {
                        MaNCC = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenNCC = c.String(maxLength: 10, unicode: false),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaNCC);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChiTietLoaiHangs");
        }
    }
}
