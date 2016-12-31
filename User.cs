using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CommunitiesChat.Models.DB
{
    public class User
    {
        public User() { }
        public User(string username, byte[] pass, byte[] salt, string email)
        {
            Username = username;
            Password = pass;
            Salt = salt;
            Email = email;
            RegistrationDate = DateTime.UtcNow;
            Profile = new Profile(this);
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Username { get; set; }
        [MaxLength(255)]
        public Byte[] Password { get; set; }
        [MaxLength(255)]
        public byte[] Salt { get; set; }
        [Index(IsUnique = true), MaxLength(255)]
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsAdmin { get; set; }

        public virtual Profile Profile { get; set; }
    }
}