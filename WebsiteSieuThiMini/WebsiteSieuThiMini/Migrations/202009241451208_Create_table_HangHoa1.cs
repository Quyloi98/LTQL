namespace WebsiteSieuThiMini.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_HangHoa1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.HangHoas", newName: "HangHoa");
            DropPrimaryKey("dbo.HangHoa");
            AddColumn("dbo.HangHoa", "Gia", c => c.String(unicode: false));
            AddColumn("dbo.HangHoa", "NSX", c => c.String(unicode: false));
            AddColumn("dbo.HangHoa", "HSD", c => c.String(unicode: false));
            AddColumn("dbo.HangHoa", "MaLoaiHangHoa", c => c.String(maxLength: 10, unicode: false));
            AddColumn("dbo.HangHoa", "GhiChu", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.HangHoa", "MaHangHoa", c => c.String(nullable: false, maxLength: 10, unicode: false));
            AlterColumn("dbo.HangHoa", "TenHangHoa", c => c.String(maxLength: 50, unicode: false));
            AddPrimaryKey("dbo.HangHoa", "MaHangHoa");
            DropColumn("dbo.HangHoa", "LoaiHangHoa");
            DropColumn("dbo.HangHoa", "HanDung");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HangHoa", "HanDung", c => c.String(unicode: false));
            AddColumn("dbo.HangHoa", "LoaiHangHoa", c => c.String(unicode: false));
            DropPrimaryKey("dbo.HangHoa");
            AlterColumn("dbo.HangHoa", "TenHangHoa", c => c.String(unicode: false));
            AlterColumn("dbo.HangHoa", "MaHangHoa", c => c.String(nullable: false, maxLength: 128, unicode: false));
            DropColumn("dbo.HangHoa", "GhiChu");
            DropColumn("dbo.HangHoa", "MaLoaiHangHoa");
            DropColumn("dbo.HangHoa", "HSD");
            DropColumn("dbo.HangHoa", "NSX");
            DropColumn("dbo.HangHoa", "Gia");
            AddPrimaryKey("dbo.HangHoa", "MaHangHoa");
            RenameTable(name: "dbo.HangHoa", newName: "HangHoas");
        }
    }
}
