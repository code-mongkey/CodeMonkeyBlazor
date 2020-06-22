using System.ComponentModel.DataAnnotations;

namespace CodeMonkeyBlazor.Models
{
    public class Idea
    {
        public int ID { get; set; }

        [Required]
        public string Note { get; set; }
    }
}
