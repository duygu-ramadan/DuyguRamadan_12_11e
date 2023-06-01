namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedbListToInt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "SeatNumbers", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "SeatNumbers");
        }
    }
}
