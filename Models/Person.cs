using System.ComponentModel.DataAnnotations;

namespace Assessment.Models
{
    public class Person
    {
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
