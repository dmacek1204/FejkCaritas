namespace FejkCaritas2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Citizenships",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Volunteers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Username = c.String(),
                        Email = c.String(),
                        OIB = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        SexID = c.Int(nullable: false),
                        PotentialVolunteer = c.Boolean(nullable: false),
                        OutsideVolunteer = c.Boolean(nullable: false),
                        CitizenshipID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Citizenships", t => t.CitizenshipID, cascadeDelete: true)
                .ForeignKey("dbo.Sexes", t => t.SexID, cascadeDelete: true)
                .Index(t => t.SexID)
                .Index(t => t.CitizenshipID);
            
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        NumberOfHours = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        VolunteerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Volunteers", t => t.VolunteerID, cascadeDelete: true)
                .Index(t => t.VolunteerID);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        NumberOfHours = c.Int(nullable: false),
                        VolunteerId = c.Int(nullable: false),
                        DocumentTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.DocumentTypes", t => t.DocumentTypeID, cascadeDelete: true)
                .ForeignKey("dbo.Volunteers", t => t.VolunteerId, cascadeDelete: true)
                .Index(t => t.VolunteerId)
                .Index(t => t.DocumentTypeID);
            
            CreateTable(
                "dbo.DocumentTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Description = c.String(),
                        ExpenseTypeID = c.Int(nullable: false),
                        VolunteerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ExpenseTypes", t => t.ExpenseTypeID, cascadeDelete: true)
                .ForeignKey("dbo.Volunteers", t => t.VolunteerID, cascadeDelete: true)
                .Index(t => t.ExpenseTypeID)
                .Index(t => t.VolunteerID);
            
            CreateTable(
                "dbo.ExpenseTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VolunteeringHours",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        NumberOfHours = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        VolunteerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Volunteers", t => t.VolunteerID, cascadeDelete: true)
                .Index(t => t.VolunteerID);
            
            CreateTable(
                "dbo.Sexes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Volunteers", "SexID", "dbo.Sexes");
            DropForeignKey("dbo.VolunteeringHours", "VolunteerID", "dbo.Volunteers");
            DropForeignKey("dbo.Expenses", "VolunteerID", "dbo.Volunteers");
            DropForeignKey("dbo.Expenses", "ExpenseTypeID", "dbo.ExpenseTypes");
            DropForeignKey("dbo.Documents", "VolunteerId", "dbo.Volunteers");
            DropForeignKey("dbo.Documents", "DocumentTypeID", "dbo.DocumentTypes");
            DropForeignKey("dbo.Contracts", "VolunteerID", "dbo.Volunteers");
            DropForeignKey("dbo.Volunteers", "CitizenshipID", "dbo.Citizenships");
            DropIndex("dbo.VolunteeringHours", new[] { "VolunteerID" });
            DropIndex("dbo.Expenses", new[] { "VolunteerID" });
            DropIndex("dbo.Expenses", new[] { "ExpenseTypeID" });
            DropIndex("dbo.Documents", new[] { "DocumentTypeID" });
            DropIndex("dbo.Documents", new[] { "VolunteerId" });
            DropIndex("dbo.Contracts", new[] { "VolunteerID" });
            DropIndex("dbo.Volunteers", new[] { "CitizenshipID" });
            DropIndex("dbo.Volunteers", new[] { "SexID" });
            DropTable("dbo.Sexes");
            DropTable("dbo.VolunteeringHours");
            DropTable("dbo.ExpenseTypes");
            DropTable("dbo.Expenses");
            DropTable("dbo.DocumentTypes");
            DropTable("dbo.Documents");
            DropTable("dbo.Contracts");
            DropTable("dbo.Volunteers");
            DropTable("dbo.Citizenships");
        }
    }
}
