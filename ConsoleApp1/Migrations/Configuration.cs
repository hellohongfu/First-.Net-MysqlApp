namespace ConsoleApp1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ConsoleApp1.FirstMySqlEntityModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.EntityFramework.MySqlMigrationSqlGenerator());
            //https://jeffprogrammer.wordpress.com/2016/07/15/ef-6-%E9%80%A3-mariadb%E7%9A%84%E9%8C%AF%E8%AA%A4no-migrationsqlgenerator-found-for-provider-mysql-data-mysqlclient/

        }

        protected override void Seed(ConsoleApp1.FirstMySqlEntityModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
