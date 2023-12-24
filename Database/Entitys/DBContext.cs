using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entitys
{
    public class DBContext :DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        public DbSet<TbConfiguration> TbConfiguration { get; set; }
        public DbSet<TbContent> TbContent { get; set; }
        public DbSet<TbFile> TbFile { get; set; }
        public DbSet<TbFileProduct> TbFileProduct { get; set; }
        public DbSet<TbProduct> TbProduct { get; set; }
        public DbSet<TbProductGroup> TbProductGroup { get; set; }
        public DbSet<TbUser> TbUser { get; set; }
    }
}
