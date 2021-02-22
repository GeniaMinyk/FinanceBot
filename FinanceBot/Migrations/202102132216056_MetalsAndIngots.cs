namespace FinanceBot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MetalsAndIngots : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        MetalId = c.Int(nullable: false),
                        Nominal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NoCertificateDollars = c.Decimal(precision: 18, scale: 2),
                        NoCertificateRubles = c.Decimal(precision: 18, scale: 2),
                        CertificateDollars = c.Decimal(precision: 18, scale: 2),
                        CertificateRubles = c.Decimal(precision: 18, scale: 2),
                        BanksDollars = c.Decimal(precision: 18, scale: 2),
                        BanksRubles = c.Decimal(precision: 18, scale: 2),
                        EntitiesDollars = c.Decimal(precision: 18, scale: 2),
                        EntitiesRubles = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Metals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NameEng = c.String(),
                        NameBel = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Metals");
            DropTable("dbo.Ingots");
        }
    }
}
