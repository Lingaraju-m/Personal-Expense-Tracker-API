using System.ComponentModel.DataAnnotations;

namespace Personal_Expense_Tracker_API.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public ICollection<Transcation> Transactions { get; set; }
            = new List<Transcation>();
    }
}
