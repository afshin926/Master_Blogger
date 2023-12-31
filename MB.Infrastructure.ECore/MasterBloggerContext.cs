﻿using MB.Domain.ArticleCategoryAgg;
using MB.Infrastructure.ECore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.ECore
{
    public class MasterBloggerContext :DbContext
    {
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public MasterBloggerContext(DbContextOptions<MasterBloggerContext> options) :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
