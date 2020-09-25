namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_HoaDon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        MaHD = c.String(nullable: false, maxLength: 128, unicode: false),
                        NgayLap = c.DateTime(nullable: false),
                        MaNV = c.String(nullable: false, unicode: false),
                        MaKH = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MaHD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HoaDons");
        }
    }
}
