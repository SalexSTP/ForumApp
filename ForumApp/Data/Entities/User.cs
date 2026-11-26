using System.ComponentModel.DataAnnotations;

namespace ForumApp.Data.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }
    }
}
