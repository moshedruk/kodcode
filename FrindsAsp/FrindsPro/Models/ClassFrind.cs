using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace FrindsPro.Models
{
    public class ClassFrind
    {
        public ClassFrind()
        {
            Images = new List<Image>();
        }
        [Key]        
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Phone(ErrorMessage = "Invalid Phone Number")]
        [Display(Name = "Phone")]
        public int PhoneNumber { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public List<Image> Images { get; set; }

        [Display(Name = "add image "), NotMapped]
        public IFormFile SetImage
        {

            get
            {
                return null;
            }
            set
            {
                if (value == null) return;
                {
                    AddImage(value);
                }
            }
        }
        public void AddImage(byte[] img)
        {
            Images.Add(new Image { ClassFrind = this , ImageData = img});
        }
        public void AddImage(IFormFile img) 
        {
            MemoryStream stream = new MemoryStream();
            img.CopyTo(stream);
            AddImage(stream.ToArray());
        }
    }
}
