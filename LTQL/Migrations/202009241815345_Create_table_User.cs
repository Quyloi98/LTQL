namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_User : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        TaiKhoan = c.String(nullable: false, maxLength: 128, unicode: false),
                        MatKhau = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.TaiKhoan);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
        }
    }
}
