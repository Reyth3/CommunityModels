using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CommunitiesChat.Models.DB
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class AppContext : DbContext
    {
        public AppContext()
        {
            Database.CreateIfNotExists();
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AppContext>());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Community> Communities { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Identity> Identities { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
    }
}