namespace Portfolio.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoginSenhaDrop : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cliente", "Login");
            DropColumn("dbo.Cliente", "Senha");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cliente", "Senha", c => c.String());
            AddColumn("dbo.Cliente", "Login", c => c.String(nullable: false));
        }
    }
}
