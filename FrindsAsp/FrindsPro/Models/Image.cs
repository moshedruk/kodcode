using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace FrindsPro.Models
{
    public class Image
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }

        public ClassFrind ClassFrind { get; set; }
        [Display (Name = "img" )]
        public byte[] ImageData { get; set; }       
    }
}
