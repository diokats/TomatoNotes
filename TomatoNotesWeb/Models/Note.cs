using System.ComponentModel.DataAnnotations;

namespace TomatoNotesWeb.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
