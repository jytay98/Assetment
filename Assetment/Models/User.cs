using System.ComponentModel.DataAnnotations;

namespace Assetment.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Mail { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string Skillsets { get; set; }
        public string Hobby { get; set; }
    }
}
