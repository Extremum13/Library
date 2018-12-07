namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Surname = c.String(),
                        Name = c.String(),
                        Patronymic = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
            CreateTable(
                "dbo.BookAuthors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Role = c.String(),
                        AuthorId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.Id, unique: true)
                .Index(t => t.AuthorId)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        EditorsName = c.String(),
                        EditionYear = c.DateTime(nullable: false),
                        Type = c.String(),
                        Genre = c.String(),
                        Language = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
            CreateTable(
                "dbo.BookCopies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CopyNumber = c.Int(nullable: false),
                        BookId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId)
                .Index(t => t.Id, unique: true)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.BookCopyInDeals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequiredDateOfReturning = c.DateTime(nullable: false),
                        ActualDateOfReturning = c.DateTime(),
                        BookCopyId = c.Int(),
                        DealId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BookCopies", t => t.BookCopyId)
                .ForeignKey("dbo.Deals", t => t.DealId)
                .Index(t => t.Id, unique: true)
                .Index(t => t.BookCopyId)
                .Index(t => t.DealId);
            
            CreateTable(
                "dbo.Deals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        ReaderId = c.Int(),
                        LibrarianId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Librarians", t => t.LibrarianId)
                .ForeignKey("dbo.Readers", t => t.ReaderId)
                .Index(t => t.Id, unique: true)
                .Index(t => t.ReaderId)
                .Index(t => t.LibrarianId);
            
            CreateTable(
                "dbo.Librarians",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Surname = c.String(),
                        Name = c.String(),
                        Patronymic = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        TelephoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
            CreateTable(
                "dbo.Readers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Surname = c.String(),
                        Name = c.String(),
                        Patronymic = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        TelephoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookAuthors", "BookId", "dbo.Books");
            DropForeignKey("dbo.BookCopyInDeals", "DealId", "dbo.Deals");
            DropForeignKey("dbo.Deals", "ReaderId", "dbo.Readers");
            DropForeignKey("dbo.Deals", "LibrarianId", "dbo.Librarians");
            DropForeignKey("dbo.BookCopyInDeals", "BookCopyId", "dbo.BookCopies");
            DropForeignKey("dbo.BookCopies", "BookId", "dbo.Books");
            DropForeignKey("dbo.BookAuthors", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Readers", new[] { "Id" });
            DropIndex("dbo.Librarians", new[] { "Id" });
            DropIndex("dbo.Deals", new[] { "LibrarianId" });
            DropIndex("dbo.Deals", new[] { "ReaderId" });
            DropIndex("dbo.Deals", new[] { "Id" });
            DropIndex("dbo.BookCopyInDeals", new[] { "DealId" });
            DropIndex("dbo.BookCopyInDeals", new[] { "BookCopyId" });
            DropIndex("dbo.BookCopyInDeals", new[] { "Id" });
            DropIndex("dbo.BookCopies", new[] { "BookId" });
            DropIndex("dbo.BookCopies", new[] { "Id" });
            DropIndex("dbo.Books", new[] { "Id" });
            DropIndex("dbo.BookAuthors", new[] { "BookId" });
            DropIndex("dbo.BookAuthors", new[] { "AuthorId" });
            DropIndex("dbo.BookAuthors", new[] { "Id" });
            DropIndex("dbo.Authors", new[] { "Id" });
            DropTable("dbo.Readers");
            DropTable("dbo.Librarians");
            DropTable("dbo.Deals");
            DropTable("dbo.BookCopyInDeals");
            DropTable("dbo.BookCopies");
            DropTable("dbo.Books");
            DropTable("dbo.BookAuthors");
            DropTable("dbo.Authors");
        }
    }
}
