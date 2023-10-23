using MB.Domain.ArticleCategoryAgg;

namespace MB.Domain.Services;

public class ArticleCategoryValidationService : IArticleCategoryValidationService
{
    private readonly IArticleCategoryRepository _articleCategoryRepository;

    public ArticleCategoryValidationService(IArticleCategoryRepository articleCategoryRepository)
    {
        _articleCategoryRepository = articleCategoryRepository;
    }


    public void CheckThatThisRecordAlreadyExists(string title)
    {
        if (_articleCategoryRepository.Exists(title))
            throw new Exception();
    }
                
}