using System.ComponentModel.DataAnnotations;

namespace ProfileKeeper.Data
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "First Name is too long.")]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Last Name is too long.")]
        public string? LastName { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Telephone Number is too long.")]
        public string? TelephoneNumber { get; set; }

        public byte[]? Image { get; set; }

        public string ImagePath
        {
            get
            {
                if (Image == null)
                    return string.Empty;
                return $"data:image/png;base64, {Convert.ToBase64String(Image)}";
            }
        }
    }
}