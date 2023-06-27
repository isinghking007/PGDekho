using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PGDekho.com.Models
{
    public class Photos
    {
        [Key]
        public int PhotoId { get; set; }
        public string publicId { get; set; }
        public string ImageURL { get; set; }
        public bool IsPrimary { get; set; }
        [ForeignKey("propertyDetails")]
        public int? propertyId { get; set; }
        public virtual PropertyDetails PropertyDetails { get; set; }

    }
}
