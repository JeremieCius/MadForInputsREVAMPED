using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MadForInputsREVAMPED.Models
{
    public class Madlib
    {
        [Column(TypeName = "varchar(500)")]
        public string Title { get; set; }

        [Required]
        public string AuthorId { get; set; }

        [Required]
        public string Story { get; set; }

        [Required]
        public DateTime DatePublish { get; set; }

        [Required]
        public string Genre { get; set; }

        public Madlib()
        {

        }

        public Madlib(string title, string authorId, string story, DateTime datePublish, string genre)
        {
            Title = title;
            AuthorId = authorId;
            Story = story;
            DatePublish = datePublish;
            Genre = genre;
        }
    }
}