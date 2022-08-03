using System.ComponentModel.DataAnnotations.Schema;

namespace FinistAPI.Models
{
    public class Account
    {
        public int AccountId { get; set; }

        [NotMapped]
        public DateOnly ExpirationDate { get; set; }
    }
}
