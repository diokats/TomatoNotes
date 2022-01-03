using System.ComponentModel.DataAnnotations;

namespace TomatoNotesWeb.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        [Display(Name ="What?")]
        public string Notes { get; set; }
        [Display(Name ="When?")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
