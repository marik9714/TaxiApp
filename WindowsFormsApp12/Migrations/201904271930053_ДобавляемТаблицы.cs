namespace WindowsFormsApp12.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ДобавляемТаблицы : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarColors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ColorName = c.String(),
                        CreateionDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarkId = c.Int(),
                        CarColorId = c.Int(),
                        CreateionDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarColors", t => t.CarColorId)
                .ForeignKey("dbo.Marks", t => t.MarkId)
                .Index(t => t.MarkId)
                .Index(t => t.CarColorId);
            
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarkName = c.String(),
                        CreateionDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cashboxes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DriverId = c.Int(),
                        DispatcherId = c.Int(),
                        Profit = c.Decimal(precision: 18, scale: 2),
                        CreateionDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dispatchers", t => t.DispatcherId)
                .ForeignKey("dbo.Drivers", t => t.DriverId)
                .Index(t => t.DriverId)
                .Index(t => t.DispatcherId);
            
            CreateTable(
                "dbo.Dispatchers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        CreateionDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        CreateionDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientName = c.String(),
                        StreetId = c.Int(),
                        HomeNumber = c.Int(),
                        FlatNumber = c.Int(),
                        PhoneNumber = c.String(),
                        CreateionDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Streets", t => t.StreetId)
                .Index(t => t.StreetId);
            
            CreateTable(
                "dbo.Streets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateionDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Traffic",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderCreationTime = c.DateTime(),
                        CarId = c.Int(),
                        DriverId = c.Int(),
                        ClientId = c.Int(),
                        DispatcherId = c.Int(),
                        Note = c.String(),
                        OrederCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderType = c.Int(),
                        CreateionDateTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .ForeignKey("dbo.Dispatchers", t => t.DispatcherId)
                .ForeignKey("dbo.Drivers", t => t.DriverId)
                .Index(t => t.CarId)
                .Index(t => t.DriverId)
                .Index(t => t.ClientId)
                .Index(t => t.DispatcherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Traffic", "DriverId", "dbo.Drivers");
            DropForeignKey("dbo.Traffic", "DispatcherId", "dbo.Dispatchers");
            DropForeignKey("dbo.Traffic", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Traffic", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Clients", "StreetId", "dbo.Streets");
            DropForeignKey("dbo.Cashboxes", "DriverId", "dbo.Drivers");
            DropForeignKey("dbo.Cashboxes", "DispatcherId", "dbo.Dispatchers");
            DropForeignKey("dbo.Cars", "MarkId", "dbo.Marks");
            DropForeignKey("dbo.Cars", "CarColorId", "dbo.CarColors");
            DropIndex("dbo.Traffic", new[] { "DispatcherId" });
            DropIndex("dbo.Traffic", new[] { "ClientId" });
            DropIndex("dbo.Traffic", new[] { "DriverId" });
            DropIndex("dbo.Traffic", new[] { "CarId" });
            DropIndex("dbo.Clients", new[] { "StreetId" });
            DropIndex("dbo.Cashboxes", new[] { "DispatcherId" });
            DropIndex("dbo.Cashboxes", new[] { "DriverId" });
            DropIndex("dbo.Cars", new[] { "CarColorId" });
            DropIndex("dbo.Cars", new[] { "MarkId" });
            DropTable("dbo.Traffic");
            DropTable("dbo.Streets");
            DropTable("dbo.Clients");
            DropTable("dbo.Drivers");
            DropTable("dbo.Dispatchers");
            DropTable("dbo.Cashboxes");
            DropTable("dbo.Marks");
            DropTable("dbo.Cars");
            DropTable("dbo.CarColors");
        }
    }
}
