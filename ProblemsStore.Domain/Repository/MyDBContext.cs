using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using ProblemsStore.Domain.Entities;

namespace ProblemsStore.Domain.Repository
{
    public class MyDBContext : DbContext
    {
        public MyDBContext()
        {
            Database.SetInitializer<MyDBContext>(null); //new DropCreateDatabaseAlways<MyDBContext>() , new DropCreateDatabaseIfModelChanges<MyDBContext>()
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Technology>().HasRequired(p => p.job)
            //             .WithMany(b => b.Technologies);
                         //.HasForeignKey(b => b.FKTechnologyId);


            //one-to-many Relationship between DataStructure and Problems
            modelBuilder.Entity<Problems>().HasRequired(Prob => Prob.DataStructure).WithMany();

                        
        }

        public DbSet<Problems> Problems { get; set; }
        //public DbSet<Resume> Resume { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<DataStructure> DatatStructures {get;set;}

        //Blogs 
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogContent> BlogContents { get; set; }
        public DbSet<Paragraph> Paragraphs { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<BulletList> BulletLists { get; set; }
        public DbSet<Header> Headers { get; set; }

        //Test
        //public DbSet<ZipData> ZipDatas { get; set; }
        
    
    }
}