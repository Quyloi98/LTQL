namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_NhaCC : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCC",
                c => new
                    {
                        MaNCC = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenNCC = c.String(),
                        DiaChi = c.String(),
                        SDT = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaNCC);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhaCC");
        }
    }
}
