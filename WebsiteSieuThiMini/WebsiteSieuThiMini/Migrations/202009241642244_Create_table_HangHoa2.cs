namespace WebsiteSieuThiMini.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_HangHoa2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HangHoa", "TenHangHoa", c => c.String(maxLength: 50));
            AlterColumn("dbo.HangHoa", "Gia", c => c.Int(nullable: false));
            AlterColumn("dbo.HangHoa", "NSX", c => c.DateTime(nullable: false));
            AlterColumn("dbo.HangHoa", "HSD", c => c.DateTime(nullable: false));
            AlterColumn("dbo.KhachHangs", "TenKhachHang", c => c.String());
            AlterColumn("dbo.KhachHangs", "DiaChi", c => c.String());
            AlterColumn("dbo.NhaCungCaps", "TenNhaCungCap", c => c.String());
            AlterColumn("dbo.NhaCungCaps", "DiaChi", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NhaCungCaps", "DiaChi", c => c.String(unicode: false));
            AlterColumn("dbo.NhaCungCaps", "TenNhaCungCap", c => c.String(unicode: false));
            AlterColumn("dbo.KhachHangs", "DiaChi", c => c.String(unicode: false));
            AlterColumn("dbo.KhachHangs", "TenKhachHang", c => c.String(unicode: false));
            AlterColumn("dbo.HangHoa", "HSD", c => c.String(unicode: false));
            AlterColumn("dbo.HangHoa", "NSX", c => c.String(unicode: false));
            AlterColumn("dbo.HangHoa", "Gia", c => c.String(unicode: false));
            AlterColumn("dbo.HangHoa", "TenHangHoa", c => c.String(maxLength: 50, unicode: false));
        }
    }
}
