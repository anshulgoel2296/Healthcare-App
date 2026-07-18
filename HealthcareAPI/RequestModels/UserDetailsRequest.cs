using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HealthcareAPI.RequestModels
{
    public class UserDetailsRequest
    {

        [Column("UserName")]
        [JsonPropertyName("userName")]
        [StringLength(100, ErrorMessage = "User Name cannot exceed 100 characters.")]
        [Required(ErrorMessage = "User Name is required.")]
        public required string UserName { get; set; }

        [Column("UserFirstName")]
        [JsonPropertyName("userFirstName")]
        [StringLength(50, ErrorMessage = "User First Name cannot exceed 50 characters.")]
        [Required(ErrorMessage = "User First Name is required.")]
        public required string FirstName { get; set; }

        [Column("UserMiddleName")]
        [JsonPropertyName("userMiddleName")]
        [StringLength(50, ErrorMessage = "User Middle Name cannot exceed 50 characters.")]
        public string? MiddleName { get; set; }

        [Column("UserLastName")]
        [JsonPropertyName("userLastName")]
        [StringLength(50, ErrorMessage = "User Last Name cannot exceed 50 characters.")]
        public string? LastName { get; set; }

        [Column("UserEmail")]
        [JsonPropertyName("userEmail")]
        [Required(ErrorMessage = "User Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public required string UserEmail { get; set; }

        [Column("Password")]
        [JsonPropertyName("password")]
        [Required(ErrorMessage = "Password is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        [StringLength(255, ErrorMessage = "Password cannot exceed 255 characters.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Password must contain an uppercase letter, lowercase letter, number, and special character.")]
        public required string Password { get; set; }

        [Column("MobileNo")]
        [JsonPropertyName("mobileNo")]
        [MinLength(10, ErrorMessage = "Mobile Number must be at least 10 characters long.")]
        [StringLength(15, ErrorMessage = "Mobile Number cannot exceed 15 characters.")]
        public string? MobileNo { get; set; }

        [Column("UserRoleID")]
        [JsonPropertyName("userRoleId")]
        public required int UserRoleID { get; set; }
    }
}
