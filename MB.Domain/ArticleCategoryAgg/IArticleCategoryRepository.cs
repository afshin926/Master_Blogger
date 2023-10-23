namespace MB.Domain.ArticleCategoryAgg
{
    public interface IArticleCategoryRepository
    {
        List<ArticleCategory> GetAll();
        ArticleCategory Get(long id);
        void Add(ArticleCategory Entity);
        void Save();
        bool Exists(string title);  
    }
}
