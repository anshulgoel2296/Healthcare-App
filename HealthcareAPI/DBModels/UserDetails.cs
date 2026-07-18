using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HealthcareAPI.DBModels
{
    [Table("UserDetails", Schema = "dbo")]
    public class UserDetails
    {
        [Key]
        [Column("UserID")]
        [JsonPropertyName("userId")]
        public required int UserID { get; set; }

        [Column("UserName")]
        [JsonPropertyName("userName")]
        public required string UserName { get; set; }

        [Column("UserFirstName")]
        [JsonPropertyName("userFirstName")]
        public required string FirstName { get; set; }

        [Column("UserMiddleName")]
        [JsonPropertyName("userMiddleName")]
        public string? MiddleName { get; set; }

        [Column("UserLastName")]
        [JsonPropertyName("userLastName")]
        public string? LastName { get; set; }

        [Column("UserEmail")]
        [JsonPropertyName("userEmail")]
        public required string UserEmail { get; set; }

        [Column("Password")]
        [JsonPropertyName("password")]
        public required string Password { get; set; }

        [Column("MobileNo")]
        [JsonPropertyName("mobileNo")]
        public string? MobileNo { get; set; }

        [Column("UserRoleID")]
        [JsonPropertyName("userRoleId")]
        public required int UserRoleID { get; set; }

        [Column("FailedLoginAttempts")]
        [JsonPropertyName("failedLoginAttempts")]
        public int? FailedLoginAttempts { get; set; }

        [Column("IsActive")]
        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; } = true;

        [Column("LastLoginDate", TypeName = "datetime2")]
        [JsonPropertyName("lastLoginDate")]
        public DateTime LastLoginDate { get; set; } = DateTime.Now;

        [Column("CreatedDateTime", TypeName = "datetime2")]
        [JsonPropertyName("createdDateTime")]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

        [Column("UpdatedDateTime", TypeName = "datetime2")]
        [JsonPropertyName("updatedDateTime")]
        public DateTime UpdatedDateTime { get; set; } = DateTime.Now;

    }
}
