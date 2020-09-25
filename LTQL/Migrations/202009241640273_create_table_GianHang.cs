namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_GianHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GianHangs",
                c => new
                    {
                        MaGH = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenGH = c.String(),
                        ViTri = c.String(),
                        MaNQL = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MaGH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GianHangs");
        }
    }
}
