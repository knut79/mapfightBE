using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using Microsoft.WindowsAzure.Mobile.Service;
using Microsoft.WindowsAzure.Mobile.Service.Tables;
using MapFight1Service.DataObjects;

namespace MapFight1Service.Models
{
    public class MapFight1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to alter your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
        //
        // To enable Entity Framework migrations in the cloud, please ensure that the 
        // service name, set by the 'MS_MobileServiceName' AppSettings in the local 
        // Web.config, is the same as the service name when hosted in Azure.
        private const string connectionStringName = "Name=MS_TableConnectionString";

        public MapFight1Context() : base(connectionStringName)
        {
        } 

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            string schema = ServiceSettingsDictionary.GetSchemaName();
            if (!string.IsNullOrEmpty(schema))
            {
                modelBuilder.HasDefaultSchema(schema);
            }

            modelBuilder.Conventions.Add(
                new AttributeToColumnAnnotationConvention<TableColumnAttribute, string>(
                    "ServiceTableColumn", (property, attributes) => attributes.Single().ColumnType.ToString()));
        }

        public DbSet<User> Users { get; set; }

        public System.Data.Entity.DbSet<MapFight1Service.DataObjects.UserFriend> UserFriends { get; set; }

        public System.Data.Entity.DbSet<MapFight1Service.DataObjects.Challenge> Challenges { get; set; }

        public System.Data.Entity.DbSet<MapFight1Service.DataObjects.ChallengeUser> ChallengeUsers { get; set; }

        public System.Data.Entity.DbSet<MapFight1Service.DataObjects.Highscore> Highscores { get; set; }

        public System.Data.Entity.DbSet<MapFight1Service.DataObjects.Question> Questions { get; set; }

        public System.Data.Entity.DbSet<MapFight1Service.DataObjects.ChallengeQuestion> ChallengeQuestions { get; set; }
    }

}
