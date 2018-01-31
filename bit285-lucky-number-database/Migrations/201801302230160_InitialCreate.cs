namespace bit285_lucky_number_database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LuckyNumbers",
                c => new
                    {
                        LuckyNumberID = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.LuckyNumberID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LuckyNumbers");
        }
    }
}
