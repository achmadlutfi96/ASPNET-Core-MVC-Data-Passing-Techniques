using System.ComponentModel.DataAnnotations;
namespace PRGPatternExample.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        public string? Comment { get; set; }
    }
}