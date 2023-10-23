namespace MB.Domain.Services
{
   public interface IArticleCategoryValidationService
   {
       public void CheckThatThisRecordAlreadyExists(string title);

   }
}

