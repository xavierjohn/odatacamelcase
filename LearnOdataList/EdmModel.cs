namespace LearnOdataList;

using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

public static class EdmModel
{
  public static IEdmModel GetEdmModel()
  {
    var builder = new ODataConventionModelBuilder().EnableLowerCamelCase();
    builder.EntityType<Order>();
    builder.EntitySet<Customer>("Customers");
    return builder.GetEdmModel();
  }
}
