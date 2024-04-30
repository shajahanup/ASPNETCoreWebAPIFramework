using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNETCoreWebAPIFramework.Models
{
    [Table("tb_users")]
    public class User
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("name")]
        public string Name { get; set; } = string.Empty;

        [Column("password")]
        public string Password { get; set; } = string.Empty;

        [Column("role")]
        public string Role { get; set; } = string.Empty;

        [Column("email")]
        public string Email { get; set; } = string.Empty;

        [Column("is_deleted")]
        public bool IsDeleted { get; set; }

        public User() { }

        public User(long id) 
        {
            Id = id;
        }

        public User(string name, string password, string role)
        {
            Name = name;
            Password = password;
            Role = role;
        }

        public User(long id, string name, string password, string role) : this(id)
        {
            Name = name;
            Password = password;
            Role = role;
        }
    }
}
