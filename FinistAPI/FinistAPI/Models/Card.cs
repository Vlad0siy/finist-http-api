using System.ComponentModel.DataAnnotations.Schema;

namespace FinistAPI.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public decimal Ammount { get; set; }
        public int Type { get; set; }
        public string? Code { get; set; }
        
        [Column(TypeName = "date")]
        public DateTime ExpirationDate { get; set; }
        public byte[] Icon { get; set; }
        public int AccountId { get; set; }
    }
}
