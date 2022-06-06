using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;

namespace RoleBasedAuthorization.Models
{
    public partial class MyDbContext : DbContext
    {

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<LinkRolesMenus> LinkRolesMenus { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }

        public virtual DbSet<TblMonths> TblMonths { get; set; }
        public virtual DbSet<Levels> Levels { get; set; }

        public virtual DbSet<MonthlyReviews> MonthlyReviews { get; set;}
        public virtual DbSet<Sglookup> Sglookup { get; set; }

        public virtual DbSet<Offlinehours> Offlinehours { get; set; }

        public virtual DbSet<AssignMonthlyReviews> AssignMonthlyReviews { get; set;}
        public DbSet<Files> Files { get; set; }

        public virtual DbSet<UserActivity> UserActivities { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=127.0.0.1;User Id=sa;password=Admin@123456;Database=issacpaymentautomation;SslMode=none;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admins>(entity =>
            {
                entity.ToTable("admins");

                entity.HasIndex(e => e.RolesId)
                    .HasName("admins_ibfk_1");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(255);

                entity.Property(e => e.RolesId)
                    .HasColumnName("roles_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.parentadminroleid)
                    .HasColumnName("parentadminroleid")
                    .HasMaxLength(250);

                entity.Property(e => e.Level)
                    .HasColumnName("Level")
                    .HasMaxLength(255);
                
                entity.Property(e => e.userid)
                    .HasColumnName("userid")
                    .HasMaxLength(255);

                entity.HasOne(d => d.Roles)
                    .WithMany(p => p.Admins)
                    .HasForeignKey(d => d.RolesId)
                    .HasConstraintName("admins_ibfk_1");
            });

            modelBuilder.Entity<UserActivity>(entity =>
            {
                entity.ToTable("UserActivity");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(255);

                entity.Property(e => e.Data)
                    .HasColumnName("Data")
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .HasColumnName("Username")
                    .HasMaxLength(255);

                entity.Property(e => e.IpAddress)
                   .HasColumnName("IPAddress")
                   .HasMaxLength(255);

                entity.Property(e => e.ActivityDate)
                    .HasColumnName("ActivityDate")
                    .HasMaxLength(255)
                    .HasColumnType("text");


                entity.Property(e => e.ClientPC)
                    .HasColumnName("ClientPC")
                    .HasMaxLength(255);
            });
            modelBuilder.Entity<LinkRolesMenus>(entity =>
            {
                entity.ToTable("link_roles_menus");

                entity.HasIndex(e => e.MenusId)
                    .HasName("menus_id");

                entity.HasIndex(e => e.RolesId)
                    .HasName("roles_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MenusId)
                    .HasColumnName("menus_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RolesId)
                    .HasColumnName("roles_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Menus)
                    .WithMany(p => p.LinkRolesMenus)
                    .HasForeignKey(d => d.MenusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("link_roles_menus_ibfk_1");

                entity.HasOne(d => d.Roles)
                    .WithMany(p => p.LinkRolesMenus)
                    .HasForeignKey(d => d.RolesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("link_roles_menus_ibfk_2");
            });

            modelBuilder.Entity<Menus>(entity =>
            {
                entity.ToTable("menus");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasColumnName("icon")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.ParentId)
                    .HasColumnName("parent_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.ToTable("roles");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Levels>(entity =>
            {
                entity.ToTable("levels");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("text");

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasColumnName("Level")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TblMonths>(entity =>
            {
                entity.ToTable("tblmonths");

                entity.Property(e => e.MonthId)
                    .HasColumnName("MonthId")
                    .HasColumnType("text");

                entity.Property(e => e.Month)
                    .IsRequired()
                    .HasColumnName("Month")
                    .HasColumnType("text");
            });
            modelBuilder.Entity<Sglookup>(entity =>
            {
                entity.ToTable("sglookup");

                entity.Property(e => e.LookupID)
                    .HasColumnName("LookupID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("Status")
                    .HasColumnType("text");

                entity.Property(e => e.JoinedDate)
                    .IsRequired()
                    .HasColumnName("JoinedDate")
                    .HasMaxLength(255)
                    .HasColumnType("text");

                entity.Property(e => e.Contract)
                    .IsRequired()
                    .HasColumnName("Contract")
                    .HasMaxLength(255)
                    .HasColumnType("text");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("FirstName")
                    .HasMaxLength(255)
                    .HasColumnType("text");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("LastName")
                    .HasMaxLength(255)
                    .HasColumnType("text");

                entity.Property(e => e.PacteraEdgeEmail)
                    .IsRequired()
                    .HasColumnName("PacteraEdgeEmail")
                    .HasMaxLength(255)
                    .HasColumnType("text");

                entity.Property(e => e.oneforma)
                    .IsRequired()
                    .HasColumnName("oneforma")
                    .HasMaxLength(255)
                    .HasColumnType("text");

                //entity.Property(e => e.UHRS)
                //    .IsRequired()
                //    .HasColumnName("UHRS")
                //    .HasMaxLength(255)
                //    .HasColumnType("text");

                entity.Property(e => e.PayRateUS)
                    .IsRequired()
                    .HasColumnName("PayRateUS")
                    .HasMaxLength(255)
                    .HasColumnType("text");

                entity.Property(e => e.UserID)
                    .IsRequired()
                    .HasColumnName("UserID")
                    .HasMaxLength(255)
                    .HasColumnType("text");

                entity.Property(e => e.SumOfTimeActive)
                    .IsRequired()
                    .HasColumnName("SumOfTimeActive")
                    .HasMaxLength(255)
                    .HasColumnType("int(11)");

                entity.Property(e => e.TotalTime)
                    .IsRequired()
                    .HasColumnName("TotalTime")
                    .HasMaxLength(255)
                    .HasColumnType("decimal(19,2)");

                entity.Property(e => e.Hrs)
                    .IsRequired()
                    .HasColumnName("Hrs")
                    .HasMaxLength(255)
                    .HasColumnType("decimal(19,2)");

                entity.Property(e => e.ActiveHrs)
                    .IsRequired()
                    .HasColumnName("ActiveHrs")
                    .HasMaxLength(255)
                    .HasColumnType("decimal(19,2)");

                entity.Property(e => e.InactiveHrs)
                    .IsRequired()
                    .HasColumnName("InactiveHrs")
                    .HasMaxLength(255)
                    .HasColumnType("decimal(19,2)");

                entity.Property(e => e.BillableInactiveHrs)
                    .IsRequired()
                    .HasColumnName("BillableInactiveHrs")
                    .HasMaxLength(255)
                    .HasColumnType("decimal(19,2)");

                entity.Property(e => e.TotalHrs)
                    .IsRequired()
                    .HasColumnName("TotalHrs")
                    .HasMaxLength(255)
                    .HasColumnType("decimal(19,2)");

                entity.Property(e => e.Productivity)
                    .IsRequired()
                    .HasColumnName("Productivity")
                    .HasMaxLength(255)
                    .HasColumnType("decimal(19,2)");

                entity.Property(e => e.ProductivityPercentage)
                    .IsRequired()
                    .HasColumnName("ProductivityPercentage")
                    .HasMaxLength(255)
                    .HasColumnType("decimal(19,2)");

                entity.Property(e => e.deleted)
                   .HasColumnName("deleted")
                   .HasMaxLength(150)
                   .HasColumnType("text");

                entity.Property(e => e.averagerating)
                   .HasColumnName("averagerating")
                   .HasMaxLength(150)
                   .HasColumnType("text");

                entity.Property(e => e.quality)
                   .IsRequired()
                   .HasColumnName("quality")
                   .HasMaxLength(255)
                   .HasColumnType("decimal(19,2)");

                entity.Property(e => e.qualitypercentage)
                   .IsRequired()
                   .HasColumnName("qualitypercentage")
                   .HasMaxLength(255)
                   .HasColumnType("decimal(19,2)");

                entity.Property(e => e.averagescore)
                   .IsRequired()
                   .HasColumnName("averagescore")
                   .HasMaxLength(255)
                   .HasColumnType("decimal(19,2)");

                entity.Property(e => e.finalamountpayable)
                   .IsRequired()
                   .HasColumnName("finalamountpayable")
                   .HasMaxLength(255)
                   .HasColumnType("decimal(19,2)");

                entity.Property(e => e.USDTotal)
                    .IsRequired()
                    .HasColumnName("USDTotal")
                    .HasMaxLength(255)
                    .HasColumnType("decimal(19,2)");

                entity.Property(e => e.dashboardstatus)
                    .IsRequired()
                    .HasColumnName("dashboardstatus")
                    .HasMaxLength(255)
                    .HasColumnType("text");

                entity.Property(e => e.createdby)
                  .HasColumnName("createdby")
                  .HasMaxLength(150)
                  .HasColumnType("text");
                entity.Property(e => e.comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasMaxLength(255)
                    .HasColumnType("text");
            });
            modelBuilder.Entity<Offlinehours>(entity =>
            {
                entity.ToTable("offlinehours");
                                
                entity.Property(e => e.OfflineHrsID)
                    .HasColumnName("OfflineHrsID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.JobID)
                    .HasColumnName("JobID")
                    .HasMaxLength(255);

                entity.Property(e => e.locale)
                    .HasColumnName("locale")
                    .HasMaxLength(255);

                entity.Property(e => e.PacteraEdgeEmail)
                    .HasColumnName("PacteraEdgeEmail")
                    .HasMaxLength(255);

                entity.Property(e => e.TaskID)
                    .HasColumnName("TaskID")
                    .HasMaxLength(255);

                entity.Property(e => e.WorkID)
                    .HasColumnName("WorkID")
                    .HasMaxLength(255);

                entity.Property(e => e.WorkedHrs)
                    .HasColumnName("WorkedHrs")
                    .HasMaxLength(255);

                entity.Property(e => e.StarshotCrashIsError)
                    .HasColumnName("StarshotCrashIsError")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeOfTaskID)
                    .HasColumnName("TypeOfTaskID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.status)
                    .HasColumnName("status")
                    .HasMaxLength(255);

                entity.Property(e => e.deleted)
                   .HasColumnName("deleted")
                   .HasMaxLength(150)
                   .HasColumnType("text");

                entity.Property(e => e.createdby)
                    .HasColumnName("createdby")
                    .HasColumnType("int(11)");

                entity.Property(e => e.comments)
                   .HasColumnName("comments")
                   .HasMaxLength(150)
                   .HasColumnType("text");
            });

            modelBuilder.Entity<MonthlyReviews>(entity =>
            {
                entity.ToTable("monthlyreviews");

                entity.Property(e => e.MonthlyreviewID)
                    .HasColumnName("MonthlyreviewID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Monthly)
                    .HasColumnName("Monthly")
                    .HasMaxLength(255);

                entity.Property(e => e.Numberofweek)
                    .HasColumnName("Numberofweek")
                    .HasMaxLength(255);

                entity.Property(e => e.Startdate)
                    .HasColumnName("Startdate")
                    .HasMaxLength(255);

                entity.Property(e => e.Enddate)
                    .HasColumnName("Enddate")
                    .HasMaxLength(255);
                                
            });

            modelBuilder.Entity<AssignMonthlyReviews>(entity =>
            {
                entity.ToTable("assignmonthlyreviews");

                entity.Property(e => e.AssignID)
                    .HasColumnName("AssignID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MonthlyreviewID)
                   .HasColumnName("MonthlyreviewID")
                   .HasColumnType("int(11)");
                
                entity.Property(e => e.Rating)
                .HasColumnName("Rating")
                .HasColumnType("int(11)");

                entity.Property(e => e.status)
                    .HasColumnName("status")
                    .HasMaxLength(255);

                entity.Property(e => e.AnnotatorID)
                   .HasColumnName("AnnotatorID")
                   .HasColumnType("int(11)");

                entity.Property(e => e.Monthly)
                    .HasColumnName("Monthly")
                    .HasMaxLength(255);

            });
                modelBuilder.Ignore<SelectListItem>();
            modelBuilder.Ignore<SelectListGroup>();

        }
    }
}
