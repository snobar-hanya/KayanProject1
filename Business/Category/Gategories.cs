using EntityModel;

namespace Business.Category
{
    public class Gategories
    {
        public Class1 GetCategories()
        {
            var DALObj = new DataAccessLayer.DataAccess();
            var DataModel = DALObj.ReturnList<EntityModel.Category>("dbo.GetAllCategories");
            var DataViewModel = new Class1
            {
                Categories = DataModel,
                Count = DataModel.Count(),
            };
            return DataViewModel;
        }
    }
}
