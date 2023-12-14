namespace MVC5OnlineTicariOtomasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SatisHarekets", "Fiyat", c => c.Int(nullable: false));
            AlterColumn("dbo.SatisHarekets", "ToplamTutar", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SatisHarekets", "ToplamTutar", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.SatisHarekets", "Fiyat", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
