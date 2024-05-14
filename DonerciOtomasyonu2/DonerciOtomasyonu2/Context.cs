using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonerciOtomasyonu2
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;database=DonerciOtomasyonu;Trusted_connection=True;TrustServerCertificate=true;");
            //String mysqlconstring = "server=localhost:3306;user id=root;database=sys;allowuservariables=True;password=mypassword;persistsecurityinfo=True;";
            //optionsBuilder.UseMySql(mysqlconstring);
        }
        public DbSet<Product> DonerciOtomasyonu { get; set; }
    }
}
