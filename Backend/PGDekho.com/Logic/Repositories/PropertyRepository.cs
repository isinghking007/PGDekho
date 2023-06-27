using Microsoft.Data.SqlClient;
using PGDekho.com.DataContext;
using PGDekho.com.Models;
using System.Data;

namespace PGDekho.com.Logic.Repositories
{
    public class PropertyRepository : IPropertyOwner
    {
        private readonly DBContext _context;

        SqlConnection con = new SqlConnection("Data Source=avinash-kumar;Initial Catalog=PGDekho_com;Integrated Security=True");
        public PropertyRepository(DBContext context)
        {
            _context = context;
        }
        public void Add(PropertyDetails entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(PropertyDetails entity)
        {
            throw new NotImplementedException();
        }

         PropertyDetails IPropertyOwner.AddPropertyDetails(PropertyDetails propertyDetails)
        {
/*            propertyDetails.Photo = String.Empty;*/
            propertyDetails.CreatedDate = DateTime.Now;
            _context.PropertyDetails.Add(propertyDetails);
            _context.SaveChanges();
            return propertyDetails;
        }

        List<Model> IPropertyOwner.AllListedProperty()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_SHOW_ALL_PROPERTIES", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Model> models=new List<Model>();
            if(dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Model m = new Model();
                    m.PropertyName = dt.Rows[i]["PropertyName"].ToString();
                    m.State = dt.Rows[i]["State"].ToString();
                    m.City = dt.Rows[i]["City"].ToString();
                    m.Locality = dt.Rows[i]["Locality"].ToString();
                    m.PropertyType = dt.Rows[i]["PropertyType"].ToString();
                    m.Rent = dt.Rows[i]["Rent"].ToString();
                    m.Deposit = dt.Rows[i]["Deposit"].ToString();
                    m.AgreementRequirement = dt.Rows[i]["AgreementRequirement"].ToString();
                    models.Add(m);
                }
            }
            if(models.Count>0)
            {
                return models;
            }
            else
            {
                return null;
            }
        }
        public IEnumerable<PropertyDetails> ShowAllRecords()
        {
            throw new NotImplementedException();
        }

        public void Update(PropertyDetails entity)
        {
            throw new NotImplementedException();
        }

      
    }
}
