using Test05.Models;

namespace Test05.viewsModel
{
    public class modelBookShelflibrary
    {
        public Book? book { get; set; }        

        public List<library> library { get; set; }
        
        public int? SelectedlibraryId { get; set; }

        public int? sizeset { get; set; }

        public List<Book>? bookset { get; set; }
    }
}
