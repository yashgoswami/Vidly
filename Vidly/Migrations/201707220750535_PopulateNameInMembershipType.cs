namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNameInMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes set Name='Pay as you go' WHERE Id=1");
            Sql("Update MembershipTypes set Name='Monthly' WHERE Id=2");
            Sql("Update MembershipTypes set Name='Quaterly' WHERE Id=3");
            Sql("Update MembershipTypes set Name='Annualy' WHERE Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
