namespace WebsiteSieuThiMini.Migrations
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
                        MaHangHoa = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenHangHoa = c.String(unicode: false),
                        LoaiHangHoa = c.String(unicode: false),
                        HanDung = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MaHangHoa);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HangHoas");
        }
    }
}
