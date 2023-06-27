namespace PGDekho.com.Models
{
    public class Model
    {
        public string PropertyName { get;set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Locality { get; set; }
        public string PropertyType { get; set; }
        public string Rent { get; set; }
        public string Deposit { get; set; }
        public string AgreementRequirement { get; set; }
    }

    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
