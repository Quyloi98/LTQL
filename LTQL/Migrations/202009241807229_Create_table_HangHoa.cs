namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_HangHoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HangHoas",
                c => new
                    {
                        MaHH = c.String(nullable: false, maxLength: 10, unicode: false),
                        TenHH = c.String(maxLength: 50),
                        Gia = c.Int(nullable: false),
                        NSX = c.DateTime(nullable: false),
                        HSD = c.DateTime(nullable: false),
                        MaLHH = c.String(maxLength: 10, unicode: false),
                        GhiChu = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaHH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HangHoas");
        }
    }
}
