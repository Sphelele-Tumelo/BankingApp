using System.ComponentModel.DataAnnotations;

namespace BankingApp.Models
{
    public class RegisterModel
    {
        [Required]
        public string ?Initial { get; set; }

        [Required]
        public required string? FirstName{ get; set; }

        [Required]
        public required string MiddleName { get; set; }

        [Required]
        public required string Surname{ get; set; }

        public int Id { get; set; }

        public int DateOfBirth { get; set; }

        [Required]
        public int? ContactDetails { get; set; }

        public string? Email { get; set; }

        public  required string StreetName { get; set; }

        public int StreetNumber { get; set; }

        public required string City { get; set; }

        [Required]
        public int PostalCode { get; set; }

        public int Telephone{ get; set; }

    }
}
