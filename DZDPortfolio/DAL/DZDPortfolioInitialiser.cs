using DZDPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DZDPortfolio.DAL
{
    public class DZDPortfolioInitialiser: System.Data.Entity.DropCreateDatabaseIfModelChanges<DZDPortfolioContext>
    {
        protected override void Seed(DZDPortfolioContext context)
        {

            var tempProgrammingProject = new ProgrammingProject();
            tempProgrammingProject.ProjectTitle = "TestPP";
            tempProgrammingProject.UploadDate = DateTime.Now;
            context.ProgrammingProjects.Add(tempProgrammingProject);


            var tempDroneProject = new DroneProject();
            tempDroneProject.ProjectTitle = "TestDP";
            tempDroneProject.UploadDate = DateTime.Now;
            context.DroneProjects.Add(tempDroneProject);

            var tempThreeDPrintingProject = new ThreeDPrintingProject();
            tempThreeDPrintingProject.ProjectTitle = "Test3D";
            tempThreeDPrintingProject.UploadDate = DateTime.Now;
            context.ThreeDPrintingProjects.Add(tempThreeDPrintingProject);



            context.SaveChanges();



        }
    }
}