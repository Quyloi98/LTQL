namespace WebsiteSieuThiMini.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhaCungCap : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhaCungCaps",
                c => new
                    {
                        MaNhaCungCap = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenNhaCungCap = c.String(unicode: false),
                        SoDienThoai = c.String(maxLength: 15, unicode: false),
                        DiaChi = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MaNhaCungCap);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhaCungCaps");
        }
    }
}
