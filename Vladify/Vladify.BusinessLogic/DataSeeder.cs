using Vladify.BusinessLogic.Interfaces;
using Vladify.DataAccess.Interfaces;

namespace Vladify.BusinessLogic;

public class DataSeeder(IDbInitializer dbInitializer) : IDataSeeder
{
    public void SeedData()
    {
        dbInitializer.Initialize();
    }
}
