using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Amazon.Models
{
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [Required]
        [NotNull]
        public string? UserFirstName { get; set; }
        [Required]
        [NotNull]
        public string? UserLastName { get; set; }

        public string?  Title { get; set; }
        [Required, NotNull]
        public string? TelephonePrim { get; set; }
        [AllowNull]
        public string? TelephoneSec { get; set;}
        [Required]
        [NotNull]
        public string? Email { get; set; }
        [Required]
        [NotNull]
        public string? Password { get; set; }




    }
}
