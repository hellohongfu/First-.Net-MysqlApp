

namespace ConsoleApp1
{
    

    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Diagnostics.CodeAnalysis;

    public partial class FirstMySqlEntityModel : DbContext
    {
        public FirstMySqlEntityModel()
            : base("name=FirstMySqlEntityModel")
        {


            
        }
        public virtual DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

    }

    public class Video
    {
        private string name;
        private string url;
        private int id;

        public string Name { get => name; set => name = value; }
        public string Url { get => url; set => url = value; }
        public int Id { get => id; set => id = value; }

        public string Description { get; set; }

        public float Price { get; set; }

    }




}
