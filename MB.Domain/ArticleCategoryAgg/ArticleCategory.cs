using MB.Domain.Services;

namespace MB.Domain.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get; private set; }

        public ArticleCategory(string title, IArticleCategoryValidationService validationService)
        {
            GuardAgainstEmptyTitle(title);
            validationService.CheckThatThisRecordAlreadyExists(title);
            Title = title;
            IsDeleted = false;
            CreationDate = DateTime.Now;
        }
        
        public void Rename(string title ,IArticleCategoryValidationService validationService)
        {
            GuardAgainstEmptyTitle(title);

            Title= title;
        }

        public void Remove()
        {
            IsDeleted= true;
        }

        public void Activate()
        {
            IsDeleted=false;
        }

        public void GuardAgainstEmptyTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("title");
            }
        }
    }
}
