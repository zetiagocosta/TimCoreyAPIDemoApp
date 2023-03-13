using System.ComponentModel.DataAnnotations;

namespace TimCoreyAPIDemo.Models
{
    public class Person
    {
        [Required]
        [MinLength(1)]
        public int Id { get; set; } = 0;
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public int Age = 0;

    }
}
