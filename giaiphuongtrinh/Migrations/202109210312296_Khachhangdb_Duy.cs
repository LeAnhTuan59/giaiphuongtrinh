
namespace giaiphuongtrinh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Khachhangdb_Duy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khachhangs",
                c => new
                    {
                        MaKH = c.String(nullable: false, maxLength: 128, unicode: false),
                        TenKH = c.String(),
                    })
                .PrimaryKey(t => t.MaKH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Khachhangs");
        }
    }
}
