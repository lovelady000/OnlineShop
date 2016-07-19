﻿using Microsoft.AspNet.Identity.EntityFramework;
using OnlineShop.Model.Models;
using System.Data.Entity;

namespace OnlineShop.Data
{
    public class OnlineShopDbContext :  IdentityDbContext<ApplicationUser>
    {
        public OnlineShopDbContext() : base("OnlineShopConnection")
        { 
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> Footers { set; get; }
        public DbSet<Menu> Menus { set; get; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Page> Pages { set; get; }
        public DbSet<Post> Posts { set; get; }
        public DbSet<PostCategory> PostCategories { set; get; }
        public DbSet<PostTag> PostTags { set; get; }
        public DbSet<Product> Products { set; get; }

        public DbSet<ProductCategory> ProductCategories { set; get; }
        public DbSet<ProductTag> ProductTags { set; get; }
        public DbSet<Slide> Slides { set; get; }
        public DbSet<SupportOnline> SupportOnlines { set; get; }
        public DbSet<SystemConfig> SystemConfigs { set; get; }

        public DbSet<Tag> Tags { set; get; }

        public DbSet<VisitorStatistic> VisitorStatistics { set; get; }
        public DbSet<Error> Errors { set; get; }
        public static OnlineShopDbContext Create()
        {
            return new OnlineShopDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<IdentityUserRole>().HasKey(x => new { x.UserId ,x.RoleId});
            builder.Entity<IdentityUserLogin>().HasKey(x => x.UserId);
        }
    }
}