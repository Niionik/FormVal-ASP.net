using System.ComponentModel.DataAnnotations;

namespace FormVal.Models
{
    public class Data
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Enter a Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please provide the Message Content")]
        [MinLength(10), MaxLength(50)]
        public string Message { get; set; }

    }
}
