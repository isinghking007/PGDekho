using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace PGDekho.com.Models
{
    public class PropertyDetails
    {
        [Key]
        public int PropertyId { get; set; }
        [ForeignKey("Register")]
        public int? UserId { get; set; }
        public virtual Register? Register { get; set; }
        public string PropertyName { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string  Locality { get; set; }
        public string Area { get; set; }
        public string PropertyType { get; set; }
        public string One_BHK { get; set; }
        public string Two_BHK { get; set; }
        public string Three_BHK { get; set; }
        public string Four_BHK { get; set; }
        public string Five_BHK { get; set; }
        public string Single_Sharing { get; set; }
        public string Double_Sharing { get; set; }
        public string Triple_Sharing { get; set; }
        public string Four_Sharing { get; set; }
        public string More_Sharing  { get; set; }
        public string? Photo { get; set; }
        public string Rent { get; set; }
        public string Deposit { get; set; }
        public string BookingAmount { get; set; }
        public string MinimumStay { get; set; }
        public string AgreementRequirement { get; set; }

        public DateTime CreatedDate { get; set; }


    }
}
