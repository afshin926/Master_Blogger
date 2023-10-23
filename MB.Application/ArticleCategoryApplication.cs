using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using System.Globalization;

namespace MB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }

        public List<ArticleCategoryViewModel> list()
        {
            var articleCategories = _articleCategoryRepository.GetAll();
            var result= new List<ArticleCategoryViewModel>();
            foreach (var articleCategory in articleCategories)
            {
                result.Add(new ArticleCategoryViewModel
                {
                    Id = articleCategory.Id,
                    Title = articleCategory.Title,
                    IsDeleted = articleCategory.IsDeleted,
                    CreationDate=articleCategory.CreationDate.ToString(CultureInfo.InvariantCulture),   
                });
            }
                return result;
        }

        public void Create(CreateArticleCategory command)
        {
            var articlecategory = new ArticleCategory(command.Title);
            _articleCategoryRepository.Add(articlecategory);
        }

        public void Rename(RenameArticleCategory command)
        {
            var articleCategory = _articleCategoryRepository.Get(command.Id);
            articleCategory.Rename(command.Title);
            _articleCategoryRepository.Save();
        }

        public RenameArticleCategory GetRename(long id)
        {
            var articleCategory= _articleCategoryRepository.Get(id);
            return new RenameArticleCategory
            {
               Id = articleCategory.Id,
                Title = articleCategory.Title
            };
        }

        public void Remove(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Remove();
            _articleCategoryRepository.Save();
        }

        public void Activate(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Activate(); 
            _articleCategoryRepository.Save();
        }
    }
}