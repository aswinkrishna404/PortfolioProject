

 using System.ComponentModel.DataAnnotations;

namespace PortfolioProject.Models.Entities
{

    public class Contact
    {
        [Key]

        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }

    }

}
