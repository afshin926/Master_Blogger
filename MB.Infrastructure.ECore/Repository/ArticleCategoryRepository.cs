using MB.Domain.ArticleCategoryAgg;

namespace MB.Infrastructure.ECore.Repository
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly MasterBloggerContext _Context;

        public ArticleCategoryRepository(MasterBloggerContext context)
        {
            _Context = context;
        }
        public List<ArticleCategory> GetAll()
        {
            return _Context.ArticleCategories.OrderByDescending(x=>x.Id).ToList();
        }

        public ArticleCategory Get(long id)
        {
            return _Context.ArticleCategories.FirstOrDefault(x => x.Id == id);
        }

        public void Add(ArticleCategory entity)
        {
            _Context.ArticleCategories.Add(entity);
            Save();
        }

       

        public void Save()
        {
            _Context.SaveChanges();
        }
    }
}
