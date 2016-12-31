using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CommunitiesChat.Models.DB
{
    public class Post
    {
        public Post() { }
        public Post(string title, string message, string image, Profile author, Community community)
        {
            Title = title;
            Message = message;
            Image = image;
            PostingDate = DateTime.UtcNow;
            this.Author = author;
            this.Community = community;
            Comments = new List<Comment>();
        }

        [Key]

        public int Id { get; set; }
        [MaxLength(256)]
        public string Title { get; set; }
        [MaxLength(1024)]
        public string Message { get; set; }
        public string Image { get; set; }
        public int Likes { get; set; }
        public int Unlikes { get; set; }
        public int Score { get { return 1 + Likes - Unlikes; } }
        public DateTime PostingDate { get; set; }

        public virtual Profile Author { get; set; }
        public virtual Community Community { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Identity> Identities { get; set; }
    }
}