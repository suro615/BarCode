using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StepBarCode.Models;

namespace StepBarCode.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        [Display(Name = "公司名称")]
        public string CompanyID { get; set; }
        [ForeignKey("CompanyID")]
        public virtual Company Company { get; set; }

        //[Display(Name = "是否绑定微信号")]
        public bool IsWeChat { get; set; }

    }

    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() { }
        public ApplicationRole(string name) : base(name) { }
        public string Description { get; set; }
    }

    public class STEPBARCODEContext : IdentityDbContext<ApplicationUser>
    {
        public STEPBARCODEContext()
            : base("STEPBARCODECONN", throwIfV1Schema: false)
        {
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ApplicationUserInfo> ApplicationUserInfoes { get; set; }
        public DbSet<SoftWareCode> SoftWareCodes { get; set; }
        public DbSet<DownloadRecord> DownloadRecords { get; set; }
        
        static STEPBARCODEContext()
        {
            // Set the database intializer which is run once during application start
            // This seeds the database with admin user credentials and admin role
            Database.SetInitializer<STEPBARCODEContext>(new ApplicationDbInitializer());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<STEPBARCODEContext, Configuration>());
        }

        public static STEPBARCODEContext Create()
        {
            return new STEPBARCODEContext();
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        //}


    }
}