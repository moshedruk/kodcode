using System.Text.RegularExpressions;
using Test05.Models;

namespace Test05.viewsModel
{
    public class modelsLibraryShelf
    {
        public Shelf Shelf { get; set; }
        public List<library> library { get; set; }

        public int? SelectedlibraryId { get; set; }

    }
}
