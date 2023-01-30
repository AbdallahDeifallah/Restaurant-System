using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Restaurant.Models
{
    public partial class AppDbContext : IdentityDbContext<ApplicationUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MasterCategoryMenu> MasterCategoryMenus { get; set; }
        public virtual DbSet<MasterItemMenu> MasterItemMenus { get; set; }
        public virtual DbSet<MasterMenu> MasterMenus { get; set; }
        public virtual DbSet<MasterOffer> MasterOffers { get; set; }
        public virtual DbSet<MasterPartner> MasterPartners { get; set; }
        public virtual DbSet<MasterServices> MasterServices { get; set; }
        public virtual DbSet<MasterSlider> MasterSliders { get; set; }
        public virtual DbSet<MasterSocialMedia> MasterSocialMedia { get; set; }
        public virtual DbSet<MasterWorkingHours> MasterWorkingHours { get; set; }
        public virtual DbSet<SystemSetting> SystemSettings { get; set; }
        public virtual DbSet<TransactionBookTable> TransactionBookTables { get; set; }
        public virtual DbSet<TransactionContactUs> TransactionContactUs { get; set; }
        public virtual DbSet<TransactionNewsletter> TransactionNewsletters { get; set; }

    }
}
