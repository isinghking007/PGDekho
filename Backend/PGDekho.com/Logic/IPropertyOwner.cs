using PGDekho.com.Migrations;
using PGDekho.com.Models;

namespace PGDekho.com.Logic
{
    public interface IPropertyOwner : IGenericRepository<PropertyDetails>
    {

        PropertyDetails AddPropertyDetails(PropertyDetails propertyDetails);
        List<Model> AllListedProperty();
    }
}
