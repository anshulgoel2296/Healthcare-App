using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HealthcareAPI.DBModels
{
    public class UserRole
    {
        [Key]
        [Column("UserRoleID")]
        [JsonPropertyName("userRoleId")]
        [Required(ErrorMessage = "UserRoleID is required.")]
        public required int UserRoleID { get; set; }

        [Column("UserRoleName")]
        [JsonPropertyName("userRoleName")]
        [StringLength(50, ErrorMessage = "UserRole Name cannot exceed 50 characters.")]
        [Required(ErrorMessage = "UserRole Name is required.")]
        public required string UserRoleName { get; set; }

        [Column("UserRoleDescription")]
        [JsonPropertyName("userRoleDescription")]
        [StringLength(255, ErrorMessage = "UserRole Description cannot exceed 255 characters.")]
        public string? UserRoleDescription { get; set; }

        [Column("IsActive")]
        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }

        [Column("CreatedDateTime", TypeName = "datetime2")]
        [JsonPropertyName("createdDateTime")]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

        [Column("UpdatedDateTime", TypeName = "datetime2")]
        [JsonPropertyName("updatedDateTime")]
        public DateTime UpdatedDateTime { get; set; } = DateTime.Now;
    }
}
