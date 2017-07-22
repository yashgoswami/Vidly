namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Id, Name) VALUES(1, 'Comdey')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES(2, 'Action')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES(3, 'Family')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES(4, 'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
