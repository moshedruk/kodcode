using System.ComponentModel.DataAnnotations;

namespace Test05.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public int height { get; set; }
        public int width { get; set; }

        public Shelf _shelf { get; set; }
    }
}
