using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Peresentation.MVCcore.Areas.Administrator.Pages.ArticleCategoryMangement
{
    public class CreateModel : PageModel
    {
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public CreateModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost (CreateArticleCategory command)
        {
            _articleCategoryApplication.Create(command);
            return RedirectToPage("./List");
        }
    }
}
