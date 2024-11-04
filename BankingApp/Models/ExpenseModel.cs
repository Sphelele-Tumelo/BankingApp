using System.ComponentModel.DataAnnotations;

namespace BankingApp.Models
{
    public class ExpenseModel
    {
        public int id { get; set; }

        public int Value { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
