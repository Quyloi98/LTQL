namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_KhachHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenKH = c.String(),
                        DiaChi = c.String(),
                        SoDT = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHangs");
        }
    }
}
