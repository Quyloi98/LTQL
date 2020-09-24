namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_LoaiHangHoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoaiHangHoas",
                c => new
                    {
                        MaLHH = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenLHH = c.String(),
                        GhiChu = c.String(),
                        MaGH = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MaLHH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LoaiHangHoas");
        }
    }
}
