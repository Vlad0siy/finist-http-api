using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinistAPI.Models
{
    public class OperationHistory
    {
        [Key]
        public int OperationId { get; set; }
        public DateTime DateTime { get; set; }
        public byte Icon { get; set; }
        public int CardId { get; set; }
        public string Name { get; set; }
        public int OperationType { get; set; }
        public decimal Ammount { get; set; }
    }
}
