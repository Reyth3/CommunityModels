using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CommunitiesChat.Models.DB
{
    public class Community
    {
        public Community() { }
        public Community(string name, string shDesc, Profile owner, Category category)
        {
            Name = name;
            ShortDescription = shDesc;
            Description = "Not set yet.";
            CreationTime = DateTime.UtcNow;
            Category = category;
            Owner = owner;
            Subscribers = new List<Profile>();
            Tags = new List<Tag>();
            Posts = new List<Post>();
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(256)]
        public string ShortDescription { get; set; }
        [MaxLength(1024)]
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }

        public virtual Category Category { get; set; }
        public virtual Profile Owner { get; set; }
        public virtual List<Profile> Subscribers { get; set; }
        public virtual List<Tag> Tags { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}