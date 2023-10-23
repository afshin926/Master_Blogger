using MB.Application;
using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using MB.Infrastructure.ECore;
using MB.Infrastructure.ECore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrastructure.core
{
    public class Bootstrapper
    {
        public static void Config(IServiceCollection services, string ConectionString)
        {
            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();

            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();

            services.AddDbContext<MasterBloggerContext>(options =>
                options.UseSqlServer(ConectionString));
        }
    }
}