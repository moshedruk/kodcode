using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test05.Models
{
    public class library
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Name library")]
        public string Name { get; set; }
    }
}
