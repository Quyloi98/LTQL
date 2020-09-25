namespace WebsiteSieuThiMini.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_KhachHang1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KhachHangs", "DiaChi", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.KhachHangs", "DiaChi");
        }
    }
}
