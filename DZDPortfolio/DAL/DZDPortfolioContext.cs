using DZDPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DZDPortfolio.DAL
{
    public class DZDPortfolioContext : DbContext
    {
        public DZDPortfolioContext() : base("DZDPortfolioContext")
        {
            Database.SetInitializer<DZDPortfolioContext>(new DZDPortfolioInitialiser());
        }

        public DbSet<Image> Images { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<ProgrammingProject> ProgrammingProjects { get; set; }
        public DbSet<DroneProject> DroneProjects { get; set; }
        public DbSet<ThreeDPrintingProject> ThreeDPrintingProjects { get; set; }

    }
}