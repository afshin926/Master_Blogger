namespace MB.Application.Contracts.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> list();
        void Create(CreateArticleCategory command);
        void Rename(RenameArticleCategory command);
        RenameArticleCategory GetRename(long id);
        void Remove(long id);
        void Activate(long id);

    }
} 