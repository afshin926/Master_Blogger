using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Peresentation.MVCcore.Areas.Administrator.Pages.ArticleCategoryMangement
{
    public class EditModel : PageModel
    {
        public EditModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        [BindProperty] public RenameArticleCategory ArticleCategory { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        

        public void OnGet(long id)
        {
            ArticleCategory=_articleCategoryApplication.GetRename(id);
        }

        public RedirectToPageResult OnPost()
        {
            _articleCategoryApplication.Rename(ArticleCategory);
            return RedirectToPage("./List");
        }
    }
}
