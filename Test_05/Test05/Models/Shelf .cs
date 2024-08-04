using System.ComponentModel.DataAnnotations;

namespace Test05.Models
{
    public class Shelf
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int  height { get; set; }
        public int width { get; set; }

        public library _library { get; set; }


    }
}
