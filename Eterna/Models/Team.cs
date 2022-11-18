using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Img { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Position { get; set; }
        [Required]
        [MaxLength(300)]
        public string Desc { get; set; }
    }


}
