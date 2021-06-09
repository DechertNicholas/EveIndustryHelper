using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SQLiteDBHandler
{
    public class SQLiteContext : DbContext
    {
        public DbSet<Type> Types { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Blueprint> Blueprints { get; set; }
        public DbSet<Graphic> Graphics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=Industry.db");
    }

    public class Type
    {
        public int TypeID { get; set; }
        public int graphicID { get; set; }
        public Dictionary<string, string> typeName { get; set; }
        public int groupID { get; set; }
    }

    public class Group
    {
        public int GroupId { get; set; }
    }

    public class Blueprint
    {
        public int BlueprintId { get; set; }
    }

    public class Graphic
    {
        public int GraphicId { get; set; }
    }
}
